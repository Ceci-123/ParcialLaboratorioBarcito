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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txtBx_nombre = new System.Windows.Forms.TextBox();
            this.chk_bebida = new System.Windows.Forms.CheckBox();
            this.chk_vegano = new System.Windows.Forms.CheckBox();
            this.chk_celiacos = new System.Windows.Forms.CheckBox();
            this.txtBx_precio = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(39, 44);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(182, 19);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre del Producto";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Precio.Location = new System.Drawing.Point(39, 87);
            this.lbl_Precio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(61, 19);
            this.lbl_Precio.TabIndex = 1;
            this.lbl_Precio.Text = "Precio";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Plum;
            this.btn_agregar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.Location = new System.Drawing.Point(39, 259);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(600, 98);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar producto";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txtBx_nombre
            // 
            this.txtBx_nombre.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBx_nombre.Location = new System.Drawing.Point(242, 37);
            this.txtBx_nombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBx_nombre.Name = "txtBx_nombre";
            this.txtBx_nombre.Size = new System.Drawing.Size(395, 26);
            this.txtBx_nombre.TabIndex = 6;
            // 
            // chk_bebida
            // 
            this.chk_bebida.AutoSize = true;
            this.chk_bebida.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_bebida.Location = new System.Drawing.Point(39, 203);
            this.chk_bebida.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chk_bebida.Name = "chk_bebida";
            this.chk_bebida.Size = new System.Drawing.Size(112, 23);
            this.chk_bebida.TabIndex = 7;
            this.chk_bebida.Text = "Es bebida?";
            this.chk_bebida.UseVisualStyleBackColor = true;
            // 
            // chk_vegano
            // 
            this.chk_vegano.AutoSize = true;
            this.chk_vegano.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_vegano.Location = new System.Drawing.Point(242, 203);
            this.chk_vegano.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chk_vegano.Name = "chk_vegano";
            this.chk_vegano.Size = new System.Drawing.Size(116, 23);
            this.chk_vegano.TabIndex = 8;
            this.chk_vegano.Text = "Es vegano?";
            this.chk_vegano.UseVisualStyleBackColor = true;
            // 
            // chk_celiacos
            // 
            this.chk_celiacos.AutoSize = true;
            this.chk_celiacos.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_celiacos.Location = new System.Drawing.Point(493, 203);
            this.chk_celiacos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chk_celiacos.Name = "chk_celiacos";
            this.chk_celiacos.Size = new System.Drawing.Size(144, 23);
            this.chk_celiacos.TabIndex = 9;
            this.chk_celiacos.Text = "Apto celiacos?";
            this.chk_celiacos.UseVisualStyleBackColor = true;
            // 
            // txtBx_precio
            // 
            this.txtBx_precio.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBx_precio.Location = new System.Drawing.Point(242, 80);
            this.txtBx_precio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBx_precio.Name = "txtBx_precio";
            this.txtBx_precio.Size = new System.Drawing.Size(395, 26);
            this.txtBx_precio.TabIndex = 10;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(39, 138);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(83, 19);
            this.lbl_cantidad.TabIndex = 11;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // num_cantidad
            // 
            this.num_cantidad.Location = new System.Drawing.Point(242, 131);
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.Size = new System.Drawing.Size(395, 26);
            this.num_cantidad.TabIndex = 12;
            // 
            // Form_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(684, 379);
            this.Controls.Add(this.num_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txtBx_precio);
            this.Controls.Add(this.chk_celiacos);
            this.Controls.Add(this.chk_vegano);
            this.Controls.Add(this.chk_bebida);
            this.Controls.Add(this.txtBx_nombre);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_nombre);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Agregar";
            this.Text = "Agregar un producto";
            this.Load += new System.EventHandler(this.Form_Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txtBx_nombre;
        private System.Windows.Forms.CheckBox chk_bebida;
        private System.Windows.Forms.CheckBox chk_vegano;
        private System.Windows.Forms.CheckBox chk_celiacos;
        private System.Windows.Forms.TextBox txtBx_precio;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.NumericUpDown num_cantidad;
    }
}