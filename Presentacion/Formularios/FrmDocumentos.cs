using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmDocumentos : FrmBaseSinBordes
    {

        private Document Document;
        private Client Client;
        private Configuracion Configuracion { get; set; }
        public FrmDocumentos(Contexto contexto, Configuracion configuracion)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Configuracion = configuracion;
            this.Document = new Document(Contexto);       
        }

        private void Limpiar()
        {
            txtID.Text = "";
            txtDescripcion.Text = "";
            chkActivo.Checked = true;
            txtIDCliente.Text = "";
            txtNombreCliente.Text = "";
            lblEstadoDocumento.Text = "Documento en blanco";
            txtFecha.Text = DateTime.Now.ToString();
            Document.dataFile = null;
            Client = null;
            rbdPDF.Checked = true;
            txtID.Focus();
        }

        private void btnCargaDocumento_Click(object sender, EventArgs e)
        {
            if(Client == null)
            {
                MessageBox.Show("Primero seleccione el cliente", "Documento", MessageBox.Botones.Aceptar);               
                return;
            }
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName.Length > 0)
            {
                if (!File.Exists(openFileDialog.FileName))
                {
                    MessageBox.Show("El documento no existe", "Documento", MessageBox.Botones.Aceptar);
                    return;
                }
                if (rbdPDF.Checked)
                {
                    Document.dataFile = File.ReadAllBytes(openFileDialog.FileName);
                    lblEstadoDocumento.Text = "Documento cargado";
                }
                else if (rbdPlantilla.Checked)
                {
                    Document.dataFile = Document.ObtenerDocumentoDesdePlantilla(openFileDialog.FileName, Client.idClient);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaRapida consulta = new ConsultaRapida(Contexto);
            if (txtIDCliente.Focused)
            {
                //Por cliente
                txtIDCliente.Focus();
                int id = consulta.Consultar(ConsultaRapida.TipoConsulta.Clients);
                if (id > 0)
                {
                    txtIDCliente.Text = id.ToString(); ;
                    txtNombreCliente.Focus();
                }
            }
            else
            {
                //Por documento
                txtID.Focus();
                int id = consulta.Consultar(ConsultaRapida.TipoConsulta.Documents);
                if (id > 0)
                {
                    txtID.Text = id.ToString();
                    txtDescripcion.Focus();
                }
            }
        }

        private void txtIDCliente_Validated(object sender, EventArgs e)
        {
            if(txtIDCliente.Text.Trim().Length == 0)
            {
                txtNombreCliente.Text = "";
                Client = null;
                return;
            }
            int id = 0;
            if (!int.TryParse(this.txtIDCliente.Text.Trim(), out id))
            {
                MessageBox.Show("El id no es un valor entero.", "Documentos", MessageBox.Botones.Aceptar);
                txtNombreCliente.Text = "";
                Client = null;
                return;
            }
            Client clients = new Client(Contexto); 
            Client = clients.GetClient(id);
            if (Client == null)
            {
                MessageBox.Show("El cliente no existe.", "Documentos", MessageBox.Botones.Aceptar);
                txtNombreCliente.Text = "";
                return;
            }
            else
            {
                txtNombreCliente.Text = Client.name;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Document.dataFile != null && Document.dataFile.Length > 0)
            {
                Document.AbrirDocumento();
            }
            else
            {
                MessageBox.Show("Primero seleccione el documento.", "Documentos", MessageBox.Botones.Aceptar);
            }
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            if (this.txtID.Text.Trim() == "" || this.txtID.Text == "Nuevo")
            {
                this.txtID.Text = "Nuevo";
                txtDescripcion.Text = "";
                chkActivo.Checked = true;
                txtIDCliente.Text = "";
                txtNombreCliente.Text = "";
                lblEstadoDocumento.Text = "Documento en blanco";
                txtFecha.Text = DateTime.Now.ToString();
                rbdPDF.Checked = true;
            }
            else
            {
                int id = 0;
                if (!int.TryParse(this.txtID.Text.Trim(), out id))
                {
                    MessageBox.Show("El id no es un valor entero.", "Usuarios", MessageBox.Botones.Aceptar);
                    Limpiar();
                    return;
                }
                Document document = Document.GetDocument(id);
                if (document == null)
                {
                    MessageBox.Show("El Documento no existe.", "Usuarios", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
                else
                {
                    Document = document;
                    txtDescripcion.Text = document.description;
                    chkActivo.Checked = document.active;
                    txtIDCliente.Text = document.Cliente.idClient.ToString();
                    txtNombreCliente.Text = document.Cliente.name;
                    txtFecha.Text = document.date.ToString();
                    lblEstadoDocumento.Text = "Documento cargado";
                    Client = document.Cliente;
                    Client.Contexto = Contexto;
                }
            }
        }

        private void txtIDCliente_TextChanged(object sender, EventArgs e)
        {
            Utilerias.SoloEnteros((TextBox)sender);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            Utilerias.SoloEnteros((TextBox)sender);
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtDescripcion, ref e);
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtIDCliente, ref e);
        }

        private void txtIDCliente_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtNombreCliente, ref e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Escriba la descripción del documento.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            if (Client == null)
            {
                MessageBox.Show("Capture el cliente", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            if (Document.dataFile == null || Document.dataFile.Length == 0)
            {
                MessageBox.Show("Seleccione el documento.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }

            if ((txtID.Text.Trim() == "" || txtID.Text == "Nuevo"))
            {
                Document nuevoDocumento = new Document();
                nuevoDocumento.description = txtDescripcion.Text.Trim();
                nuevoDocumento.idClient = Client.idClient;
                nuevoDocumento.active = chkActivo.Checked;
                nuevoDocumento.dataFile = Document.dataFile;
                Document.CrearDocumento(nuevoDocumento);
                MessageBox.Show("Producto Creado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                Limpiar();
            }
            else
            {
                int id = 0;
                if (int.TryParse(txtID.Text.Trim(), out id) && id != 0)
                {
                    Document documentoActualizar = new Document();
                    documentoActualizar.description = txtDescripcion.Text.Trim();
                    documentoActualizar.idClient = Client.idClient;
                    documentoActualizar.active = chkActivo.Checked;
                    documentoActualizar.dataFile = Document.dataFile;
                    documentoActualizar.id = id;
                    Document.ActualizarDocumento(documentoActualizar);
                    MessageBox.Show("Producto Actualizado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmDocumentos_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void rbdPlantilla_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Plantilla |*.html";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Plantillas";
        }

        private void rbdPDF_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Pdf |*.pdf";
            openFileDialog.InitialDirectory = "";
        }

    }
}
