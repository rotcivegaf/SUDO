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
using PagoElectronico.Dominio;

namespace PagoElectronico.ABMS.ABM_Rol
{
    public partial class FormModificarFuncionalidades : Form
    {
        int idRol;

        public FormModificarFuncionalidades(int rolId)
        {
            idRol = rolId;
            InitializeComponent();
            actualizarForm();
        }

        private void FormModificarFuncionalidades_Load(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void botonAgregarQuitar_Click(object sender, EventArgs e)
        {
            if (comboBoxFuncionalidades.Text != "")
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                SqlParameter parametro = new SqlParameter("@idRol", idRol);
                parametros.Add(parametro);
                SqlParameter parametro2 = new SqlParameter("@funcionalidad", comboBoxFuncionalidades.Text);
                parametros.Add(parametro2);

                DAO.ConexionDB.ejecScalarProc("SUDO.AgregarQuitarFuncionalidad", parametros);

                actualizarForm();
            }
            else
            {
                MessageBox.Show("Seleccione una Funcionalidad Disponible del combo box");
            }
        }

        private void actualizarForm()
        {
            DGFuncionalidades.Rows.Clear();
            comboBoxFuncionalidades.Items.Clear();

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@idRol", idRol);
            parametros.Add(parametro);
            SqlDataReader readerFuncionalidades = DAO.ConexionDB.ejecReaderProc("SUDO.GetFuncionalidadesDelRol", parametros);
            for (; readerFuncionalidades.Read(); )
            {
                DGFuncionalidades.Rows.Add(readerFuncionalidades["idFuncionalidad"], readerFuncionalidades["nombre"]);
            }

            List<SqlParameter> parametros2 = new List<SqlParameter>();
            SqlDataReader readerFuncionalidadesDisponibles = DAO.ConexionDB.ejecReaderProc("SUDO.GetFuncionalidadesDisponibles", parametros2);
            for (; readerFuncionalidadesDisponibles.Read(); )
            {
                comboBoxFuncionalidades.Items.Add(readerFuncionalidadesDisponibles["nombre"]);
            }

        }
    }
}
