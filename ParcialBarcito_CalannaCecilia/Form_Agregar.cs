using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class Form_Agregar : Form
    {
        public Form_Agregar()
        {
            InitializeComponent();
        }
      
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.txtBx_nombre.Text) && String.IsNullOrEmpty(this.txtBx_precio.Text))
            {
                Bar.AgregarMercaderia(new Entidades.Producto(
                this.txtBx_nombre.Text,
                this.chk_bebida.Checked,
                float.Parse(this.txtBx_precio.Text),
                this.chk_vegano.Checked, this.chk_celiacos.Checked),
                short.Parse(this.num_cantidad.ToString()));
            }
            else
            {
                MessageBox.Show("Debe completar los campos");
            }    
            
        } 
    }
}
