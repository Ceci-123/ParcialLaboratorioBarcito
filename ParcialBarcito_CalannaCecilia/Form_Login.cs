using Entidades;
using System;
using System.Windows.Forms;
using UI;

namespace ParcialBarcito_CalannaCecilia
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Olvido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No te preocupes, estamos enviando un link a tu correo para restablecer tu contraseña",
                "Reseteo de contraseña en proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btn_Ingreso_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtBox_Nombre.Text) || String.IsNullOrEmpty(this.txtbox_password.Text))
            {
                MessageBox.Show("Tenes que ingresar tus datos", "Error");
            }
            else
            {

                bool respuesta = Entidades.Persona.ValidarUser(Bar.personal, this.txtBox_Nombre.Text, txtbox_password.Text);
                if (respuesta)
                {
                    int auxiliar = Persona.ValidarRango(Bar.personal, this.txtBox_Nombre.Text);
                    //abro segundo formulario
                    // es admin si es 1 y vendedor es 2
                        Form frm = new Form_Vendedor(this.txtBox_Nombre.Text, auxiliar);
                        this.Hide();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }
                    
                    
                    
                }
                else
                {
                    this.txtBox_Nombre.Text = " ";
                    txtbox_password.Text = " ";
                    MessageBox.Show("Datos incorrectos, proba de nuevo", "Error");
                }
            }

        }

        private void btn_Autocompleta_Vendedor_Click(object sender, EventArgs e)
        {
            this.txtBox_Nombre.Text = "morena";
            this.txtbox_password.Text = "more123";
        }

        private void btn_Autocompleta_Admin_Click(object sender, EventArgs e)
        {
            this.txtBox_Nombre.Text = "mauricio";
            this.txtbox_password.Text = "mauri123";
        }

        private void Form_Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
        }
    }
}
