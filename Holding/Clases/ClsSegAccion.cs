using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsSegAccion
    {
        ClsVariablesGoblales Globales = new ClsVariablesGoblales();
        int _ID = 0;
        String _Codigo = "";
        String _Nombre = "";
        String _Descripcion = "";
        int _Orden = 0;
        String _UsuarioCreacion = "";
        DateTime _FechaCreacion;
        String _MaquinaCreacion = "";
        String _UsuarioModificacion = "";
        DateTime _FechaModificacion;
        String _MaquinaModificacion = "";


        #region"Constructores"
        public ClsSegAccion() { }

        public ClsSegAccion(int IdRol, String Codigo, String NombreRol, String Descripcion, int Orden, String UsuarioCreacion,
            DateTime FechaCreacion, String MaquinaCreacion, String Usuariomodificacion,
            DateTime FechaModificacion, String MaquinaModificacion)
        {
            IdRol = _ID;
            Codigo = _Codigo;
            NombreRol = _Nombre;
            Descripcion = _Descripcion;
            Orden = _Orden;
            UsuarioCreacion = _UsuarioCreacion;
            FechaCreacion = _FechaCreacion;
            MaquinaCreacion = _MaquinaCreacion;
            Usuariomodificacion = _UsuarioModificacion;
            FechaModificacion = _FechaModificacion;
            MaquinaModificacion = _MaquinaModificacion;
        }
        #endregion


        #region"Properties"

        public int IdAccion
        {

            get { return _ID; }
            set { _ID = value; }
        }

        public String Codigo
        {

            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public String NombreAccion
        {

            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String Descripcion
        {

            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int Orden
        {

            get { return _Orden; }
            set { _Orden = value; }
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

        //Ejecuta el procedimiento almacenado para guardar accion con todos sus parametros respectivos.
        #region "Guarda Accion"

        public bool GuardaAccion()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_Accion_Ingresa");
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

            SqlParameter prmOrden = new SqlParameter("@Orden", SqlDbType.Int);
            prmOrden.Value = _Orden;
            Com.Parameters.Add(prmOrden);

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

        //Ejecuta el procedimiento almacenado para Modificar accion con todos sus parametros respectivos.
        #region "Modifica Accion"
        public bool ModificaAccion()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_Accion_Modifica");
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

            SqlParameter prmOrden = new SqlParameter("@Orden", SqlDbType.Int);
            prmOrden.Value = _Orden;
            Com.Parameters.Add(prmOrden);


            SqlParameter prmUsuarioModifica = new SqlParameter("@UsuarioModificacion", SqlDbType.VarChar);
            prmUsuarioModifica.Value = Globales.RetornaLogin();
            Com.Parameters.Add(prmUsuarioModifica);


            SqlParameter prmFechaModificacion = new SqlParameter("@FechaModificacion", SqlDbType.DateTime);
            prmFechaModificacion.Value = DateTime.Now;
            Com.Parameters.Add(prmFechaModificacion);


            SqlParameter prmMaquinaModifica = new SqlParameter("@MaquinaModificacion", SqlDbType.VarChar);
            prmMaquinaModifica.Value = Globales.RetornaIP();
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

        //Retorna una accion deacuerdo al ID que se le pasa.
        public DataTable AccionesXId(int ID)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select * from SegAccion where ID=" + ID, Conne);
            result.Fill(tabla);


            Conne.Close();
            return tabla;
        }

        public DataTable TodasLasAcciones(int idRol)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"select distinct SegAccion.ID, Orden, SegAccion.Nombre, SegAccion.Codigo as Código, SegAccion.Descripcion as Descripción, 
            (CASE WHEN (SELECT ID FROM SegRolAccion tblrolaccion WHERE objRolID = " + idRol + ""
            + " AND objAccionID = SegAccion.ID) IS NOT NULL THEN 1 ELSE 0 END) AS Existe "
            + " from SegAccion "
            + " order by Orden Asc", Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }

        public DataTable AccionesNoAsignadas(int idRol)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"select distinct SegAccion.ID, Orden, SegAccion.Nombre, SegAccion.Codigo as Código, SegAccion.Descripcion as Descripción, 
            (CASE WHEN (SELECT ID FROM SegRolAccion tblrolaccion WHERE objRolID = " + idRol + ""
            + " AND objAccionID = SegAccion.ID) IS NOT NULL THEN 1 ELSE 0 END) AS Existe "
            + " from SegAccion "
            + " WHERE SegAccion.ID NOT IN (SELECT objAccionID FROM SegRolAccion WHERE objRolID= " + idRol + " ) "
            + " order by SegAccion.Codigo Asc", Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }


        public DataTable BuscarTodasAccionesPorRolCodigo(int idRol, String codigo)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"select distinct SegAccion.ID, Orden, SegAccion.Nombre, SegAccion.Codigo as Código, SegAccion.Descripcion as Descripción, 
            (CASE WHEN (SELECT ID FROM SegRolAccion tblrolaccion WHERE objRolID = " + idRol + ""
            + " AND objAccionID = SegAccion.ID) IS NOT NULL THEN 1 ELSE 0 END) AS Existe "
            + " from SegAccion "
            + " WHERE SegAccion.Codigo LIKE '%" + codigo + "%' "
            + " ORDER BY SegAccion.Codigo ASC", Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }

        public DataTable AccionesXRol(int objRolID)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"select SegAccion.ID, SegAccion.Orden, SegAccion.Nombre, SegAccion.Codigo as Código, SegAccion.Descripcion as Descripción, 1 AS Existe
            from SegRolAccion 
            inner join SegRol on SegRol.ID = SegRolAccion.objRolID
            inner join SegAccion on SegAccion.ID = SegRolAccion.objAccionID
            where SegRol.ID = " + objRolID + "", Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }

        public DataTable BuscarAccionesXRolCodigo(int objRolID, String codigo)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"select SegAccion.ID, SegAccion.Orden, SegAccion.Nombre, SegAccion.Codigo as Código, SegAccion.Descripcion as Descripción, 1 AS Existe
            from SegRolAccion 
            inner join SegRol on SegRol.ID = SegRolAccion.objRolID
            inner join SegAccion on SegAccion.ID = SegRolAccion.objAccionID
            where SegRol.ID = " + objRolID + "" +
            " AND SegAccion.Codigo LIKE '%" + codigo + "%' ORDER BY SegAccion ASC", Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }

        public DataTable EliminarAccionxRol(int objRolID, string codigoaccion)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"delete SegRolAccion FROM SegRolAccion
            inner join SegRol on SegRol.ID = SegRolAccion.objRolID
            inner join SegAccion on SegAccion.ID = SegRolAccion.objAccionID
            where segaccion.Codigo = '" + codigoaccion + "' AND SegRol.ID = " + objRolID + "", Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }

        //Retorna las acciones que tienen en su nombre la palabra que se le pasa.
        public DataTable AccionesXNombre(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select ID,Orden,Codigo as Código, Nombre,Descripcion as Descripción  from SegAccion where Nombre like '%" + Nombre + "%' order by Orden Asc", Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }

        //Retorna el numero maximo de todas las acciones
        public int NumMax(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select MAX(orden) from segAccion", Conne);
            result.Fill(tabla);
            int numero = int.Parse(tabla.Rows[0][0].ToString()) + 1;
            Conne.Close();
            return numero;
        }
        #endregion

    }
}
