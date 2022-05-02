namespace UI
{
    partial class Form_Para_Mostrar_Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Para_Mostrar_Resultados));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.rich_box_resultados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(115, 21);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(0, 27);
            this.lbl_titulo.TabIndex = 0;
            // 
            // rich_box_resultados
            // 
            this.rich_box_resultados.BackColor = System.Drawing.Color.MediumOrchid;
            this.rich_box_resultados.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rich_box_resultados.Location = new System.Drawing.Point(47, 73);
            this.rich_box_resultados.Name = "rich_box_resultados";
            this.rich_box_resultados.Size = new System.Drawing.Size(459, 276);
            this.rich_box_resultados.TabIndex = 1;
            this.rich_box_resultados.Text = "";
            // 
            // Form_Para_Mostrar_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(560, 383);
            this.Controls.Add(this.rich_box_resultados);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Para_Mostrar_Resultados";
            this.Text = "Resultado de la Consulta";
            this.Load += new System.EventHandler(this.Form_Para_Mostrar_Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.RichTextBox rich_box_resultados;
    }
}