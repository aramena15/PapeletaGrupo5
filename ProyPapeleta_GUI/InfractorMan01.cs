using ProyPapeletaADO;
using ProyPapeletaBE;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class InfractorMan01 : Form
    {
        public InfractorMan03 Formulario;

        ErrorProvider errorProvider1 = new ErrorProvider();

        public InfractorMan01()
        {
            InitializeComponent();

            Load += InfractorMan01_Load;

            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;

            txtNombres.Validating += txtNombres_Validating;
            txtApePaterno.Validating += txtApePaterno_Validating;
            txtApeMaterno.Validating += txtApeMaterno_Validating;
            txtDNI.Validating += txtDNI_Validating;
            txtCorreo.Validating += txtCorreo_Validating;
            txtDireccion.Validating += txtDireccion_Validating;
            txtNumBrevete.Validating += txtNumBrevete_Validating;

            txtDNI.KeyPress += txtDNI_KeyPress;
            txtNumBrevete.KeyPress += txtNumBrevete_KeyPress;
            txtNombres.KeyPress += txtNombres_KeyPress;
            txtApePaterno.KeyPress += txtApePaterno_KeyPress;
            txtApeMaterno.KeyPress += txtApeMaterno_KeyPress;

            txtDNI.MaxLength = 8;
        }

        private void InfractorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objInfractorADO = new InfractorADO();

                cboDepartamento.DataSource =
                    objInfractorADO.ListarDepartamentos();

                cboDepartamento.DisplayMember = "DEPARTAMENTO";

                cboTipoBrevete.DataSource =
                    objInfractorADO.ListarTiposBrevete();

                cboTipoBrevete.DisplayMember = "TIPO_BREVETE";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objInfractorADO = new InfractorADO();

                cboProvincia.DataSource =
                    objInfractorADO.ListarProvincias(cboDepartamento.Text);

                cboProvincia.DisplayMember = "PROVINCIA";
            }
            catch
            {

            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objInfractorADO = new InfractorADO();

                cboDistrito.DataSource =
                    objInfractorADO.ListarDistritos(cboProvincia.Text);

                cboDistrito.DisplayMember = "DISTRITO";
                cboDistrito.ValueMember = "COD_UBIGEO";
            }
            catch
            {

            }
        }

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombres.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombres,
                    "Ingrese nombres");


            }
            else
            {
                errorProvider1.SetError(txtNombres, "");
            }
        }

        private void txtApePaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApePaterno.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApePaterno,
                    "Ingrese apellido paterno");

            }
            else
            {
                errorProvider1.SetError(txtApePaterno, "");
            }
        }

        private void txtApeMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApeMaterno.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApeMaterno,
                    "Ingrese apellido materno");

            }
            else
            {
                errorProvider1.SetError(txtApeMaterno, "");
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten números");

                e.Handled = true;
            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            if (txtDNI.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDNI,
                    "Ingrese DNI");

            }
            else if (txtDNI.Text.Length != 8)
            {
                errorProvider1.SetError(txtDNI,
                    "El DNI debe tener 8 dígitos");

            }
            else
            {
                errorProvider1.SetError(txtDNI, "");
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCorreo,
                    "Ingrese correo");

            }
            else if (!txtCorreo.Text.Contains("@") ||
                     !txtCorreo.Text.Contains("."))
            {
                errorProvider1.SetError(txtCorreo,
                    "Correo inválido");

            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDireccion,
                    "Ingrese dirección");

            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
        }

        private void txtNumBrevete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten números");

                e.Handled = true;
            }
        }

        private void txtNumBrevete_Validating(object sender, CancelEventArgs e)
        {
            if (txtNumBrevete.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNumBrevete,
                    "Ingrese su Brevete");

            }
            else if (txtNumBrevete.Text.Length != 8)
            {
                errorProvider1.SetError(txtNumBrevete,
                    "El Brevete debe tener 8 dígitos");

            }
            else
            {
                errorProvider1.SetError(txtNumBrevete, "");
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten letras");

                e.Handled = true;
            }
        }

        private void txtApePaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten letras");

                e.Handled = true;
            }
        }

        private void txtApeMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten letras");

                e.Handled = true;
            }
        }

        private bool ValidarCampos()
        {
            return this.ValidateChildren();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                if (pcbFoto.Image == null)
                {
                    MessageBox.Show("Debe subir una foto");
                    btnFoto.Focus();
                    return;
                }

                InfractorBE objInfractorBE =
                    new InfractorBE();

                objInfractorBE.NOMBRES =
                    txtNombres.Text;

                objInfractorBE.APE_PATERNO =
                    txtApePaterno.Text;

                objInfractorBE.APE_MATERNO =
                    txtApeMaterno.Text;

                objInfractorBE.DNI =
                    txtDNI.Text;

                objInfractorBE.CORREO =
                    txtCorreo.Text;

                objInfractorBE.DIRECCION =
                    txtDireccion.Text;

                objInfractorBE.COD_UBIGEO =
                    cboDistrito.SelectedValue.ToString();

                if (optMasculino.Checked)
                {
                    objInfractorBE.SEXO = "M";
                }
                else
                {
                    objInfractorBE.SEXO = "F";
                }

                objInfractorBE.FEC_NACIMIENTO =
                    dtpFecNacimiento.Value;

                objInfractorBE.NRO_BREVETE =
                    txtNumBrevete.Text;

                objInfractorBE.TIPO_BREVETE =
                    cboTipoBrevete.Text;

                objInfractorBE.USU_REGISTRO =
                    "ADMIN";

                MemoryStream ms =
                    new MemoryStream();

                pcbFoto.Image.Save(
                    ms,
                    System.Drawing.Imaging.ImageFormat.Jpeg);

                objInfractorBE.FOTO =
                    ms.ToArray();

                InfractorADO objInfractorADO =
                    new InfractorADO();

                if (objInfractorADO.InsertarInfractor(objInfractorBE))
                {
                    MessageBox.Show(
                        "Infractor registrado correctamente");

                    if (Formulario != null)
                    {
                        Formulario.RefrescarGrid();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd =
                new OpenFileDialog();

            ofd.Filter =
                "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbFoto.Image =
                    Image.FromFile(ofd.FileName);

                pcbFoto.SizeMode =
                    PictureBoxSizeMode.StretchImage;
            }
        }
    }
}