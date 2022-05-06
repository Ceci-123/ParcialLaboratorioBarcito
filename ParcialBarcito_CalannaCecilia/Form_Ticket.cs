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
    public partial class Form_Ticket : Form
    {
        string numeroPuesto;
        float totalPesos;
        public Form_Ticket(string numero)
        {
            InitializeComponent();
            this.numeroPuesto = numero; 
        }

        private void Form_Ticket_Load(object sender, EventArgs e)
        {
            this.lbl_fecha.Text = DateTime.Now.ToString();
            this.lbl_puestoVenta.Text = this.numeroPuesto;
            this.text_Box.Text = Bar.MostrarConsumiciones(numeroPuesto);
            PlaySound(1);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            if (this.chk_Estacionamiento.Checked)
            {
                Bar.CalcularEstacionamiento(numeroPuesto);
            }
            totalPesos = Bar.SumarConsumicion(numeroPuesto);
            if (this.radioBtn_TarjetaCredito.Checked)
            {
              totalPesos = Bar.CalcularTarjeta(totalPesos); 
            }
            
            if (this.chk_descuento.Checked)
            {
                totalPesos = Form_Vendedor.DevolverUsuarioLogueado.DescontarPromo(totalPesos);
            }
            if (this.chk_HappyHour.Checked)
            {

                totalPesos = Form_Vendedor.DevolverUsuarioLogueado.DescontarHappyHour(totalPesos);
            }
            Bar.TotalVentaDelDia+= totalPesos; 
            this.lbl_TotalPesos.Text = totalPesos.ToString();
        }

        private void btn_imprimirTicket_Click(object sender, EventArgs e)
        {
            PlaySound(0);
            if (Bar.ImprimirTicket(numeroPuesto, totalPesos, this.radioBtn_TarjetaCredito.Checked,
                this.chk_Estacionamiento.Checked, this.chk_descuento.Checked))
            {
                MessageBox.Show("Ticket impreso");
            }
            else
            {
                MessageBox.Show("Error al imprimir ticket");
            }

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
                //Console.Beep();
                SystemSounds.Exclamation.Play();
            }
        }
        
    }
}
