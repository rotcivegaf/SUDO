using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using PagoElectronico.DAO;

namespace PagoElectronico.Tarjetas
{
    public partial class FormTarjetas : Form
    {
        int idUser;
        public FormTarjetas(int userId)
        {
            idUser = userId;
            InitializeComponent();
            actualizarTarjetas();
        }

        private void FormTarjetas_Load(object sender, EventArgs e)
        {

        }

        private void DGTarjetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonDesasociar_Click(object sender, EventArgs e)
        {
            if (DGTarjetas.SelectedRows.Count == 1)
            {
                desasociarTarjeta();
                actualizarTarjetas();
            }
            else
            {
                MessageBox.Show("Seleccione solamente una fila");
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            actualizarTarjetas();
        }

        private void botonAsociar_Click(object sender, EventArgs e)
        {
            FormNuevaTarjeta formNuevaTarjeta = new FormNuevaTarjeta(idUser);
            formNuevaTarjeta.Show(this);
            this.Hide();
        }

        private void actualizarTarjetas()
        {
            DGTarjetas.Rows.Clear();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter idCuenta = new SqlParameter("@idUsuario", Convert.ToInt64(idUser));
            parametros.Add(idCuenta);
            SqlDataReader readerTarjetas = DAO.ConexionDB.ejecReaderProc("SUDO.GetTarjetas", parametros);
            for (; readerTarjetas.Read(); )
            {
                DGTarjetas.Rows.Add(readerTarjetas["idTarjeta"], readerTarjetas["ult4num"], readerTarjetas["fechaEmision"], readerTarjetas["fechaVencimiento"], readerTarjetas["descripcion"], readerTarjetas["estado"]);
            }
        }
        private void desasociarTarjeta()
        {
            long idTarjeta = Convert.ToInt64(DGTarjetas.SelectedCells[0].Value);
            List<SqlParameter> parametrosDesasociar = new List<SqlParameter>();
            SqlParameter parametroIdTarjeta = new SqlParameter("@idTarjeta", idTarjeta);
            parametrosDesasociar.Add(parametroIdTarjeta);
            DAO.ConexionDB.ejecScalarProc("SUDO.DesasociarTarjeta", parametrosDesasociar);        
        }

    }
}
