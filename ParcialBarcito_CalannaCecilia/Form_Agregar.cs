using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class Form_Agregar : Form
    {
        public Form_Agregar()
        {
            InitializeComponent();
        }
      
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            if(!String.IsNullOrEmpty(this.txtBx_nombre.Text) && !String.IsNullOrEmpty(this.txtBx_precio.Text))
            {
                Bar.AgregarMercaderia(new Entidades.Producto(
                this.txtBx_nombre.Text,
                this.chk_bebida.Checked,
                float.Parse(this.txtBx_precio.Text),
                this.chk_vegano.Checked, this.chk_celiacos.Checked),
                short.Parse(this.num_cantidad.ToString()));
            }
            else
            {
                MessageBox.Show("Debe completar los campos");
            }    
            
        }


        private void Form_Agregar_Load(object sender, EventArgs e)
        {
            PlaySound(1);
        }

        /// <summary>
        /// Reproduce sonidos
        /// </summary>
        /// <param name="duracion">Duracion del sonido a reproducir</param>
        private void PlaySound(int duracion)
        {
            try
            {
                if (duracion == 1)
                {
                    SoundPlayer sonido = new SoundPlayer(@"..\sonido_largo.wav");
                    sonido.Play();
                }
                else
                {
                    SoundPlayer sonido = new SoundPlayer(@"..\sonido_corto.wav");
                    sonido.Play();

                }
            }
            catch (Exception)
            {
                Console.Beep();
            }
        }

    }
}
