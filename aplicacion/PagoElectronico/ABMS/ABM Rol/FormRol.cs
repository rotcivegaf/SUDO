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
    public partial class FormRol : Form
    {
        public FormRol()
        {
            InitializeComponent();
            actualizarDGRoles();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void actualizarDGRoles()
        {
            DGRoles.Rows.Clear();
            comboBoxIdRoles.Items.Clear();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader readerRoles = DAO.ConexionDB.ejecReaderProc("SUDO.GetRoles", parametros);
            for (; readerRoles.Read(); )
            {
                DGRoles.Rows.Add(readerRoles["idRol"], readerRoles["nombreRol"], readerRoles["estado"]);
                comboBoxIdRoles.Items.Add(readerRoles["idRol"]);
            }
        }

        private void botonModificarEstado_Click(object sender, EventArgs e)
        {
            if (comboBoxIdRoles.Text != "")
            {
                bajaAltaRol();
                actualizarDGRoles();
            }
            else
            {
                MessageBox.Show("Seleccione un ID Rol");
            }
        }
        private void bajaAltaRol()
        {
            int idRol = Convert.ToInt32(comboBoxIdRoles.Text);

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter parametroIdRol = new SqlParameter("@idRol", idRol);
            parametros.Add(parametroIdRol);
            DAO.ConexionDB.ejecScalarProc("SUDO.ModificarEstadoRol", parametros);
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametroNombre = new SqlParameter("@Nombre", "nuevo Rol");
            parametros.Add(parametroNombre);
            SqlParameter parametroEstado = new SqlParameter("@Estado", "0");
            parametros.Add(parametroEstado);
            DAO.ConexionDB.ejecScalarProc("SUDO.NuevoRol", parametros);
            
            actualizarDGRoles();
        }

        private void botonModificarNombre_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBoxIdRoles.Text != "")
            {
                modificarNombreRol();
                actualizarDGRoles();
            }
            else
            {
                MessageBox.Show("Seleccione un ID Rol, y complete el nombre del rol");
            }
        }
        private void modificarNombreRol()
        {
            int idRol = Convert.ToInt32(comboBoxIdRoles.Text);

            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter parametroIdRol = new SqlParameter("@idRol", idRol);
            parametros.Add(parametroIdRol);
            SqlParameter parametroNombre = new SqlParameter("@nombre", textBox1.Text);
            parametros.Add(parametroNombre);
            DAO.ConexionDB.ejecScalarProc("SUDO.ModificarNombreRol", parametros);
        }

        private void botonModificarFuncionalidades_Click(object sender, EventArgs e)
        {
            if (comboBoxIdRoles.Text != "")
            {
                FormModificarFuncionalidades formModificarFuncionalidades = new FormModificarFuncionalidades(Convert.ToInt32(comboBoxIdRoles.Text));
                formModificarFuncionalidades.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione un ID Rol");
            } 
        }

    }
}
