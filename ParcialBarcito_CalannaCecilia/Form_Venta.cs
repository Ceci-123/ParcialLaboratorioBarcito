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
        string numero;
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
            this.numero = numero;
        }
        private void Form_Venta_Load(object sender, EventArgs e)
        {
            this.lbl_titulo.Text = $"Mesa {this.numero} ";
            this.cmbBx_producto.DataSource = Enum.GetValues(typeof(EMorfi));
        }



        private void btn_AgregarProductos_Click(object sender, EventArgs e)
        {
            //Venta nuevaVenta = new Venta(""); 
            _=this.cmbBx_producto.SelectedItem;
            _=this.num_cantidad.Text;
            _ = this.numero;
            // 
            PlaySound();
        }



        private void btn_cerrarMesa_Click(object sender, EventArgs e)
        {
            PlaySound();
            //liberar mesa con liberarpuestodeventa
            
            Form frm_ticket = new Form_Ticket();
            frm_ticket.ShowDialog();
        }
        //suma todo lo consumido y el estacionamiento y recargo tarjeta
        private void PlaySound()
        {
            try
            {
                SoundPlayer sonido = new SoundPlayer(@"..\sonido_corto.wav");
                sonido.Play();
            }
            catch (Exception)
            {
                Console.Beep();
            }

        }
    }
}

