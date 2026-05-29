namespace ProyPapeleta_GUI
{
    partial class InfractorMan01
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
            components = new System.ComponentModel.Container();
            grpInfractor = new GroupBox();
            btnFoto = new Button();
            button2 = new Button();
            btnAgregar = new Button();
            grpFoto = new GroupBox();
            pcbFoto = new PictureBox();
            cboTipoBrevete = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            txtCorreo = new TextBox();
            label9 = new Label();
            grpSexo = new GroupBox();
            optMasculino = new RadioButton();
            optFemenino = new RadioButton();
            dtpFecNacimiento = new DateTimePicker();
            txtNumBrevete = new TextBox();
            txtDireccion = new TextBox();
            txtApePaterno = new TextBox();
            txtApeMaterno = new TextBox();
            txtDNI = new TextBox();
            txtNombres = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grpInfractor.SuspendLayout();
            grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            grpSexo.SuspendLayout();
            SuspendLayout();
            // 
            // grpInfractor
            // 
            grpInfractor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpInfractor.Controls.Add(btnFoto);
            grpInfractor.Controls.Add(button2);
            grpInfractor.Controls.Add(btnAgregar);
            grpInfractor.Controls.Add(grpFoto);
            grpInfractor.Controls.Add(cboTipoBrevete);
            grpInfractor.Controls.Add(label12);
            grpInfractor.Controls.Add(label11);
            grpInfractor.Controls.Add(label10);
            grpInfractor.Controls.Add(cboDistrito);
            grpInfractor.Controls.Add(cboProvincia);
            grpInfractor.Controls.Add(cboDepartamento);
            grpInfractor.Controls.Add(txtCorreo);
            grpInfractor.Controls.Add(label9);
            grpInfractor.Controls.Add(grpSexo);
            grpInfractor.Controls.Add(dtpFecNacimiento);
            grpInfractor.Controls.Add(txtNumBrevete);
            grpInfractor.Controls.Add(txtDireccion);
            grpInfractor.Controls.Add(txtApePaterno);
            grpInfractor.Controls.Add(txtApeMaterno);
            grpInfractor.Controls.Add(txtDNI);
            grpInfractor.Controls.Add(txtNombres);
            grpInfractor.Controls.Add(label8);
            grpInfractor.Controls.Add(label7);
            grpInfractor.Controls.Add(label6);
            grpInfractor.Controls.Add(label5);
            grpInfractor.Controls.Add(label4);
            grpInfractor.Controls.Add(label3);
            grpInfractor.Controls.Add(label2);
            grpInfractor.Controls.Add(label1);
            grpInfractor.Location = new Point(30, 13);
            grpInfractor.Margin = new Padding(4, 2, 4, 2);
            grpInfractor.Name = "grpInfractor";
            grpInfractor.Padding = new Padding(4, 2, 4, 2);
            grpInfractor.Size = new Size(1476, 956);
            grpInfractor.TabIndex = 0;
            grpInfractor.TabStop = false;
            grpInfractor.Text = "Insertar Infractor";
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(1139, 789);
            btnFoto.Margin = new Padding(4, 2, 4, 2);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(150, 70);
            btnFoto.TabIndex = 13;
            btnFoto.Text = "Subir Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // button2
            // 
            button2.Location = new Point(816, 886);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(150, 47);
            button2.TabIndex = 27;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(605, 886);
            btnAgregar.Margin = new Padding(4, 2, 4, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 47);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grpFoto
            // 
            grpFoto.Controls.Add(pcbFoto);
            grpFoto.Location = new Point(999, 506);
            grpFoto.Margin = new Padding(4, 2, 4, 2);
            grpFoto.Name = "grpFoto";
            grpFoto.Padding = new Padding(4, 2, 4, 2);
            grpFoto.Size = new Size(346, 279);
            grpFoto.TabIndex = 13;
            grpFoto.TabStop = false;
            grpFoto.Text = "Foto";
            // 
            // pcbFoto
            // 
            pcbFoto.Location = new Point(103, 34);
            pcbFoto.Margin = new Padding(4, 2, 4, 2);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(201, 241);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 0;
            pcbFoto.TabStop = false;
            // 
            // cboTipoBrevete
            // 
            cboTipoBrevete.FormattingEnabled = true;
            cboTipoBrevete.Location = new Point(1070, 443);
            cboTipoBrevete.Margin = new Padding(4, 2, 4, 2);
            cboTipoBrevete.Name = "cboTipoBrevete";
            cboTipoBrevete.Size = new Size(338, 40);
            cboTipoBrevete.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(66, 727);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(96, 32);
            label12.TabIndex = 23;
            label12.Text = "Distrito:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(66, 608);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(115, 32);
            label11.TabIndex = 22;
            label11.Text = "Provincia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 525);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(173, 32);
            label10.TabIndex = 21;
            label10.Text = "Departamento:";
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(288, 727);
            cboDistrito.Margin = new Padding(4, 2, 4, 2);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(366, 40);
            cboDistrito.TabIndex = 10;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(288, 620);
            cboProvincia.Margin = new Padding(4, 2, 4, 2);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(366, 40);
            cboProvincia.TabIndex = 9;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(288, 525);
            cboDepartamento.Margin = new Padding(4, 2, 4, 2);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(366, 40);
            cboDepartamento.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(228, 324);
            txtCorreo.Margin = new Padding(4, 2, 4, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(426, 39);
            txtCorreo.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 310);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 32);
            label9.TabIndex = 16;
            label9.Text = "Correo:";
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(optMasculino);
            grpSexo.Controls.Add(optFemenino);
            grpSexo.Location = new Point(842, 223);
            grpSexo.Margin = new Padding(4, 2, 4, 2);
            grpSexo.Name = "grpSexo";
            grpSexo.Padding = new Padding(4, 2, 4, 2);
            grpSexo.Size = new Size(566, 102);
            grpSexo.TabIndex = 5;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo:";
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(355, 47);
            optMasculino.Margin = new Padding(4, 2, 4, 2);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(154, 36);
            optMasculino.TabIndex = 1;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(100, 47);
            optFemenino.Margin = new Padding(4, 2, 4, 2);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(152, 36);
            optFemenino.TabIndex = 0;
            optFemenino.TabStop = true;
            optFemenino.Text = "Femenino";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // dtpFecNacimiento
            // 
            dtpFecNacimiento.Location = new Point(336, 223);
            dtpFecNacimiento.Margin = new Padding(4, 2, 4, 2);
            dtpFecNacimiento.Name = "dtpFecNacimiento";
            dtpFecNacimiento.Size = new Size(470, 39);
            dtpFecNacimiento.TabIndex = 4;
            // 
            // txtNumBrevete
            // 
            txtNumBrevete.Location = new Point(1070, 362);
            txtNumBrevete.Margin = new Padding(4, 2, 4, 2);
            txtNumBrevete.Name = "txtNumBrevete";
            txtNumBrevete.Size = new Size(338, 39);
            txtNumBrevete.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(228, 425);
            txtDireccion.Margin = new Padding(4, 2, 4, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(426, 39);
            txtDireccion.TabIndex = 7;
            // 
            // txtApePaterno
            // 
            txtApePaterno.CharacterCasing = CharacterCasing.Upper;
            txtApePaterno.Location = new Point(1073, 61);
            txtApePaterno.Margin = new Padding(4, 2, 4, 2);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(335, 39);
            txtApePaterno.TabIndex = 1;
            // 
            // txtApeMaterno
            // 
            txtApeMaterno.CharacterCasing = CharacterCasing.Upper;
            txtApeMaterno.Location = new Point(319, 138);
            txtApeMaterno.Margin = new Padding(4, 2, 4, 2);
            txtApeMaterno.Name = "txtApeMaterno";
            txtApeMaterno.Size = new Size(335, 39);
            txtApeMaterno.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(1073, 145);
            txtDNI.Margin = new Padding(4, 2, 4, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(335, 39);
            txtDNI.TabIndex = 3;
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Location = new Point(269, 54);
            txtNombres.Margin = new Padding(4, 2, 4, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(385, 39);
            txtNombres.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(800, 451);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(154, 32);
            label8.TabIndex = 7;
            label8.Text = "Tipo Brevete:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(800, 369);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(195, 32);
            label7.TabIndex = 6;
            label7.Text = "Número Brevete:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 411);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 32);
            label6.TabIndex = 5;
            label6.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(800, 145);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 32);
            label5.TabIndex = 4;
            label5.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(800, 61);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 32);
            label4.TabIndex = 3;
            label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 32);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 223);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 0;
            label1.Text = "Fecha de Nacimiento:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // InfractorMan01
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 964);
            Controls.Add(grpInfractor);
            Margin = new Padding(4, 2, 4, 2);
            Name = "InfractorMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Infractor";
            grpInfractor.ResumeLayout(false);
            grpInfractor.PerformLayout();
            grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInfractor;
        private DateTimePicker dtpFecNacimiento;
        private TextBox txtNumBrevete;
        private TextBox txtDireccion;
        private TextBox txtApePaterno;
        private TextBox txtApeMaterno;
        private TextBox txtDNI;
        private TextBox txtNombres;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox grpSexo;
        private Button button2;
        private Button btnAgregar;
        private GroupBox grpFoto;
        private Button btnFoto;
        private PictureBox pcbFoto;
        private ComboBox cboTipoBrevete;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private TextBox txtCorreo;
        private Label label9;
        private RadioButton optMasculino;
        private RadioButton optFemenino;
    }
}