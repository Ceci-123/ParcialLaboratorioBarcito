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

        private void btn_producto1_Click(object sender, EventArgs e)
        {
            //agrego a la mesa cerveza segun cuantos
            
        }
    }
}
