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

namespace PagoElectronico.Listados
{
    public partial class FormListado : Form
    {
        public FormListado(int idUser)
        {
            InitializeComponent();
        }

        private void FormListado_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en el campo año", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private bool datosLlenos()
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Complete los datos");
                return false;
            }
            else
            {
                if ((Convert.ToInt32(textBox1.Text) <= 1900) || (Convert.ToInt32(textBox1.Text) >= 3000))
                {
                    MessageBox.Show("Corrija el año");
                    return false;
                } else
                {
                    return true;
                }
            }
        }

        private void botonConsultar4_Click(object sender, EventArgs e)
        {
            if (datosLlenos())
            {
                dGV4.Rows.Clear();
                List<SqlParameter> parametros4 = new List<SqlParameter>();

                SqlParameter paramFechaInicio = null;
                SqlParameter paramFechaFin = null;
                switch (comboBox1.Text)
                {
                    case "1":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-01-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-03-31");
                        break;
                    case "2":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-03-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-06-30");
                        break;
                    case "3":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-06-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-09-30");
                        break;
                    case "4":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-09-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-12-31");
                        break;
                }
                parametros4.Add(paramFechaInicio);
                parametros4.Add(paramFechaFin);

                SqlDataReader reader4 = DAO.ConexionDB.ejecReaderProc("SUDO.GetListado4", parametros4);
                for (; reader4.Read(); )
                {
                    dGV4.Rows.Add(reader4["descripcion"], reader4["cantidad"]);
                }
            }
        }

        private void botonConsultar5_Click(object sender, EventArgs e)
        {
            if (datosLlenos())
            {
                dGV5.Rows.Clear();
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter paramFechaInicio = null;
                SqlParameter paramFechaFin = null;
                switch (comboBox1.Text)
                {
                    case "1":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-01-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-03-31");
                        break;
                    case "2":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-03-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-06-30");
                        break;
                    case "3":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-06-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-09-30");
                        break;
                    case "4":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-09-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-12-31");
                        break;
                }
                parametros.Add(paramFechaInicio);
                parametros.Add(paramFechaFin);

                SqlDataReader reader = DAO.ConexionDB.ejecReaderProc("SUDO.GetListado5", parametros);
                for (; reader.Read(); )
                {
                    dGV5.Rows.Add(reader["nombre"], reader["total"]);
                }
            }
        }

        private void botonConsultar1_Click(object sender, EventArgs e)
        {
            if (datosLlenos())
            {
                dGV1.Rows.Clear();
                List<SqlParameter> parametros1 = new List<SqlParameter>();

                SqlParameter paramFechaInicio = null;
                SqlParameter paramFechaFin = null;
                switch (comboBox1.Text)
                {
                    case "1":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-01-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-03-31");
                        break;
                    case "2":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-03-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-06-30");
                        break;
                    case "3":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-06-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-09-30");
                        break;
                    case "4":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-09-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-12-31");
                        break;
                }
                parametros1.Add(paramFechaInicio);
                parametros1.Add(paramFechaFin);

                SqlDataReader reader1 = DAO.ConexionDB.ejecReaderProc("SUDO.GetListado1", parametros1);
                for (; reader1.Read(); )
                {
                    dGV1.Rows.Add(reader1["idCliente"], reader1["userName"], reader1["cant"]);
                }
            }
        }

        private void botonConsultar3_Click(object sender, EventArgs e)
        {
            if (datosLlenos())
            {
                dGV3.Rows.Clear();
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter paramFechaInicio = null;
                SqlParameter paramFechaFin = null;
                switch (comboBox1.Text)
                {
                    case "1":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-01-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-03-31");
                        break;
                    case "2":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-03-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-06-30");
                        break;
                    case "3":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-06-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-09-30");
                        break;
                    case "4":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-09-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-12-31");
                        break;
                }
                parametros.Add(paramFechaInicio);
                parametros.Add(paramFechaFin);

                SqlDataReader reader = DAO.ConexionDB.ejecReaderProc("SUDO.GetListado3", parametros);
                for (; reader.Read(); )
                {
                    dGV3.Rows.Add(reader["idCliente"], reader["userName"], reader["cant"]);
                }
            }
        }

        private void botonConsultar2_Click(object sender, EventArgs e)
        {
            if (datosLlenos())
            {
                dGV2.Rows.Clear();
                List<SqlParameter> parametros2 = new List<SqlParameter>();

                SqlParameter paramFechaInicio = null;
                SqlParameter paramFechaFin = null;
                switch (comboBox1.Text)
                {
                    case "1":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-01-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-03-31");
                        break;
                    case "2":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-03-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-06-30");
                        break;
                    case "3":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-06-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-09-30");
                        break;
                    case "4":
                        paramFechaInicio = new SqlParameter("@fechaInicio", textBox1.Text + "-09-01");
                        paramFechaFin = new SqlParameter("@fechaFin", textBox1.Text + "-12-31");
                        break;
                }
                parametros2.Add(paramFechaInicio);
                parametros2.Add(paramFechaFin);

                SqlDataReader reader2 = DAO.ConexionDB.ejecReaderProc("SUDO.GetListado2", parametros2);
                for (; reader2.Read(); )
                {
                    dGV2.Rows.Add(reader2["idCliente"], reader2["userName"], reader2["cant"]);
                }
            }
        }
   }
}
