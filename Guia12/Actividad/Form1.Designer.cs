namespace Actividad
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTiempos = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(229, 52);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AgregarCompetidor";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnTiempos
            // 
            this.btnTiempos.Location = new System.Drawing.Point(21, 71);
            this.btnTiempos.Name = "btnTiempos";
            this.btnTiempos.Size = new System.Drawing.Size(229, 56);
            this.btnTiempos.TabIndex = 1;
            this.btnTiempos.Text = "Cargar Tiempos de Competidores";
            this.btnTiempos.UseVisualStyleBackColor = true;
            this.btnTiempos.Click += new System.EventHandler(this.btnTiempos_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(21, 133);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(227, 59);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver Resultados";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 213);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnTiempos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnTiempos;
        private System.Windows.Forms.Button btnVer;
    }
}

