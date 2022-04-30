using Entidades;
using System;
using System.Windows.Forms;
using UI;

namespace ParcialBarcito_CalannaCecilia
{
    public partial class Form_Login : Form
    {
        private static Persona? usuarioLogueado;

        public Persona UsuarioLogueado { get => usuarioLogueado; }

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
                
                bool respuesta = Persona.ValidarUser(Bar.ListadoDePersonal, this.txtBox_Nombre.Text, txtbox_password.Text);
                if (respuesta)
                {
                    int auxiliar = Persona.ValidarRango(Bar.ListadoDePersonal, this.txtBox_Nombre.Text);
                    if(auxiliar == 1)
                    {
                        // es admin si es 1
                        usuarioLogueado = new Administrador(this.txtBox_Nombre.Text, txtbox_password.Text);
                    }
                    else
                    {
                        // es vendedor si es 2
                        usuarioLogueado = new Vendedor(this.txtBox_Nombre.Text, txtbox_password.Text);
                    }
                    
                    
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

       
    }
}
