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
                float auxiliarFloat;
                float.TryParse(this.txtBx_precio.Text, out auxiliarFloat);
                short auxiliarShort;
                auxiliarShort = (((short)this.num_cantidad.Value));
                Bar.AgregarMercaderia(new Producto(
                this.txtBx_nombre.Text,
                this.chk_bebida.Checked,
                auxiliarFloat,
                this.chk_vegano.Checked, this.chk_celiacos.Checked),
                auxiliarShort);
                MessageBox.Show("Producto agregado");
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
                    SoundPlayer sonido = new SoundPlayer(@"\Resources\sonido_corto.wav");
                    sonido.Play();
                    
                }
            }
            catch (Exception)
            {
                //Console.Beep();
                SystemSounds.Exclamation.Play();
             
            }
        }

    }
}
