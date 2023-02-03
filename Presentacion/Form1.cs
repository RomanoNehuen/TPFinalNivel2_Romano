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
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            Cargardgv();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
          
        }
        private void VerDetalle(Articulo Seleccionado)
        {
            
            txtCodigo.Text = Seleccionado.Codigo.ToString();
            txtNombre.Text = Seleccionado.Nombre;
            txtPrecio.Text = Seleccionado.Precio.ToString("0.00");
            txtMarca.Text = Seleccionado.Marca.ToString();
            txtCategoria.Text = Seleccionado.Categoria.ToString();
            txtDescripcion.Text = Seleccionado.Descripcion;
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvArticulos.CurrentRow != null)
                {
                    Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    CargarImagen(Seleccionado.UrlImagen);
                    VerDetalle(Seleccionado);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void Cargardgv()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                OcultarColumnas();
                pbxArticulos.Load(listaArticulos[0].UrlImagen);
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void CargarImagen(string imagen)

        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception)
            {

                pbxArticulos.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");
            }

           
        }
        private void OcultarColumnas()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaArticulo alta = new frmAltaArticulo();
                alta.ShowDialog();
                Cargardgv();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                    modificar.ShowDialog();
                    Cargardgv();
                } 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }  
            
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArticuloEliminado = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminarlo?","Eliminando Articulo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                
                    if (resultado == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        ArticuloEliminado.Eliminar(seleccionado.Id);
                        Cargardgv();

                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool ValidarFiltro() 
        { 
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el campo a filtrar");
                return false;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio a filtrar");
                return false;
            }
            if(cboCampo.SelectedItem.ToString() == "Precio")
            {
                
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Ingresar número a filtrar");
                    return false;
                }

                if (!(SoloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Debe ingrese solo números al filtrar por campo numérico");
                    return false;
                }

            }
            return true; 
        }
        private bool SoloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;                                 
            }
            return true;
        }
        private void btnFiltrarArticulo_Click(object sender, EventArgs e)
        {
           ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (!(ValidarFiltro()))
                {
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvArticulos.DataSource = negocio.Filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(valor => valor.Nombre.ToUpper().Contains(filtro.ToUpper()) || valor.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || valor.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
            
        }
    }
}
