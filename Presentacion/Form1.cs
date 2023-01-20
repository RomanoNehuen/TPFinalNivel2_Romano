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
            Cargardgv();
           
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvArticulos.CurrentRow != null)
                {
                    Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    CargarImagen(Seleccionado.UrlImagen);

                }

            }
            catch (Exception ex)
            {

                throw ex;
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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            Cargardgv();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            Cargardgv();
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
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminarlo?","Eliminando Articulo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                
                if (resultado == DialogResult.Yes)
                {

                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloEliminado.Eliminar(seleccionado.Id);
                Cargardgv();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltrorapido_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro != "")
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
    }
}
