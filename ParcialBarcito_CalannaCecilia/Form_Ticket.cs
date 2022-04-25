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

namespace UI
{
    public partial class Form_Ticket : Form
    {
        public Form_Ticket()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            PlaySound();
            //hacer la suma de la consumision, 
            this.lbl_TotalPesos.Text = "aca va el total";
            //Entidades.Bar.SumarConsumicion();
            if (this.radioBtn_TarjetaCredito.Checked)
            {
               // Entidades.Bar.CalcularTarjeta(); 
            }
            if (this.radioBtn_estacionamiento.Checked)
            {
                //AgregarEstacionamiento(Sitio unSitio)
            }
           // Entidades.Bar.totalVentaDelDia+= lock de este licket; 
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
           // this.text_Box.Text = Entidades.Bar.MostrarConsumiciones(mesa1);
        }
    }
}
