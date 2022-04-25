namespace ParcialBarcito_CalannaCecilia
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.lbl_Bienvenida = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txtBox_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_Olvido = new System.Windows.Forms.Button();
            this.btn_Ingreso = new System.Windows.Forms.Button();
            this.btn_Autocompleta_Vendedor = new System.Windows.Forms.Button();
            this.btn_Autocompleta_Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Bienvenida
            // 
            this.lbl_Bienvenida.AutoSize = true;
            this.lbl_Bienvenida.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bienvenida.Location = new System.Drawing.Point(155, 35);
            this.lbl_Bienvenida.Name = "lbl_Bienvenida";
            this.lbl_Bienvenida.Size = new System.Drawing.Size(197, 31);
            this.lbl_Bienvenida.TabIndex = 0;
            this.lbl_Bienvenida.Text = "Bienvenid@ !!";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.Location = new System.Drawing.Point(23, 91);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(249, 19);
            this.lbl_Usuario.TabIndex = 7;
            this.lbl_Usuario.Text = "Ingresa tu nombre de usuario";
            // 
            // txtBox_Nombre
            // 
            this.txtBox_Nombre.Location = new System.Drawing.Point(23, 130);
            this.txtBox_Nombre.Name = "txtBox_Nombre";
            this.txtBox_Nombre.Size = new System.Drawing.Size(498, 23);
            this.txtBox_Nombre.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Password.Location = new System.Drawing.Point(23, 196);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(186, 19);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Ingresa tu contraseña";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(23, 241);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(498, 23);
            this.txtbox_password.TabIndex = 2;
            // 
            // btn_Olvido
            // 
            this.btn_Olvido.Location = new System.Drawing.Point(12, 297);
            this.btn_Olvido.Name = "btn_Olvido";
            this.btn_Olvido.Size = new System.Drawing.Size(157, 88);
            this.btn_Olvido.TabIndex = 3;
            this.btn_Olvido.Text = "Ups! Olvide mi contraseña";
            this.btn_Olvido.UseVisualStyleBackColor = true;
            this.btn_Olvido.Click += new System.EventHandler(this.btn_Olvido_Click);
            // 
            // btn_Ingreso
            // 
            this.btn_Ingreso.Location = new System.Drawing.Point(186, 297);
            this.btn_Ingreso.Name = "btn_Ingreso";
            this.btn_Ingreso.Size = new System.Drawing.Size(157, 88);
            this.btn_Ingreso.TabIndex = 4;
            this.btn_Ingreso.Text = "Entrar";
            this.btn_Ingreso.UseVisualStyleBackColor = true;
            this.btn_Ingreso.Click += new System.EventHandler(this.btn_Ingreso_Click);
            // 
            // btn_Autocompleta_Vendedor
            // 
            this.btn_Autocompleta_Vendedor.Location = new System.Drawing.Point(364, 297);
            this.btn_Autocompleta_Vendedor.Name = "btn_Autocompleta_Vendedor";
            this.btn_Autocompleta_Vendedor.Size = new System.Drawing.Size(157, 42);
            this.btn_Autocompleta_Vendedor.TabIndex = 5;
            this.btn_Autocompleta_Vendedor.Text = "Completar como vendedor";
            this.btn_Autocompleta_Vendedor.UseVisualStyleBackColor = true;
            this.btn_Autocompleta_Vendedor.Click += new System.EventHandler(this.btn_Autocompleta_Vendedor_Click);
            // 
            // btn_Autocompleta_Admin
            // 
            this.btn_Autocompleta_Admin.Location = new System.Drawing.Point(364, 345);
            this.btn_Autocompleta_Admin.Name = "btn_Autocompleta_Admin";
            this.btn_Autocompleta_Admin.Size = new System.Drawing.Size(157, 42);
            this.btn_Autocompleta_Admin.TabIndex = 6;
            this.btn_Autocompleta_Admin.Text = "Completar como admin";
            this.btn_Autocompleta_Admin.UseVisualStyleBackColor = true;
            this.btn_Autocompleta_Admin.Click += new System.EventHandler(this.btn_Autocompleta_Admin_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(533, 407);
            this.Controls.Add(this.btn_Autocompleta_Admin);
            this.Controls.Add(this.btn_Autocompleta_Vendedor);
            this.Controls.Add(this.btn_Ingreso);
            this.Controls.Add(this.btn_Olvido);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtBox_Nombre);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Bienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "✿ ❀ Bienvenid@ al Bar✿ ❀";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Login_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bienvenida;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txtBox_Nombre;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Button btn_Olvido;
        private System.Windows.Forms.Button btn_Ingreso;
        private System.Windows.Forms.Button btn_Autocompleta_Vendedor;
        private System.Windows.Forms.Button btn_Autocompleta_Admin;
    }
}
