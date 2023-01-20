using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          
            ArticuloNegocio negocio = new ArticuloNegocio();
           
            try
            {             
                if(articulo == null)
                
                {
                articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo. Descripcion = TxtDescripcion.Text;
                articulo.UrlImagen = txtUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                }
                            
                if(articulo.Id != 0)
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");

                }

                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcanegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categorianegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString("0.00");
                    TxtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.UrlImagen;
                    CargarImagen(articulo.UrlImagen);
                    
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CargarImagen(string imagen)

        {
            try
            {
                pbxNuevaImagen.Load(imagen);
            }
            catch (Exception)
            {

                pbxNuevaImagen.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }
    }
}
