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
    public partial class Form_Para_Mostrar_Resultados : Form
    {
        public int opcion; 
        public Form_Para_Mostrar_Resultados(int opcion)
        {
            InitializeComponent();
            this.opcion = opcion;   
        }

        private void Form_Para_Mostrar_Resultados_Load(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 1:
                    this.lbl_titulo.Text = "Busqueda de lugares libres en el bar";
                    this.rich_box_resultados.Text = Bar.BuscarSitioLibre();
                    break;
                case 2:
                    this.lbl_titulo.Text = "Listado de empleados del bar";
                    this.rich_box_resultados.Text = Bar.MostrarPersonal();
                    break;
                case 3:
                    this.lbl_titulo.Text = "Inventario de productos en stock";
                    this.rich_box_resultados.Text = Bar.MostrarInventario();
                    break;
                default:
                    break;
            }
        }
    }
}
