using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsSegRoles
    {
        ClsVariablesGoblales global = new ClsVariablesGoblales();

        int _ID = 0;
        String _Codigo = "";
        String _Nombre = "";
        String _Descripcion = "";
        String _UsuarioCreacion = "";
        DateTime _FechaCreacion;
        String _MaquinaCreacion = "";
        String _UsuarioModificacion = "";
        DateTime _FechaModificacion;
        String _MaquinaModificacion = "";


        #region"Constructores"
        public ClsSegRoles() { }

        public ClsSegRoles(int IdRol, String Codigo, String NombreRol, String Descripcion, String UsuarioCreacion,
            DateTime FechaCreacion, String MaquinaCreacion, String Usuariomodificacion,
            DateTime FechaModificacion, String MaquinaModificacion)
        {
            IdRol = _ID;
            Codigo = _Codigo;
            NombreRol = _Nombre;
            Descripcion = _Descripcion;
            UsuarioCreacion = _UsuarioCreacion;
            FechaCreacion = _FechaCreacion;
            MaquinaCreacion = _MaquinaCreacion;
            Usuariomodificacion = _UsuarioModificacion;
            FechaModificacion = _FechaModificacion;
            MaquinaModificacion = _MaquinaModificacion;
        }
        #endregion


        #region"Properties"

        public int IdRol
        {

            get { return _ID; }
            set { _ID = value; }
        }

        public String Codigo
        {

            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public String NombreRol
        {

            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String Descripcion
        {

            get { return _Descripcion; }
            set { _Descripcion = value; }
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


        #region "Guarda Rol"
        //Ejecuta procedimiento almacenado para guardar Rol.
        public bool GuardaRol()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_Rol_Ingresa");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            SqlParameter prmIdRol = new SqlParameter("@ID", SqlDbType.Int);
            prmIdRol.Value = _ID;
            Com.Parameters.Add(prmIdRol);

            SqlParameter prmCodigo = new SqlParameter("@Codigo", SqlDbType.VarChar);
            prmCodigo.Value = _Codigo;
            Com.Parameters.Add(prmCodigo);

            SqlParameter prmNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            prmNombre.Value = _Nombre;
            Com.Parameters.Add(prmNombre);

            SqlParameter prmDescripcion = new SqlParameter("@Descripcion", SqlDbType.VarChar);
            prmDescripcion.Value = _Descripcion;
            Com.Parameters.Add(prmDescripcion);

            SqlParameter prmUsuarioCrea = new SqlParameter("@UsuarioCreacion", SqlDbType.VarChar);
            prmUsuarioCrea.Value = global.RetornaLogin();
            Com.Parameters.Add(prmUsuarioCrea);

            SqlParameter prmfechaCrea = new SqlParameter("@FechaCreacion", SqlDbType.DateTime);
            prmfechaCrea.Value = DateTime.Now; ;
            Com.Parameters.Add(prmfechaCrea);

            SqlParameter prmMaquinaCrea = new SqlParameter("@MaquinaCreacion", SqlDbType.VarChar);
            prmMaquinaCrea.Value = global.RetornaIP();
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

        #region "Modifica Rol"
        //Ejecuta procedimiento almacenado para modificar el rol
        public bool ModificaRol()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_Rol_Modifica");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            SqlParameter prmIdRol = new SqlParameter("@ID", SqlDbType.Int);
            prmIdRol.Value = _ID;
            Com.Parameters.Add(prmIdRol);

            SqlParameter prmCodigo = new SqlParameter("@Codigo", SqlDbType.VarChar);
            prmCodigo.Value = _Codigo;
            Com.Parameters.Add(prmCodigo);

            SqlParameter prmNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
            prmNombre.Value = _Nombre;
            Com.Parameters.Add(prmNombre);

            SqlParameter prmDescripcion = new SqlParameter("@Descripcion", SqlDbType.VarChar);
            prmDescripcion.Value = _Descripcion;
            Com.Parameters.Add(prmDescripcion);

            SqlParameter prmUsuarioModifica = new SqlParameter("@UsuarioModificacion", SqlDbType.VarChar);
            prmUsuarioModifica.Value = global.RetornaLogin();
            Com.Parameters.Add(prmUsuarioModifica);

            SqlParameter prmFechaModificacion = new SqlParameter("@FechaModificacion", SqlDbType.DateTime);
            prmFechaModificacion.Value = DateTime.Now;
            Com.Parameters.Add(prmFechaModificacion);

            SqlParameter prmMaquinaModifica = new SqlParameter("@MaquinaModificacion", SqlDbType.VarChar);
            prmMaquinaModifica.Value = global.RetornaIP();
            Com.Parameters.Add(prmMaquinaModifica);

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

        //Retorna el rol que esta asociado a un ID
        public DataTable RolesXID(int ID)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select * from SegRol where ID=" + ID, Conne);
            result.Fill(tabla);


            Conne.Close();
            return tabla;
        }

        //Retorna los roles que tienen en su nombre el parametro que se le pasa a la funcion.
        public DataTable RolesXNombre(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select ID,Codigo as Código,Nombre,Descripcion as Descripción from SegRol where Nombre like '" + Nombre + "%' order by Nombre asc", Conne);
            result.Fill(tabla);


            Conne.Close();
            return tabla;
        }

        public String RetornaNombreRol(String Codigo)
        {
            ClsConexion con = new ClsConexion();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            DataTable tabla = new DataTable();
            SqlDataAdapter result = new SqlDataAdapter("SELECT TOP 1 Nombre FROM SegRol WHERE Codigo='" + Codigo + "'", Conne);
            result.Fill(tabla);
            if (tabla.Rows.Count > 0)
                return tabla.Rows[0][0].ToString();
            else
                return "";
        }
        #endregion
    }

}
