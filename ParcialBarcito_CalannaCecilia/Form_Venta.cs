using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_Venta : Form
    {
        string numero;
        public Form_Venta(string numero)
        {
            InitializeComponent();
            this.numero = numero;
        }
        private void Form_Venta_Load(object sender, EventArgs e)
        {
            this.lbl_titulo.Text = $"Mesa {this.numero} ";
        }



        private void btn_AgregarProductos_Click(object sender, EventArgs e)
        {
            //Entidades.Bar.VentaEnMesa(Entidades.Bar.ListaDePuestosDeVenta[Int32.Parse(numero)],
            //    Entidades.Bar.CosasEnElInventario, Entidades.Bar.ListaDePuestosDeVenta[Int32.Parse(numero)].consumicion);
            
        }



        private void btn_cerrarMesa_Click(object sender, EventArgs e)
        {
            Form frm_ticket = new Form_Ticket();
            frm_ticket.ShowDialog();
        }
        //suma todo lo consumido y el estacionamiento y recargo tarjeta

    }
}

