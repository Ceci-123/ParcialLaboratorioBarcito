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
        private int rangoDelUsuarioLogueado;
        public static Persona usuarioLogueado;

        public static Persona DevolverUsuarioLogueado { get {return usuarioLogueado; } }

        public int RangoDelUsuarioLogueado { get => rangoDelUsuarioLogueado; set => rangoDelUsuarioLogueado = value; }

        public Form_Vendedor(int rango, Persona quienSeLogueo)
        {
            InitializeComponent();
            this.rangoDelUsuarioLogueado = rango;
            usuarioLogueado = quienSeLogueo;
        }

        
        private void Form_Vendedor_Load(object sender, EventArgs e)
        {
            this.lbl_Saludo.Text = "Bienvenid@ " + usuarioLogueado.Nombre;
            ColocarMesasEnVerde();
            PlaySound(1);
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
            PlaySound(0);
            //MessageBox.Show(Bar.BuscarSitioLibre(), "Busqueda de sitio libre");
            Form frm = new Form_Para_Mostrar_Resultados(1);
            frm.ShowDialog();
        }

        private void btn_VerNomina_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            //MessageBox.Show(Bar.MostrarPersonal(), "Listado de empleados");
            Form frm = new Form_Para_Mostrar_Resultados(2);
            frm.ShowDialog();
        }

        private void btn_AgregarMercaderia_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            Form frm = new Form_Agregar();
            frm.Show();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            Form frm = new Form_Para_Mostrar_Resultados(3);
            frm.ShowDialog();
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
            PlaySound(0);
            MessageBox.Show($" Facturacion de hoy $ {Bar.CalcularFacturacionDelDia().ToString()}");
        }

        private void btn_WhoAmI_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            MessageBox.Show($"Vos sos {usuarioLogueado.Nombre}");
        }

        /// <summary>
        /// Reproduce sonidos
        /// </summary>
        /// <param name="duracion">Sonido a reproducir</param>
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
                //Console.Beep();
                SystemSounds.Exclamation.Play();
            }
        }
        
        /// <summary>
        /// Cambia el color de un boton de puesto de venta segun este libre o ocupado
        /// </summary>
        /// <param name="unBoton">Boton a modificar</param>
        /// <param name="ocupacion">Si el puesto esta libre o ocupado</param>
        private void CambiarColorBoton(System.Windows.Forms.Button unBoton, bool ocupacion)
        {
            if(ocupacion == true)
            {
            unBoton.BackColor = Color.Red;

            }
            else
            {
            unBoton.BackColor = Color.LimeGreen;

            }
        }

        /// <summary>
        /// Coloca un puesto de venta como ocupado
        /// </summary>
        /// <param name="cualMesa">Puesto de venta a ocupar</param>
        private void MarcarPuestoComoOcupado(string cualMesa)
        {
            foreach (PuestoDeVenta item in Bar.ListaDePuestosDeVenta)
            {
                if (item.Nombre == cualMesa)
                {
                    item.EstaLibre = false;
                }
            }
        }

        /// <summary>
        /// Coloca todas los puestos de venta como libres
        /// </summary>
        private void ColocarMesasEnVerde()
        {
            CambiarColorBoton(this.btn_Barra1, false);
            CambiarColorBoton(this.btn_Barra2, false);
            CambiarColorBoton(this.btn_Barra3, false);
            CambiarColorBoton(this.btn_Barra4, false);
            CambiarColorBoton(this.btn_Barra5, false);
            CambiarColorBoton(this.btn_Mesa1, false);
            CambiarColorBoton(this.btn_Mesa2, false);
            CambiarColorBoton(this.btn_Mesa3, false);
            CambiarColorBoton(this.btn_Mesa4, false);
            CambiarColorBoton(this.btn_Mesa5, false);
            CambiarColorBoton(this.btn_Mesa6, false);
            CambiarColorBoton(this.btn_Mesa7, false);
            CambiarColorBoton(this.btn_Mesa8, false);
            CambiarColorBoton(this.btn_Mesa9, false);
            CambiarColorBoton(this.btn_Mesa10, false);
            CambiarColorBoton(this.btn_Mesa11, false);
            CambiarColorBoton(this.btn_Mesa12, false);
            CambiarColorBoton(this.btn_Mesa13, false);
            CambiarColorBoton(this.btn_Mesa14, false);
            CambiarColorBoton(this.btn_Mesa15, false);
            
        }

    }
}
