namespace Actividad_3
{
    partial class datoscont
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.nmPeso = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // nmID
            // 
            this.nmID.Location = new System.Drawing.Point(76, 35);
            this.nmID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmID.Name = "nmID";
            this.nmID.Size = new System.Drawing.Size(181, 20);
            this.nmID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pais Origen";
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "China",
            "Uruguay",
            "Brasil",
            "Alemania",
            "Argentina"});
            this.cbPais.Location = new System.Drawing.Point(75, 65);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(182, 21);
            this.cbPais.TabIndex = 3;
            // 
            // nmPeso
            // 
            this.nmPeso.Location = new System.Drawing.Point(76, 101);
            this.nmPeso.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmPeso.Name = "nmPeso";
            this.nmPeso.Size = new System.Drawing.Size(181, 20);
            this.nmPeso.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(76, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 36);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // datoscont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 186);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmPeso);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmID);
            this.Controls.Add(this.label1);
            this.Name = "datoscont";
            this.Text = "Datos del Contenedor";
            ((System.ComponentModel.ISupportInitialize)(this.nmID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.NumericUpDown nmID;
        public System.Windows.Forms.ComboBox cbPais;
        public System.Windows.Forms.NumericUpDown nmPeso;
    }
}