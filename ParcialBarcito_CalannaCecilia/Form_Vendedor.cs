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
    public partial class Form_Vendedor : Form
    {
        public string nombre;
        public Form_Vendedor(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        private void btn_Mesa1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Vendedor_Load(object sender, EventArgs e)
        {
            this.lbl_Saludo.Text = "Bienvenido " + nombre;
        }

        private void btn_Mesa2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa10_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa11_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa12_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa13_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa14_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mesa15_Click(object sender, EventArgs e)
        {

        }

        private void btn_Barra1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Barra2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Barra3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Barra4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Barra5_Click(object sender, EventArgs e)
        {

        }

        private void btn_BusquedaMesa_Click(object sender, EventArgs e)
        {

        }

        private void btn_VerNomina_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ticket_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarMercaderia_Click(object sender, EventArgs e)
        {

        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
          
        }

        private void Form_Vendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
        }
    }
}
