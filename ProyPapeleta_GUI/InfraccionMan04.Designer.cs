namespace ProyPapeleta_GUI
{
    partial class InfraccionMan04
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
            dtgInfraccion = new DataGridView();
            label1 = new Label();
            txtFiltro = new TextBox();
            btnRefrescar = new Button();
            btnInsertar = new Button();
            btnEliminar = new Button();
            label3 = new Label();
            lblRegistros = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgInfraccion).BeginInit();
            SuspendLayout();
            // 
            // dtgInfraccion
            // 
            dtgInfraccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfraccion.Location = new Point(65, 78);
            dtgInfraccion.Name = "dtgInfraccion";
            dtgInfraccion.Size = new Size(656, 252);
            dtgInfraccion.TabIndex = 0;
            dtgInfraccion.CellContentClick += dtgInfraccion_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 32);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 7;
            label1.Text = "Ingrese codigo de infraccion";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(240, 29);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(415, 23);
            txtFiltro.TabIndex = 8;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(65, 353);
            btnRefrescar.Margin = new Padding(3, 2, 3, 2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(104, 34);
            btnRefrescar.TabIndex = 31;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(240, 440);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(123, 34);
            btnInsertar.TabIndex = 32;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(369, 440);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 34);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 353);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 35;
            label3.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(614, 343);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(107, 35);
            lblRegistros.TabIndex = 36;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(639, 440);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 34);
            btnSalir.TabIndex = 37;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // InfraccionMan05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 540);
            Controls.Add(btnSalir);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(btnRefrescar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgInfraccion);
            Name = "InfraccionMan05";
            Text = "Actualizar Infracción";
            Load += InfraccionMan05_Load;
            ((System.ComponentModel.ISupportInitialize)dtgInfraccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgInfraccion;
        private Label label1;
        private TextBox txtFiltro;
        private Button btnRefrescar;
        private Button btnInsertar;
        private Button btnEliminar;
        private Label label3;
        private Label lblRegistros;
        private Button btnSalir;
    }
}
