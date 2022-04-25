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
    public partial class Form_Vendedor : Form
    {
        public string nombre;
        public int rangoDelUsuarioLogueado;
        public Form_Vendedor(string nombre, int rango)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.rangoDelUsuarioLogueado = rango;
        }

        private void btn_Mesa1_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("1");
            frm_venta.ShowDialog();
        }

        private void Form_Vendedor_Load(object sender, EventArgs e)
        {
            this.lbl_Saludo.Text = "Bienvenid@ " + nombre;
            playSound();
            if (rangoDelUsuarioLogueado == 1)
            {
                // es admin si es 1 y vendedor es 2
                this.BackColor = Color.DarkSalmon;
            }
            else if (rangoDelUsuarioLogueado == 2)
            {
                this.BackColor = Color.DarkCyan;
                this.btn_AgregarMercaderia.Visible = false;
                this.btn_FacturacionDiaria.Visible = false;
                this.btn_VerNomina.Visible = false; 
            }
        }

        private void btn_Mesa2_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("2");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa3_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("3");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa4_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("4");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa5_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("5");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa6_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("6");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa7_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("7");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa8_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("8");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa9_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("9");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa10_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("10");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa11_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("11");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa12_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("12");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa13_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("13");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa14_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("14");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa15_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("15");
            frm_venta.ShowDialog();
        }

        private void btn_Barra1_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("b1");
            frm_venta.ShowDialog();
        }

        private void btn_Barra2_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("b2");
            frm_venta.ShowDialog();
        }

        private void btn_Barra3_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("b3");
            frm_venta.ShowDialog();
        }

        private void btn_Barra4_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("b4");
            frm_venta.ShowDialog();
        }

        private void btn_Barra5_Click(object sender, EventArgs e)
        {
            Form frm_venta = new Form_Venta("b5");
            frm_venta.ShowDialog();
        }

        private void btn_BusquedaMesa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Bar.BuscarSitioLibre(), "Busqueda de sitio libre");
        }

        private void btn_VerNomina_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Bar.MostrarPersonal(), "Listado de empleados");
        }

        private void btn_Ticket_Click(object sender, EventArgs e)
        {
            Form frm_ticket = new Form_Ticket();
            frm_ticket.ShowDialog();
        }

        private void btn_AgregarMercaderia_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stock" + Bar.MostrarInventario(), "Productos en stock");
        }

        private void Form_Vendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            {
                this.DialogResult = DialogResult.OK;
                e.Cancel = false;
            }
        }

        private void btn_FacturacionDiaria_Click(object sender, EventArgs e)
        {
            //sumar todas las mesas
        }

        private void playSound()
        {
            try
            {
                SoundPlayer sonido = new SoundPlayer(@"..\sonido_largo.wav");
                sonido.Play();
            }
            catch (Exception)
            {
                Console.Beep();
            }

           
            
        }
    }
}
