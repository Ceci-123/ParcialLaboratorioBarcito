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
    public partial class Form_Ticket : Form
    {
        string numeroPuesto;
        float totalPesos;
        public Form_Ticket(string numero)
        {
            InitializeComponent();
            this.numeroPuesto = numero; 
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            PlaySound();
            totalPesos = Bar.SumarConsumicion(numeroPuesto);
            if (this.radioBtn_TarjetaCredito.Checked)
            {
              totalPesos = Bar.CalcularTarjeta(totalPesos); 
            }
            if (this.radioBtn_estacionamiento.Checked)
            {
              totalPesos = Bar.CalcularEstacionamiento(totalPesos);
            }
            if (this.chk_descuento.Checked)
            {
                totalPesos = Bar.Descuentos(totalPesos, 1);  
            }
            Bar.TotalVentaDelDia+= totalPesos; 
            this.lbl_TotalPesos.Text = totalPesos.ToString();
        }

        private void PlaySound()
        {
            try
            {
                
                SoundPlayer sonido = new SoundPlayer(Properties.Resources.sonido_largo);
                sonido.Play();
            }
            catch (Exception)
            {
                Console.Beep();
            }



        }

        private void Form_Ticket_Load(object sender, EventArgs e)
        {
            this.lbl_fecha.Text = DateTime.Now.ToString();
            this.lbl_puestoVenta.Text = this.numeroPuesto;
            this.text_Box.Text = Bar.MostrarConsumiciones(numeroPuesto);
        }

        private void btn_imprimirTicket_Click(object sender, EventArgs e)
        {
            PlaySound();
            if(Bar.ImprimirTicket(totalPesos, this.radioBtn_TarjetaCredito.Checked,
                this.radioBtn_estacionamiento.Checked, this.chk_descuento.Checked))
            {
                MessageBox.Show("Ticket impreso");
            }
            else
            {
                MessageBox.Show("Error al imprimir ticket");
            }
            
        }
    }
}
