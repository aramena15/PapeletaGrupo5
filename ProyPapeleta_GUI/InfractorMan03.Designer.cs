namespace ProyPapeleta_GUI
{
    partial class InfractorMan03
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtFiltroo = new TextBox();
            dtgInfractor = new DataGridView();
            infractorBLBindingSource = new BindingSource(components);
            btnEliminar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgInfractor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infractorBLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 53);
            label1.Name = "label1";
            label1.Size = new Size(350, 32);
            label1.TabIndex = 0;
            label1.Text = "Ingrese iniciales de descripción:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtFiltroo
            // 
            txtFiltroo.Location = new Point(442, 53);
            txtFiltroo.Name = "txtFiltroo";
            txtFiltroo.Size = new Size(569, 39);
            txtFiltroo.TabIndex = 2;
            txtFiltroo.TextChanged += txtFiltroo_TextChanged;
            // 
            // dtgInfractor
            // 
            dtgInfractor.AllowUserToAddRows = false;
            dtgInfractor.AllowUserToDeleteRows = false;
            dtgInfractor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfractor.Location = new Point(40, 114);
            dtgInfractor.Name = "dtgInfractor";
            dtgInfractor.ReadOnly = true;
            dtgInfractor.RowHeadersWidth = 82;
            dtgInfractor.Size = new Size(1304, 546);
            dtgInfractor.TabIndex = 3;
            dtgInfractor.CellContentDoubleClick += dtgInfractor_CellDoubleClick;
            // 
            // infractorBLBindingSource
            // 
            infractorBLBindingSource.DataSource = typeof(ProyPapeletaBL.InfractorBL);
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(689, 728);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1194, 774);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 46);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1067, 706);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 9;
            label3.Text = "Registros:";
            label3.Click += label3_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1188, 689);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(156, 64);
            lblRegistros.TabIndex = 10;
            lblRegistros.Click += lblRegistros_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(459, 728);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(150, 46);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // InfractorMan03
            // 
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1375, 848);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnInsertar);
            Controls.Add(btnEliminar);
            Controls.Add(dtgInfractor);
            Controls.Add(txtFiltroo);
            Controls.Add(label1);
            Name = "InfractorMan03";
            Text = "InfractorMan03";
            Load += InfractorMan03_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgInfractor).EndInit();
            ((System.ComponentModel.ISupportInitialize)infractorBLBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtFiltro;
        private DataGridView dgvInfractores;
        private TextBox txtRegistros;
        private Label label1;
        private Button btnEliminar;
        private Button btnSalir;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtFiltroo;
        private DataGridView dtgInfractor;
        private BindingSource infractorBLBindingSource;
        private Label label3;
        private Label lblRegistros;
        private Button btnInsertar;
    }
}