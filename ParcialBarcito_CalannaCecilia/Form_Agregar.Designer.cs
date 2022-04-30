namespace UI
{
    partial class Form_Agregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agregar));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Bebida = new System.Windows.Forms.Label();
            this.lbl_Vegan = new System.Windows.Forms.Label();
            this.lbl_celiaquia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBx_nombre = new System.Windows.Forms.TextBox();
            this.chk_bebida = new System.Windows.Forms.CheckBox();
            this.chk_vegano = new System.Windows.Forms.CheckBox();
            this.chk_celiacos = new System.Windows.Forms.CheckBox();
            this.txtBx_precio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(25, 29);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(122, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre del Producto";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(25, 63);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(40, 15);
            this.lbl_Precio.TabIndex = 1;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Bebida
            // 
            this.lbl_Bebida.AutoSize = true;
            this.lbl_Bebida.Location = new System.Drawing.Point(25, 94);
            this.lbl_Bebida.Name = "lbl_Bebida";
            this.lbl_Bebida.Size = new System.Drawing.Size(62, 15);
            this.lbl_Bebida.TabIndex = 2;
            this.lbl_Bebida.Text = "Es bebida?";
            // 
            // lbl_Vegan
            // 
            this.lbl_Vegan.AutoSize = true;
            this.lbl_Vegan.Location = new System.Drawing.Point(25, 130);
            this.lbl_Vegan.Name = "lbl_Vegan";
            this.lbl_Vegan.Size = new System.Drawing.Size(65, 15);
            this.lbl_Vegan.TabIndex = 3;
            this.lbl_Vegan.Text = "Es vegano?";
            // 
            // lbl_celiaquia
            // 
            this.lbl_celiaquia.AutoSize = true;
            this.lbl_celiaquia.Location = new System.Drawing.Point(25, 157);
            this.lbl_celiaquia.Name = "lbl_celiaquia";
            this.lbl_celiaquia.Size = new System.Drawing.Size(95, 15);
            this.lbl_celiaquia.TabIndex = 4;
            this.lbl_celiaquia.Text = "Es apto celiacos?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBx_nombre
            // 
            this.txtBx_nombre.Location = new System.Drawing.Point(154, 29);
            this.txtBx_nombre.Name = "txtBx_nombre";
            this.txtBx_nombre.Size = new System.Drawing.Size(253, 23);
            this.txtBx_nombre.TabIndex = 6;
            // 
            // chk_bebida
            // 
            this.chk_bebida.AutoSize = true;
            this.chk_bebida.Location = new System.Drawing.Point(157, 90);
            this.chk_bebida.Name = "chk_bebida";
            this.chk_bebida.Size = new System.Drawing.Size(81, 19);
            this.chk_bebida.TabIndex = 7;
            this.chk_bebida.Text = "Es bebida?";
            this.chk_bebida.UseVisualStyleBackColor = true;
            // 
            // chk_vegano
            // 
            this.chk_vegano.AutoSize = true;
            this.chk_vegano.Location = new System.Drawing.Point(155, 116);
            this.chk_vegano.Name = "chk_vegano";
            this.chk_vegano.Size = new System.Drawing.Size(84, 19);
            this.chk_vegano.TabIndex = 8;
            this.chk_vegano.Text = "Es vegano?";
            this.chk_vegano.UseVisualStyleBackColor = true;
            // 
            // chk_celiacos
            // 
            this.chk_celiacos.AutoSize = true;
            this.chk_celiacos.Location = new System.Drawing.Point(153, 141);
            this.chk_celiacos.Name = "chk_celiacos";
            this.chk_celiacos.Size = new System.Drawing.Size(83, 19);
            this.chk_celiacos.TabIndex = 9;
            this.chk_celiacos.Text = "checkBox3";
            this.chk_celiacos.UseVisualStyleBackColor = true;
            // 
            // txtBx_precio
            // 
            this.txtBx_precio.Location = new System.Drawing.Point(156, 63);
            this.txtBx_precio.Name = "txtBx_precio";
            this.txtBx_precio.Size = new System.Drawing.Size(251, 23);
            this.txtBx_precio.TabIndex = 10;
            // 
            // Form_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBx_precio);
            this.Controls.Add(this.chk_celiacos);
            this.Controls.Add(this.chk_vegano);
            this.Controls.Add(this.chk_bebida);
            this.Controls.Add(this.txtBx_nombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_celiaquia);
            this.Controls.Add(this.lbl_Vegan);
            this.Controls.Add(this.lbl_Bebida);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Agregar";
            this.Text = "Agregar un producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Bebida;
        private System.Windows.Forms.Label lbl_Vegan;
        private System.Windows.Forms.Label lbl_celiaquia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBx_nombre;
        private System.Windows.Forms.CheckBox chk_bebida;
        private System.Windows.Forms.CheckBox chk_vegano;
        private System.Windows.Forms.CheckBox chk_celiacos;
        private System.Windows.Forms.TextBox txtBx_precio;
    }
}