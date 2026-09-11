namespace MyApp_01
{
    partial class frmConfigurar
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtpConfigura = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(451, 212);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 26);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpConfigura
            // 
            this.dtpConfigura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpConfigura.Location = new System.Drawing.Point(251, 212);
            this.dtpConfigura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpConfigura.Name = "dtpConfigura";
            this.dtpConfigura.ShowUpDown = true;
            this.dtpConfigura.Size = new System.Drawing.Size(173, 22);
            this.dtpConfigura.TabIndex = 2;
            this.dtpConfigura.Value = new System.DateTime(2026, 9, 8, 15, 17, 0, 0);
            this.dtpConfigura.ValueChanged += new System.EventHandler(this.dtpConfigura_ValueChanged);
            // 
            // frmConfiguarar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpConfigura);
            this.Name = "frmConfiguarar";
            this.Text = "Configurar alarma";
            this.Load += new System.EventHandler(this.frmConfiguarar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dtpConfigura;
    }
}