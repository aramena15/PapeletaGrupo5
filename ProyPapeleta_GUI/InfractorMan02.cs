using ProyPapeletaADO;
using ProyPapeletaBE;
using ProyPapeletaBL;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyPapeleta_GUI
{
    public partial class InfractorMan02 : Form
    {
        public string Codigo = "";

        public InfractorMan03 Formulario;

        ErrorProvider errorProvider1 = new ErrorProvider();

        public InfractorMan02()
        {
            InitializeComponent();

            Load += InfractorMan02_Load;

            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;

            txtNombres.Validating += txtNombres_Validating;
            txtApePaterno.Validating += txtApePaterno_Validating;
            txtApeMaterno.Validating += txtApeMaterno_Validating;
            txtDNI.Validating += txtDNI_Validating;
            txtCorreo.Validating += txtCorreo_Validating;
            txtDireccion.Validating += txtDireccion_Validating;
            txtNroBrevete.Validating += txtNroBrevete_Validating;

            txtNombres.KeyPress += txtNombres_KeyPress;
            txtApePaterno.KeyPress += txtApePaterno_KeyPress;
            txtApeMaterno.KeyPress += txtApeMaterno_KeyPress;

            txtDNI.KeyPress += txtDNI_KeyPress;
            txtNroBrevete.KeyPress += txtNroBrevete_KeyPress;

            txtDNI.MaxLength = 8;
        }

        private void InfractorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objADO = new InfractorADO();

                cboTipoBrevete.DataSource =
                    objADO.ListarTiposBrevete();

                cboTipoBrevete.DisplayMember =
                    "TIPO_BREVETE";

                InfractorBE objBE =
                    objADO.ConsultarInfractor(Codigo);

                if (objBE == null)
                {
                    MessageBox.Show("No existe el infractor");
                    this.Close();
                    return;
                }

                lblCodigo.Text = objBE.COD_INFRACTOR;

                txtNombres.Text = objBE.NOMBRES;
                txtApePaterno.Text = objBE.APE_PATERNO;
                txtApeMaterno.Text = objBE.APE_MATERNO;
                txtDNI.Text = objBE.DNI;
                txtCorreo.Text = objBE.CORREO;
                txtDireccion.Text = objBE.DIRECCION;
                txtNroBrevete.Text = objBE.NRO_BREVETE;

                cboTipoBrevete.Text =
                    objBE.TIPO_BREVETE;

                dtpFecNacimiento.Value =
                    (objBE.FEC_NACIMIENTO >
                    dtpFecNacimiento.MinDate)
                    ? objBE.FEC_NACIMIENTO
                    : DateTime.Today;

                optMasculino.Checked =
                    (objBE.SEXO == "M");

                optFemenino.Checked =
                    (objBE.SEXO == "F");

                if (objBE.FOTO != null)
                {
                    MemoryStream ms =
                        new MemoryStream(objBE.FOTO);

                    pcbFoto.Image =
                        Image.FromStream(ms);
                }

                DataRow ubigeo =
                    objADO.ObtenerUbigeo(objBE.COD_UBIGEO);

                if (ubigeo != null)
                {
                    cboDepartamento.DataSource =
                        objADO.ListarDepartamentos();

                    cboDepartamento.DisplayMember =
                        "DEPARTAMENTO";

                    cboDepartamento.Text =
                        ubigeo["DEPARTAMENTO"].ToString();

                    cboProvincia.DataSource =
                        objADO.ListarProvincias(
                        ubigeo["DEPARTAMENTO"].ToString());

                    cboProvincia.DisplayMember =
                        "PROVINCIA";

                    cboProvincia.Text =
                        ubigeo["PROVINCIA"].ToString();

                    cboDistrito.DataSource =
                        objADO.ListarDistritos(
                        ubigeo["PROVINCIA"].ToString());

                    cboDistrito.DisplayMember =
                        "DISTRITO";

                    cboDistrito.ValueMember =
                        "COD_UBIGEO";

                    cboDistrito.SelectedValue =
                        objBE.COD_UBIGEO;
                }
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
                InfractorADO objInfractorADO =
                    new InfractorADO();

                cboProvincia.DataSource =
                    objInfractorADO.ListarProvincias(
                    cboDepartamento.Text);

                cboProvincia.DisplayMember =
                    "PROVINCIA";
            }
            catch
            {

            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InfractorADO objInfractorADO =
                    new InfractorADO();

                cboDistrito.DataSource =
                    objInfractorADO.ListarDistritos(
                    cboProvincia.Text);

                cboDistrito.DisplayMember =
                    "DISTRITO";

                cboDistrito.ValueMember =
                    "COD_UBIGEO";
            }
            catch
            {

            }
        }

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombres.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtNombres,
                    "Ingrese nombres");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(
                    txtNombres, "");
            }
        }

        private void txtApePaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApePaterno.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtApePaterno,
                    "Ingrese apellido paterno");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(
                    txtApePaterno, "");
            }
        }

        private void txtApeMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApeMaterno.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtApeMaterno,
                    "Ingrese apellido materno");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(
                    txtApeMaterno, "");
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtCorreo,
                    "Ingrese correo");

                e.Cancel = true;
            }
            else if (!txtCorreo.Text.Contains("@") ||
                     !txtCorreo.Text.Contains("."))
            {
                errorProvider1.SetError(
                    txtCorreo,
                    "Correo inválido");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(
                    txtCorreo, "");
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtDireccion,
                    "Ingrese dirección");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(
                    txtDireccion, "");
            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            if (txtDNI.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtDNI,
                    "Ingrese DNI");

                e.Cancel = true;
            }
            else if (txtDNI.Text.Length != 8)
            {
                errorProvider1.SetError(
                    txtDNI,
                    "El DNI debe tener 8 dígitos");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(
                    txtDNI, "");
            }
        }

        private void txtNroBrevete_Validating(object sender, CancelEventArgs e)
        {
            if (txtNroBrevete.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtNroBrevete,
                    "Ingrese número de brevete");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(
                    txtNroBrevete, "");
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

        private void txtNroBrevete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                MessageBox.Show(
                    "Solo se permiten números");

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

                InfractorBE objBE =
                    new InfractorBE();

                objBE.COD_INFRACTOR =
                    Codigo;

                objBE.NOMBRES =
                    txtNombres.Text;

                objBE.APE_PATERNO =
                    txtApePaterno.Text;

                objBE.APE_MATERNO =
                    txtApeMaterno.Text;

                objBE.DNI =
                    txtDNI.Text;

                objBE.CORREO =
                    txtCorreo.Text;

                objBE.DIRECCION =
                    txtDireccion.Text;

                objBE.COD_UBIGEO =
                    cboDistrito.SelectedValue.ToString();

                objBE.NRO_BREVETE =
                    txtNroBrevete.Text;

                objBE.TIPO_BREVETE =
                    cboTipoBrevete.Text;

                objBE.USU_ULT_MODIFICACION =
                    "ADMIN";

                objBE.FEC_NACIMIENTO =
                    dtpFecNacimiento.Value;

                objBE.SEXO =
                    optMasculino.Checked ? "M" : "F";

                if (pcbFoto.Image != null)
                {
                    MemoryStream ms =
                        new MemoryStream();

                    pcbFoto.Image.Save(
                        ms,
                        System.Drawing.Imaging.ImageFormat.Jpeg);

                    objBE.FOTO =
                        ms.ToArray();
                }

                InfractorBL bl =
                    new InfractorBL();

                if (bl.ActualizarInfractor(objBE))
                {
                    MessageBox.Show(
                        "Actualizado correctamente");

                    if (Formulario != null)
                    {
                        Formulario.RefrescarGrid();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}