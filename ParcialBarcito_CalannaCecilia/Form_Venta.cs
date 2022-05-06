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
    public partial class Form_Venta : Form
    {
        string numeroPuesto;
        public enum EMorfi
        {
            Cerveza,
            Cocacola,
            Fernet,
            Daiquiri,
            Manaos,
            Tequeños,
            Papasfritas,
            Hamburguesa,
            Empanadas,
            Picadita
        }
        public Form_Venta(string numero)
        {
            InitializeComponent();
            this.numeroPuesto = numero;
        }
       
        private void btn_AgregarProductos_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            if(!String.IsNullOrEmpty(cmbBx_producto.Text)
                && !String.IsNullOrEmpty(this.numeroPuesto)
                && !String.IsNullOrEmpty(this.num_cantidad.ToString()))
            {
                Bar.Venta(this.numeroPuesto, this.cmbBx_producto.SelectedItem.ToString(),this.num_cantidad.Value.ToString());
                MessageBox.Show("producto agregado");
            }
            else
            {
                MessageBox.Show("Debe ingresar un producto");
            }
            
        }

        private void btn_cerrarMesa_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            Form frm_ticket = new Form_Ticket(this.numeroPuesto);
            frm_ticket.ShowDialog();
        }
       
        
        private void Form_Venta_Load_1(object sender, EventArgs e)
        {
            this.lbl_titulo.Text = $"{this.numeroPuesto}";
            this.cmbBx_producto.DataSource = Enum.GetNames(typeof(EMorfi));
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
                    SoundPlayer sonido = new SoundPlayer(Properties.Resources.sonido_largo);
                    sonido.Play();
                }
                else
                {
                    SoundPlayer sonido = new SoundPlayer(Properties.Resources.sonido_corto);
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

