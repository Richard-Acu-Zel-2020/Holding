using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsStbParametros
    {
        ClsVariablesGoblales Globales = new ClsVariablesGoblales();
        int _ID = 0;
        String _Nombre = "";
        String _Valor = "";
        String _Descripcion = "";
        int _objCatalogoId = 0;
        String _UsuarioCreacion = "";
        DateTime _FechaCreacion;
        String _MaquinaCreacion = "";
        String _UsuarioModificacion = "";
        DateTime _FechaModificacion;
        String _MaquinaModificacion = "";

        #region"Constructores"
        public ClsStbParametros() { }

        public ClsStbParametros(int IdParametro, String Nombre, String Valor, String Descripcion, int objCatalogoID,
            String UsuarioCreacion, DateTime FechaCreacion, String MaquinaCreacion, String Usuariomodificacion,
            DateTime FechaModificacion, String MaquinaModificacion)
        {
            IdParametro = _ID;
            Nombre = _Nombre;
            Valor = _Valor;
            Descripcion = _Descripcion;
            objCatalogoID = _objCatalogoId;
            UsuarioCreacion = _UsuarioCreacion;
            FechaCreacion = _FechaCreacion;
            MaquinaCreacion = _MaquinaCreacion;
            Usuariomodificacion = _UsuarioModificacion;
            FechaModificacion = _FechaModificacion;
            MaquinaModificacion = _MaquinaModificacion;
        }
        #endregion

        #region"Properties"

        public int IdParametro
        {

            get { return _ID; }
            set { _ID = value; }
        }

        public String Nombre
        {

            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String Valor
        {

            get { return _Valor; }
            set { _Valor = value; }
        }

        public String Descripcion
        {

            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int ObjCatalogoId
        {

            get { return _objCatalogoId; }
            set { _objCatalogoId = value; }
        }



        public String UsuarioCreacion
        {

            get { return _UsuarioCreacion; }
            set { _UsuarioCreacion = value; }
        }

        public DateTime FechaCreacion
        {

            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public String MaquinaCreacion
        {

            get { return _MaquinaCreacion; }
            set { _MaquinaCreacion = value; }
        }


        public String UsuarioModificacion
        {

            get { return _UsuarioModificacion; }
            set { _UsuarioModificacion = value; }
        }

        public DateTime FechaModificacion
        {

            get { return _FechaModificacion; }
            set { _FechaModificacion = value; }
        }

        public String MaquinaModificacion
        {

            get { return _MaquinaModificacion; }
            set { _MaquinaModificacion = value; }
        }

        #endregion

        #region "Guarda Parametro"

        public bool GuardaParametro()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Stb_Parametro_Ingresa");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

          
                SqlParameter prmId = new SqlParameter("@ID", SqlDbType.Int);
                prmId.Value = _ID;
                Com.Parameters.Add(prmId);

                SqlParameter prmNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                prmNombre.Value = _Nombre;
                Com.Parameters.Add(prmNombre);

                SqlParameter prmDescripcion = new SqlParameter("@Descripcion", SqlDbType.VarChar);
                prmDescripcion.Value = _Descripcion;
                Com.Parameters.Add(prmDescripcion);

                SqlParameter prmValor = new SqlParameter("@Valor", SqlDbType.VarChar);
                prmValor.Value = _Valor;
                Com.Parameters.Add(prmValor);

                SqlParameter prmObjCategoriaID = new SqlParameter("@ObjCategoriaID", SqlDbType.Int);
                prmObjCategoriaID.Value = _objCatalogoId;
                Com.Parameters.Add(prmObjCategoriaID);

                SqlParameter prmUsuarioCrea = new SqlParameter("@UsuarioCreacion", SqlDbType.VarChar);
                prmUsuarioCrea.Value = Globales.RetornaLogin();
                Com.Parameters.Add(prmUsuarioCrea);

                SqlParameter prmfechaCrea = new SqlParameter("@FechaCreacion", SqlDbType.DateTime);
                prmfechaCrea.Value = DateTime.Now;
                Com.Parameters.Add(prmfechaCrea);

                SqlParameter prmMaquinaCrea = new SqlParameter("@MaquinaCreacion", SqlDbType.VarChar);
                prmMaquinaCrea.Value = Globales.RetornaIP();
                Com.Parameters.Add(prmMaquinaCrea);

                if (Com.ExecuteNonQuery() != 0)
                {
                    Com.Dispose();
                    Com = null;
                    if (conex.State == ConnectionState.Open)
                    {
                        conex.Close();
                    }

                    conex.Dispose();
                    conex = null;
                    return true;
                }

                else
                {
                    Com.Dispose();
                    Com = null;
                    if (conex.State == ConnectionState.Open)
                    {
                        conex.Close();
                    }

                    conex.Dispose();
                    conex = null;
                    return false;
                }

        }
        #endregion

        #region "Modifica Parametro"

        public bool ModificaParametro()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Stb_Parametro_Modifica");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

           
                SqlParameter prmId = new SqlParameter("@ID", SqlDbType.Int);
                prmId.Value = _ID;
                Com.Parameters.Add(prmId);

                SqlParameter prmNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                prmNombre.Value = _Nombre;
                Com.Parameters.Add(prmNombre);

                SqlParameter prmDescripcion = new SqlParameter("@Descripcion", SqlDbType.VarChar);
                prmDescripcion.Value = _Descripcion;
                Com.Parameters.Add(prmDescripcion);

                SqlParameter prmValor = new SqlParameter("@Valor", SqlDbType.VarChar);
                prmValor.Value = _Valor;
                Com.Parameters.Add(prmValor);

                SqlParameter prmObjCategoriaID = new SqlParameter("@ObjCategoriaID", SqlDbType.Int);
                prmObjCategoriaID.Value = _objCatalogoId;
                Com.Parameters.Add(prmObjCategoriaID);

                SqlParameter prmUsuarioModi = new SqlParameter("@UsuarioModificacion", SqlDbType.VarChar);
                prmUsuarioModi.Value = Globales.RetornaLogin();
                Com.Parameters.Add(prmUsuarioModi);

                SqlParameter prmfechaModi = new SqlParameter("@FechaModificacion", SqlDbType.DateTime);
                prmfechaModi.Value = DateTime.Now;
                Com.Parameters.Add(prmfechaModi);

                SqlParameter prmMaquinaModi = new SqlParameter("@MaquinaModificacion", SqlDbType.VarChar);
                prmMaquinaModi.Value = Globales.RetornaIP();
                Com.Parameters.Add(prmMaquinaModi);

                if (Com.ExecuteNonQuery() != 0)
                {
                    Com.Dispose();
                    Com = null;
                    if (conex.State == ConnectionState.Open)
                    {
                        conex.Close();
                    }

                    conex.Dispose();
                    conex = null;
                    return true;
                }

                else
                {
                    Com.Dispose();
                    Com = null;
                    if (conex.State == ConnectionState.Open)
                    {
                        conex.Close();
                    }

                    conex.Dispose();
                    conex = null;
                    return false;
                }
        }
        #endregion

        #region"Retona Datatables"

        //Retorna Las acciones mediante el nombre que se le pase
        public DataTable ParametrosXNombre(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select StbParametro.ID,StbCatalogoValor.Valor as Categoría,StbParametro.Nombre,StbParametro.Valor,StbParametro.Descripcion as Descripción,StbCatalogoValor.ID as IdValor from StbParametro inner join StbCatalogoValor on StbParametro.objCategoriaID=StbCatalogoValor.ID  where Nombre like '%" + Nombre + "%' order by Categoría,Nombre asc", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable CategoriasParametro(string nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select IdCatalogovalor as ID,valorcatalogovalor as Valor from dbo.vw_Stb_CatalogoParametro where valorcatalogovalor like '%" + nombre + "%' and CodigoCatalogo='CATEGORIAPARAMETRO' and EstadoCatalogoValor='1' order by Valor asc", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public string  MonedaBase(string Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro where Nombre='"+Nombre+"'", Conne);
            result.Fill(tabla);
            string valor = tabla.Rows[0][0].ToString();
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return valor;
        }

        public string ParametroPorNombre(string Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro where Nombre='" + Nombre + "'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            string valor="";

            if(tabla.Rows.Count>0)
                valor = tabla.Rows[0][0].ToString();

            return valor;
        }

        public string ParametroPorNombrePorBD(String Nombre, String BD)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            String Consulta = "";

            Consulta = "USE " + BD + " SELECT Valor FROM StbParametro WHERE Nombre='" + Nombre + "'";
            SqlDataAdapter result = new SqlDataAdapter(Consulta, Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            string valor = "";

            if (tabla.Rows.Count > 0)
                valor = tabla.Rows[0][0].ToString();

            return valor;
        }

        #endregion
    }
}
