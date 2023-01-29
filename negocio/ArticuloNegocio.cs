using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca, A.IdCategoria, A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string) lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];

                    lista.Add(aux);
                    
                }

                return lista;
            }
            catch (Exception ex )
            {

                throw ex;
            }

        }

        public void agregar( Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,ImagenUrl,Precio,IdMarca,IdCategoria) values (@Codigo,@Nombre,@Descripcion,@ImagenUrl,@Precio,@IdMarca, @IdCategoria)");
                datos.SetearParametro("@Codigo", nuevo.Codigo);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@ImagenUrl", nuevo.UrlImagen);
                datos.SetearParametro("@Precio", nuevo.Precio);
                datos.SetearParametro("@IdMarca", nuevo.Marca.Id);
                datos.SetearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
            datos.SetearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, ImagenUrl = @ImagenUrl, Precio = @Precio, IdMarca = @IdMarca, IdCategoria = @IdCategoria where Id = @Id");
            datos.SetearParametro("@Codigo", articulo.Codigo);
            datos.SetearParametro("@Nombre", articulo.Nombre);
            datos.SetearParametro("@Descripcion", articulo.Descripcion);
            datos.SetearParametro("@ImagenUrl", articulo.UrlImagen);
            datos.SetearParametro("@Precio", articulo.Precio);
            datos.SetearParametro("@IdMarca", articulo.Marca.Id);
            datos.SetearParametro("@IdCategoria", articulo.Categoria.Id);
            datos.SetearParametro("@Id", articulo.Id);

            datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Articulo> Filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca, A.IdCategoria, A.Id from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria and ";
                switch (campo)
                {
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "Precio < " + filtro;
                                break;
                            default:
                                consulta += "Precio = " + filtro; 
                                break;                           
                        }
                        break;
                   
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += "Nombre like '" + filtro + "%' ";
                                    break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "'";
                                    break;
                            default:
                                    consulta += "Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;
                                                                    
                    default:                       
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += "A.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "A.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                }
                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Eliminar(int id)
           
        {
            try
            {
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("Delete from ARTICULOS where Id = @Id");
            datos.SetearParametro("@Id", id);
            datos.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
