namespace ProyPapeleta_GUI
{
    partial class InfraccionMan02
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
            grpDatosPolicia = new GroupBox();
            button1 = new Button();
            lblCodigo = new Label();
            label4 = new Label();
            nudPuntos = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            nudUIT = new NumericUpDown();
            btnCancelar = new Button();
            label10 = new Label();
            cboCalificacion = new ComboBox();
            txtDescripcion = new TextBox();
            label1 = new Label();
            chkActivo = new CheckBox();
            label6 = new Label();
            grpDatosPolicia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPuntos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUIT).BeginInit();
            SuspendLayout();
            // 
            // grpDatosPolicia
            // 
            grpDatosPolicia.Controls.Add(chkActivo);
            grpDatosPolicia.Controls.Add(label6);
            grpDatosPolicia.Controls.Add(button1);
            grpDatosPolicia.Controls.Add(lblCodigo);
            grpDatosPolicia.Controls.Add(label4);
            grpDatosPolicia.Controls.Add(nudPuntos);
            grpDatosPolicia.Controls.Add(label3);
            grpDatosPolicia.Controls.Add(label2);
            grpDatosPolicia.Controls.Add(nudUIT);
            grpDatosPolicia.Controls.Add(btnCancelar);
            grpDatosPolicia.Controls.Add(label10);
            grpDatosPolicia.Controls.Add(cboCalificacion);
            grpDatosPolicia.Controls.Add(txtDescripcion);
            grpDatosPolicia.Controls.Add(label1);
            grpDatosPolicia.Location = new Point(12, 11);
            grpDatosPolicia.Margin = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Name = "grpDatosPolicia";
            grpDatosPolicia.Padding = new Padding(3, 2, 3, 2);
            grpDatosPolicia.Size = new Size(535, 250);
            grpDatosPolicia.TabIndex = 4;
            grpDatosPolicia.TabStop = false;
            grpDatosPolicia.Text = "Actualizar Datos Infraccion";
            grpDatosPolicia.Enter += grpDatosPolicia_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(232, 193);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(82, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(88, 23);
            lblCodigo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 25);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Código:";
            // 
            // nudPuntos
            // 
            nudPuntos.Location = new Point(80, 141);
            nudPuntos.Name = "nudPuntos";
            nudPuntos.Size = new Size(44, 23);
            nudPuntos.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 140);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "Puntos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 188);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 7;
            label2.Text = "UIT:";
            // 
            // nudUIT
            // 
            nudUIT.Location = new Point(59, 189);
            nudUIT.Name = "nudUIT";
            nudUIT.Size = new Size(55, 23);
            nudUIT.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(322, 193);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 102);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 4;
            label10.Text = "Calificación:";
            // 
            // cboCalificacion
            // 
            cboCalificacion.FormattingEnabled = true;
            cboCalificacion.Items.AddRange(new object[] { "--Seleccione--", "General de Policía", "", "Teniente General", "", "General", "", "Coronel", "", "Comandante", "", "Mayor", "", "Capitán", "", "Teniente", "", "Alférez", "Suboficial Superior", "", "Suboficial Brigadier", "", "Suboficial Técnico de Primera", "", "Suboficial Técnico de Segunda", "", "Suboficial Técnico de Tercera", "", "Suboficial de Primera", "", "Suboficial de Segunda", "", "Suboficial de Tercera" });
            cboCalificacion.Location = new Point(105, 101);
            cboCalificacion.Margin = new Padding(3, 2, 3, 2);
            cboCalificacion.Name = "cboCalificacion";
            cboCalificacion.Size = new Size(168, 23);
            cboCalificacion.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(167, 61);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(283, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 61);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción de Sanción:";
            // 
            // chkActivo
            // 
            chkActivo.AllowDrop = true;
            chkActivo.Location = new Point(372, 102);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(110, 22);
            chkActivo.TabIndex = 14;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 104);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 13;
            label6.Text = "Estado:";
            // 
            // InfraccionMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 277);
            Controls.Add(grpDatosPolicia);
            Name = "InfraccionMan02";
            Text = "Actualizar Infraccion";
            Load += InfraccionMan02_Load;
            grpDatosPolicia.ResumeLayout(false);
            grpDatosPolicia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPuntos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUIT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosPolicia;
        private Label label4;
        private NumericUpDown nudPuntos;
        private Label label3;
        private Label label2;
        private NumericUpDown nudUIT;
        private Button btnCancelar;
        private Label label10;
        private ComboBox cboCalificacion;
        private TextBox txtDescripcion;
        private Label label1;
        private Label lblCodigo;
        private Button button1;
        private CheckBox chkActivo;
        private Label label6;
    }
}