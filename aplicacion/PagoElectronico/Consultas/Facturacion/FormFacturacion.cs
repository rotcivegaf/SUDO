using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using PagoElectronico.Login;
using PagoElectronico.Utils;

namespace PagoElectronico.Facturacion
{
    public partial class FormFacturacion : Form
    {
        GestorLogin gestorLogin = new GestorLogin();
        ConfigInicial configInicial = new ConfigInicial();
        int idUser;

        public FormFacturacion(int userId)
        {
            idUser = userId;
            InitializeComponent();

            SqlDataReader reader = gestorLogin.ConsultarConIdUsuario(idUser, "SUDO.GetCuentas");

            comboBox1.Items.Add("");
            for (; reader.Read(); )
            {
                comboBox1.Items.Add(reader["nroCuenta"].ToString());
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            actualizarItems();
        }

        private void actualizarItems()
        {
            DGItems.Rows.Clear();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter idUsuario = new SqlParameter("@idUsuario", Convert.ToInt64(idUser));
            parametros.Add(idUsuario);
            SqlParameter idCuenta = new SqlParameter("@idCuenta", Convert.ToInt64(comboBox1.Text));
            parametros.Add(idCuenta);
            SqlDataReader readerItems = DAO.ConexionDB.ejecReaderProc("SUDO.GetTransferenciasAFacturar", parametros);
            for (; readerItems.Read(); )
            {
                DGItems.Rows.Add(readerItems["idTrans"], readerItems["nroCuentaOrigen"], readerItems["nroCuentaDest"], readerItems["fecha"], readerItems["costo"], readerItems["importe"], readerItems["moneda"]);
            }
            
            DGFactCuentas.Rows.Clear();
            List<SqlParameter> parametrosCuentas = new List<SqlParameter>();
            SqlParameter idUsuario2 = new SqlParameter("@idUsuario", Convert.ToInt64(idUser));
            parametrosCuentas.Add(idUsuario2);
            SqlParameter idCuenta2 = new SqlParameter("@idCuenta", Convert.ToInt64(comboBox1.Text));
            parametrosCuentas.Add(idCuenta2);
            SqlDataReader readerCuentas = DAO.ConexionDB.ejecReaderProc("SUDO.GetCambiosCuentaAFacturar", parametrosCuentas);
            for (; readerCuentas.Read(); )
            {
                DGFactCuentas.Rows.Add(readerCuentas["idFactCuenta"], readerCuentas["nroCuenta"], readerCuentas["importe"], readerCuentas["fecha"], readerCuentas["descripcion"], readerCuentas["moneda"]);
            }
        }

        private void botonFacturar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" &&(DGItems.SelectedRows.Count > 0 || DGItems.SelectedRows.Count > 0))
            {
                long idTrans;
                List<SqlParameter> parametros;
                SqlParameter parametro;
                SqlParameter parametro2;

                List<SqlParameter> parametrosFactura = new List<SqlParameter>();
                SqlParameter idUsuario = new SqlParameter("@idUsuario", Convert.ToInt32(idUser));
                parametrosFactura.Add(idUsuario);
                SqlParameter fecha = new SqlParameter("@fecha", configInicial.GetFecha());
                parametrosFactura.Add(fecha);

                SqlDataReader readerFactura = DAO.ConexionDB.ejecReaderProc("SUDO.CrearFactura", parametrosFactura);
                readerFactura.Read();
                long idFact = Convert.ToInt64(readerFactura["idFact"]);

                int i;
                for (i = 0; i < DGItems.SelectedRows.Count; i++)
                {
                    idTrans = Convert.ToInt64(DGItems.SelectedRows[i].Cells[0].Value);

                    parametros = new List<SqlParameter>();
                    parametro = new SqlParameter("@idTrans", idTrans);
                    parametros.Add(parametro);
                    parametro2 = new SqlParameter("@idFact", idFact);
                    parametros.Add(parametro2);
                    DAO.ConexionDB.ejecScalarProc("SUDO.FacturarTransaccion", parametros);
                }

                int j;
                int idFactCuent;
                for (j = 0; j < DGFactCuentas.SelectedRows.Count; j++)
                {
                    idFactCuent = Convert.ToInt32(DGFactCuentas.SelectedRows[j].Cells[0].Value);

                    parametros = new List<SqlParameter>();
                    parametro = new SqlParameter("@idFactCuenta", idFactCuent);
                    parametros.Add(parametro);
                    parametro2 = new SqlParameter("@idFact", idFact);
                    parametros.Add(parametro2);
                    DAO.ConexionDB.ejecScalarProc("SUDO.FacturarCambioCuenta", parametros);
                }

                if ((i+j) >= 5)
                {
                    parametros = new List<SqlParameter>();
                    parametro = new SqlParameter("@idCuenta", comboBox1.Text);
                    parametros.Add(parametro); 

                    DAO.ConexionDB.ejecNonQueryProc("SUDO.InhabilitarCuenta", parametros);
                }

                actualizarItems();
            }
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {

        }
    }
}
