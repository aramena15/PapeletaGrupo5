using ProyPapeletaADO;
using ProyPapeletaBE;
using ProyPapeletaBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace ProyPapeleta_GUI
{
    public partial class InfractorMan03 : Form
    {
        InfractorBE objInfractorBE = new InfractorBE();
        InfractorBL objInfractorBL = new InfractorBL();
        DataView dtv;
        public InfractorMan03()
        {
            InitializeComponent();
        }

        private void InfractorMan03_Load(object sender, EventArgs e)
        {

        }

        private void InfractorMan03_Load_1(object sender, EventArgs e)
        {

            CargarInfractores();
        }

        private void CargarInfractores()
        {
            try
            {
                InfractorADO objADO = new InfractorADO();

                DataTable dt = objADO.ListarInfractores();

                dtv = new DataView(dt);
                dtgInfractor.DataSource = dtv;

                if (dtgInfractor.Columns.Count > 0)
                {
                    dtgInfractor.AllowUserToAddRows = false;
                    dtgInfractor.AllowUserToDeleteRows = false;
                    dtgInfractor.RowHeadersVisible = false;
                    dtgInfractor.ReadOnly = true;
                    dtgInfractor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Ajusta las columnas al ancho del cuadro gris automáticamente
                    dtgInfractor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Oculta las columnas de auditoría que quitan espacio
                    if (dtgInfractor.Columns.Contains("FEC_REGISTRO")) dtgInfractor.Columns["FEC_REGISTRO"].Visible = false;
                    if (dtgInfractor.Columns.Contains("USU_REGISTRO")) dtgInfractor.Columns["USU_REGISTRO"].Visible = false;
                    if (dtgInfractor.Columns.Contains("FEC_ULT_MODIFICACION")) dtgInfractor.Columns["FEC_ULT_MODIFICACION"].Visible = false;
                    if (dtgInfractor.Columns.Contains("USU_ULT_MODIFICACION")) dtgInfractor.Columns["USU_ULT_MODIFICACION"].Visible = false;

                    dtgInfractor.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                }

                MostrarCantidadRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void RefrescarGrid()
        {
            CargarInfractores();
        }
        private void dtgInfractor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is InfractorMan01)
                {
                    f.BringToFront();
                    return;
                }
            }
            InfractorMan01 frm = new InfractorMan01();
            frm.Formulario = this;
            frm.ShowDialog();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            //InfractorMan02 frm = new InfractorMan02();
            //frm.Formulario = this;
            //frm.Show();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
        }

        private void MostrarCantidadRegistros()
        {
            lblRegistros.Text = dtgInfractor.Rows.Count.ToString();
        }

        private void lblRegistros_Click(object sender, EventArgs e)
        {
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltroo.Text = ""; // pa limpiar
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltroo_TextChanged(object sender, EventArgs e)
        {
            if (dtv != null)
            {
                dtv.RowFilter = $"COD_INFRACTOR LIKE '%{txtFiltroo.Text.Trim()}%'";
                MostrarCantidadRegistros();
            }
        }

        private void dtgInfractor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                string codigo = dtgInfractor
                    .Rows[e.RowIndex]
                    .Cells["COD_INFRACTOR"]
                    .Value
                    .ToString();

                InfractorMan02 frm = new InfractorMan02();

                frm.Codigo = codigo;

                frm.ShowDialog();

                CargarInfractores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

