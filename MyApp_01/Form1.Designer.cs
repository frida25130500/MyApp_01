namespace MyApp_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEncender = new System.Windows.Forms.Button();
            this.lblEjecucion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(639, 287);
            this.btnEncender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(84, 28);
            this.btnEncender.TabIndex = 7;
            this.btnEncender.Text = "Enceder";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // lblEjecucion
            // 
            this.lblEjecucion.AutoSize = true;
            this.lblEjecucion.Location = new System.Drawing.Point(77, 302);
            this.lblEjecucion.Name = "lblEjecucion";
            this.lblEjecucion.Size = new System.Drawing.Size(147, 16);
            this.lblEjecucion.TabIndex = 6;
            this.lblEjecucion.Text = "Tiempo en Ejecucion: 0";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(155, 210);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 69);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "0";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(155, 132);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(63, 69);
            this.lblReloj.TabIndex = 4;
            this.lblReloj.Text = "0";
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.lblEjecucion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblReloj);
            this.Name = "Form1";
            this.Text = "Mi Primer App Temporizador 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Label lblEjecucion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer tmrReloj;
    }
}

