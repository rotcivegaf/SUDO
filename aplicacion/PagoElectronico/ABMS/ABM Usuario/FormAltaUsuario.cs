using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Dominio;
using PagoElectronico.DAO;
using PagoElectronico.Services;
using PagoElectronico.Utils;
using PagoElectronico.DTO;

namespace PagoElectronico.ABM_Usuario
{
    public partial class FormAltaUsuario : Form
    {
        private List<PreguntaSecretaDTO> preguntas { get; set; }
        public FormAltaUsuario()
        {
            InitializeComponent();
            fillRoles();
            fillPreguntasSecretas();

        }

        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxUsuarioAlta_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e){
            try{
                if (!username.Text.Equals("") && !password.Equals("") && 
                    !rolSelected.SelectedValue.ToString().Equals("-1") &&
                    !preguntaSecSelected.SelectedValue.ToString().Equals("-1") &&
                    !rtaSecreta.Text.Equals("")){
                        Usuario u = new Usuario("-1", username.Text, password.Text, preguntaSecSelected.SelectedValue.ToString(),
                                                    rtaSecreta.Text, DateTime.Today.ToString(), DateTime.Today.ToString(), "0", "" );

                    DialogResult resultado;
                    resultado = MessageBox.Show("Confirma dar de alta, el usuario. user: " + u.userName, "Confirmacion Alta Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        int res;
                        res = UsuarioServices.SaveUser(u);
                        if (res == 0)
                        {
                            username.Text = "";
                            password.Text = "";
                            rtaSecreta.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se cancelo la operacion");
                    }

                }

                else
                {

                    MessageBox.Show("Complete todos los campos");
                }

            }//try
            catch (FormatException)
            {

                MessageBox.Show("Se ingreso un dato con formato incorrecto");

            }
        }

        private void buttonCancelAltaUser_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void textBoxRtaSecreta_TextChanged(object sender, EventArgs e)
        {

        }

        private void rolSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        private void fillRoles() {
            rolSelected.DataSource = RolServices.getRoles();
            rolSelected.DisplayMember = "nombreRol";
            rolSelected.ValueMember = "idRol";
        }

        private void fillPreguntasSecretas() {
            List<PreguntaSecretaDTO> listPreguntas = new List<PreguntaSecretaDTO>();
            listPreguntas.Add(PreguntaSecretaDTO.build(PreguntaSecretaEnum.CANCION_FAVORITA.GetValue(), PreguntaSecretaEnum.CANCION_FAVORITA.GetName()));
            listPreguntas.Add(PreguntaSecretaDTO.build(PreguntaSecretaEnum.NOMBRE_ABUELA.GetValue(), PreguntaSecretaEnum.NOMBRE_ABUELA.GetName()));
            listPreguntas.Add(PreguntaSecretaDTO.build(PreguntaSecretaEnum.PRIMER_MASCOTA.GetValue(), PreguntaSecretaEnum.PRIMER_MASCOTA.GetName()));

            foreach (PreguntaSecretaDTO dto in listPreguntas)
            {
                preguntaSecSelected.Items.Add(dto.valor);

            }            
        }
    }
}
