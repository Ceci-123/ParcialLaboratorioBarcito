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
using ParcialBarcito_CalannaCecilia;

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

        

        private void Form_Vendedor_Load(object sender, EventArgs e)
        {
            this.lbl_Saludo.Text = "Bienvenid@ " + nombre;
            ColocarMesasEnVerde();
            PlaySound();
            if (rangoDelUsuarioLogueado == 1)
            {
                // es admin si es 1 y vendedor es 2
                this.BackColor = Color.PaleVioletRed;
            }
            else if (rangoDelUsuarioLogueado == 2)
            {
                this.BackColor = Color.Plum;
                this.btn_AgregarMercaderia.Visible = false;
                this.btn_FacturacionDiaria.Visible = false;
                this.btn_VerNomina.Visible = false; 
            }
        }

        private void btn_Mesa1_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 1");
            Form frm_venta = new Form_Venta("Mesa 1");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa2_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 2");
            Form frm_venta = new Form_Venta("Mesa 2");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa3_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 3");
            Form frm_venta = new Form_Venta("Mesa 3");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa4_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 4");
            Form frm_venta = new Form_Venta("Mesa 4");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa5_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 5");
            Form frm_venta = new Form_Venta("Mesa 5");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa6_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 6");
            Form frm_venta = new Form_Venta("Mesa 6");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa7_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 7");
            Form frm_venta = new Form_Venta("Mesa 7");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa8_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 8");
            Form frm_venta = new Form_Venta("Mesa 8");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa9_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 9");
            Form frm_venta = new Form_Venta("Mesa 9");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa10_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 10");
            Form frm_venta = new Form_Venta("Mesa 10");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa11_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 11");
            Form frm_venta = new Form_Venta("Mesa 11");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa12_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 12");
            Form frm_venta = new Form_Venta("Mesa 12");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa13_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 13");
            Form frm_venta = new Form_Venta("Mesa 13");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa14_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 14");
            Form frm_venta = new Form_Venta("Mesa 14");
            frm_venta.ShowDialog();
        }

        private void btn_Mesa15_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Mesa 15");
            Form frm_venta = new Form_Venta("Mesa 15");
            frm_venta.ShowDialog();
        }

        private void btn_Barra1_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Barra 1");
            Form frm_venta = new Form_Venta("Barra 1");
            frm_venta.ShowDialog();
        }

        private void btn_Barra2_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Barra 2");
            Form frm_venta = new Form_Venta("Barra 2");
            frm_venta.ShowDialog();
        }

        private void btn_Barra3_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Barra 3");
            Form frm_venta = new Form_Venta("Barra 3");
            frm_venta.ShowDialog();
        }

        private void btn_Barra4_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Barra 4");
            Form frm_venta = new Form_Venta("Barra 4");
            frm_venta.ShowDialog();
        }

        private void btn_Barra5_Click(object sender, EventArgs e)
        {
            CambiarColorBoton((Button)sender, true);
            MarcarPuestoComoOcupado("Barra 5");
            Form frm_venta = new Form_Venta("Barra 5");
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

        //private void btn_Ticket_Click(object sender, EventArgs e)
        //{
        //    //Form frm_ticket = new Form_Ticket();
        //    //frm_ticket.ShowDialog();
        //    MessageBox.Show("hacer Logout aca");
        //}

        private void btn_AgregarMercaderia_Click(object sender, EventArgs e)
        {
            Form frm = new Form_Agregar();
            frm.Show();
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
            MessageBox.Show($" Facturacion de hoy $ {Bar.CalcularFacturacionDelDia().ToString()}");
        }

        private void PlaySound()
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

        private void CambiarColorBoton(System.Windows.Forms.Button unBoton, bool ocupacion)
        {
            if(ocupacion == true)
            {
            unBoton.BackColor = Color.Red;

            }
            else
            {
            unBoton.BackColor = Color.Green;

            }
        }

        private void MarcarPuestoComoOcupado(string cualMesa)
        {
            foreach (PuestoDeVenta item in Bar.ListaDePuestosDeVenta)
            {
                if (item.Nombre == cualMesa)
                {
                    item.estaLibre = false;
                }
            }
        }
        private void ColocarMesasEnVerde()
        {
            this.btn_Barra1.BackColor = Color.LimeGreen;
            this.btn_Barra2.BackColor = Color.LimeGreen;
            this.btn_Barra3.BackColor = Color.LimeGreen;
            this.btn_Barra4.BackColor = Color.LimeGreen;
            this.btn_Barra5.BackColor = Color.LimeGreen;
            this.btn_Mesa1.BackColor = Color.LimeGreen;
            this.btn_Mesa2.BackColor = Color.LimeGreen;
            this.btn_Mesa3.BackColor = Color.LimeGreen;
            this.btn_Mesa4.BackColor = Color.LimeGreen;
            this.btn_Mesa5.BackColor = Color.LimeGreen;
            this.btn_Mesa6.BackColor = Color.LimeGreen;
            this.btn_Mesa7.BackColor = Color.LimeGreen;
            this.btn_Mesa8.BackColor = Color.LimeGreen;
            this.btn_Mesa9.BackColor = Color.LimeGreen;
            this.btn_Mesa10.BackColor = Color.LimeGreen;
            this.btn_Mesa11.BackColor = Color.LimeGreen;
            this.btn_Mesa12.BackColor = Color.LimeGreen;
            this.btn_Mesa13.BackColor = Color.LimeGreen;
            this.btn_Mesa14.BackColor = Color.LimeGreen;
            this.btn_Mesa15.BackColor = Color.LimeGreen;
        }

        private void btn_WhoAmI_Click(object sender, EventArgs e)
        {
            //Persona p = Form_Login.UsuarioLogueado;
            MessageBox.Show($"Vos sos ");
        }
    }
}
