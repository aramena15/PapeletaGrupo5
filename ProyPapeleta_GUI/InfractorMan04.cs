using ProyPapeletaADO;
using ProyPapeletaBE;
using ProyPapeletaBL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class InfractorMan04 : Form
    {
        InfractorBL objInfractorBL = new InfractorBL();

        public InfractorMan04()
        {
            InitializeComponent();
        }

        private void Infractor05_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();

                InfractorBE objInfractorBE =
                    objInfractorBL.ConsultarInfractor(codigo);

                if (objInfractorBE == null)
                {
                    MessageBox.Show("Infractor no existe");
                    return;
                }

                lblNombres.Text = objInfractorBE.NOMBRES;
                lblApePaterno.Text = objInfractorBE.APE_PATERNO;
                lblApeMaterno.Text = objInfractorBE.APE_MATERNO;
                lblDNI.Text = objInfractorBE.DNI;
                lblSexo.Text = objInfractorBE.SEXO;
                lblDireccion.Text = objInfractorBE.DIRECCION;
                lblCorreo.Text = objInfractorBE.CORREO;
                lblTipoBrevete.Text = objInfractorBE.TIPO_BREVETE;
                lblNumBrevete.Text = objInfractorBE.NRO_BREVETE;
                lblFecNacimiento.Text = objInfractorBE.FEC_NACIMIENTO.ToShortDateString();

                DataTable ubigeo = objInfractorBL.ObtenerUbigeoPorInfractor(codigo);

                if (ubigeo.Rows.Count > 0)
                {
                    lblDepartamento.Text = ubigeo.Rows[0]["DEPARTAMENTO"].ToString();
                    lblProvincia.Text = ubigeo.Rows[0]["PROVINCIA"].ToString();
                    lblDistrito.Text = ubigeo.Rows[0]["DISTRITO"].ToString();
                }
                else
                {
                    lblDepartamento.Text = "-";
                    lblProvincia.Text = "-";
                    lblDistrito.Text = "-";
                }

                if (objInfractorBE.FOTO != null)
                {
                    MemoryStream ms = new MemoryStream(objInfractorBE.FOTO);
                    pcbFoto.Image = Image.FromStream(ms);
                }
                else
                {
                    pcbFoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfractorMan05_Load(object sender, EventArgs e)
        {

        }

        private void grpConsultarInfractor_Enter(object sender, EventArgs e)
        {

        }

        private void lblDepartamento_Click(object sender, EventArgs e)
        {

        }
    }
}