using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsSegAccionxRol
    {
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        int _IdAccionRol = 0;
        int _IdRol = 0;
        int _IdAccion = 0;
        String _UsuarioCreacion = "";
        DateTime _FechaCreacion;
        String _MaquinaCreacion = "";
        String _UsuarioModificacion = "";
        DateTime _FechaModificacion;
        String _MaquinaModificacion = "";

        String _CodigoAccion = "";

        #region"Constructores"

        public ClsSegAccionxRol() { }

        public ClsSegAccionxRol(int IdAccionRol, int IdRol, int IdAccion, String UsuarioCreacion,
            DateTime FechaCreacion, String MaquinaCreacion, String Usuariomodificacion,
            DateTime FechaModificacion, String MaquinaModificacion, String CodigoAccion)
        {
            IdAccionRol = _IdAccionRol;
            IdRol = _IdRol;
            IdAccion = _IdAccion;
            UsuarioCreacion = _UsuarioCreacion;
            FechaCreacion = _FechaCreacion;
            MaquinaCreacion = _MaquinaCreacion;
            Usuariomodificacion = _UsuarioModificacion;
            FechaModificacion = _FechaModificacion;
            MaquinaModificacion = _MaquinaModificacion;
            CodigoAccion = _CodigoAccion;
        }

        #endregion

        #region "Properties"

        public int IdAccionRol
        {

            get { return _IdAccionRol; }
            set { _IdAccionRol = value; }
        }

        public int IdAccion
        {

            get { return _IdAccion; }
            set { _IdAccion = value; }
        }

        public int IdRol
        {

            get { return _IdRol; }
            set { _IdRol = value; }
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

        public String CodigoAccion
        {
            get { return _CodigoAccion; }
            set { _CodigoAccion = value; }
        }
        #endregion

        #region "Guarda AccionRol"
        //Guarda las acciones por determinado rol
        public bool GuardaAccionRol()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_RolAccion_Ingresa");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;


            SqlParameter prmIdAccionRol = new SqlParameter("@ID", SqlDbType.Int);
            prmIdAccionRol.Value = _IdAccionRol;
            Com.Parameters.Add(prmIdAccionRol);

            SqlParameter prmRolId = new SqlParameter("@objRolID", SqlDbType.VarChar);
            prmRolId.Value = _IdRol;
            Com.Parameters.Add(prmRolId);

            SqlParameter prmAccionId = new SqlParameter("@objAccionID", SqlDbType.VarChar);
            prmAccionId.Value = _IdAccion;
            Com.Parameters.Add(prmAccionId);

            SqlParameter prmUsuarioCrea = new SqlParameter("@UsuarioCreacion", SqlDbType.VarChar);
            prmUsuarioCrea.Value = globales.RetornaLogin();
            Com.Parameters.Add(prmUsuarioCrea);

            SqlParameter prmfechaCrea = new SqlParameter("@FechaCreacion", SqlDbType.DateTime);
            prmfechaCrea.Value = DateTime.Now;
            Com.Parameters.Add(prmfechaCrea);

            SqlParameter prmMaquinaCrea = new SqlParameter("@MaquinaCreacion", SqlDbType.VarChar);
            prmMaquinaCrea.Value = globales.RetornaIP();
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

        /*Hecho por ricardo acuña*/
        public bool GuardaAccionPorRol()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_RolAccionPorCodigo_Ingresa");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            SqlParameter prmIdAccionRol = new SqlParameter("@ID", SqlDbType.Int);
            prmIdAccionRol.Value = _IdAccionRol;
            Com.Parameters.Add(prmIdAccionRol);

            SqlParameter prmRolId = new SqlParameter("@objRolID", SqlDbType.Int);
            prmRolId.Value = _IdRol;
            Com.Parameters.Add(prmRolId);

            SqlParameter prmcodigoAccion = new SqlParameter("@CodigoAccion", SqlDbType.VarChar);
            prmcodigoAccion.Value = _CodigoAccion;
            Com.Parameters.Add(prmcodigoAccion);

            SqlParameter prmUsuarioCrea = new SqlParameter("@UsuarioCreacion", SqlDbType.VarChar);
            prmUsuarioCrea.Value = globales.RetornaLogin();
            Com.Parameters.Add(prmUsuarioCrea);

            SqlParameter prmfechaCrea = new SqlParameter("@FechaCreacion", SqlDbType.DateTime);
            prmfechaCrea.Value = DateTime.Now;
            Com.Parameters.Add(prmfechaCrea);

            SqlParameter prmMaquinaCrea = new SqlParameter("@MaquinaCreacion", SqlDbType.VarChar);
            prmMaquinaCrea.Value = globales.RetornaIP();
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

        #region "Modifica AccionRol"
        //Modifica las acciones por determinado rol
        public bool ModificaAccionRol()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_RolAccion_Modifica");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;


            SqlParameter prmIdAccionRol = new SqlParameter("@ID", SqlDbType.Int);
            prmIdAccionRol.Value = _IdAccionRol;
            Com.Parameters.Add(prmIdAccionRol);

            SqlParameter prmRolId = new SqlParameter("@objRolID", SqlDbType.VarChar);
            prmRolId.Value = _IdRol;
            Com.Parameters.Add(prmRolId);

            SqlParameter prmAccionId = new SqlParameter("@objAccionID", SqlDbType.VarChar);
            prmAccionId.Value = _IdAccion;
            Com.Parameters.Add(prmAccionId);

            SqlParameter prmUsuarioCrea = new SqlParameter("@UsuarioModificacion", SqlDbType.VarChar);
            prmUsuarioCrea.Value = globales.RetornaLogin();
            Com.Parameters.Add(prmUsuarioCrea);

            SqlParameter prmFechaModificacion = new SqlParameter("@FechaModificacion", SqlDbType.DateTime);
            prmFechaModificacion.Value = DateTime.Now;
            Com.Parameters.Add(prmFechaModificacion);


            SqlParameter prmMaquinaModifica = new SqlParameter("@MaquinaModificacion", SqlDbType.VarChar);
            prmMaquinaModifica.Value = globales.RetornaIP();
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

        #region "Elimina las acciones por Rol"

        //Elimina las acciones que tienen asignadas determinados Roles.
        public bool EliminaAccionesRol(int ID)
        {
            try
            {
                ClsConexion conne = new ClsConexion();
                SqlConnection conex = new SqlConnection(conne.Conexion);
                conex.Open();
                SqlCommand Com = new SqlCommand("Delete from SegRolAccion where objRolID=" + ID, conex);
                SqlDataReader Data = Com.ExecuteReader();
                conex.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion

        #region"Retona Datatables"
        //Retorna las acciones que puede ejecutar determinado Rol.
        public DataTable AccionesRolXRol(int ID)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select * from dbo.SegRolAccion where objRolID = " + ID, Conne);
            result.Fill(tabla);

            Conne.Close();
            return tabla;
        }

        //Retorna las acciones de todos los roles.
        public DataTable TodasAccionesXRol(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select * from dbo.SegRolAccion where Nombre like '%" + Nombre + "%'", Conne);
            result.Fill(tabla);


            Conne.Close();
            return tabla;
        }
        #endregion
    }
}
