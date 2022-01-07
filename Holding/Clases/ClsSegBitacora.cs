using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsSegBitacora
    {
        ClsVariablesGoblales Globales = new ClsVariablesGoblales();
        //Variables para bitacora operacion
        int _ID = 0;
        DateTime _Fecha;
        String _UsuarioOperacion = "";
        String _MaquinaOperacion = "";
        String _Tabla= "";
        int _objTipoEventoID = 0;
        int _IdOperacion = 0;
        int _objPantallaSistemaID = 0;

        //Variables para Bitacora Sesion
        int _IdSesion = 0;
        DateTime _FechaSesion;
        int _usuarioSesion = 0;
        String _MaquinaSesion = "";
        String _LoginFallido = "";
        int _ObjEstadoSesionID = 0;
        int _objCausaEstadoID = 0;

        #region"Constructores"
            public ClsSegBitacora() { }

            public ClsSegBitacora(int IdOper, DateTime Fecha, String UsuarioOperacion, String Maquina, String Tabla, int ObjTipoEventoID,
                                  int IdOperacion,int ObjPantallaSistemaID, int IdSesion, DateTime FechaSesion, int UsuarioSesion, String MaquinaSesion,
                                   string LoginFallido, int ObjEstadoSesionIDSesion, int ObjCausaEstadoID)
            {
                IdOper =_ID;
                Fecha= _Fecha;
                UsuarioOperacion = _UsuarioOperacion;
                Maquina = _MaquinaOperacion;
                Tabla = _Tabla;
                ObjTipoEventoID = _objTipoEventoID;
                IdOperacion = _IdOperacion;
                ObjPantallaSistemaID = _objPantallaSistemaID;
                IdSesion = _IdSesion;
                MaquinaSesion = _MaquinaSesion;
                LoginFallido = _LoginFallido;
                ObjEstadoSesionIDSesion=_ObjEstadoSesionID;
                ObjCausaEstadoID = _objCausaEstadoID;
            }
      #endregion

        #region"Properties"

        public int IdBitacoraOperacion
        {

            get { return _ID; }
            set { _ID = value; }
        }

        public DateTime Fecha
        {

            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public String UsuarioOperacion
        {

            get { return _UsuarioOperacion; }
            set { _UsuarioOperacion = value; }
        }

        public String MaquinaOperacion
        {

            get { return _MaquinaOperacion; }
            set { _MaquinaOperacion = value; }
        }

        public String Tabla
        {

            get { return _Tabla; }
            set { _Tabla = value; }
        }



        public int ObjTipoEventoID
        {

            get { return _objTipoEventoID; }
            set { _objTipoEventoID = value; }
        }

        public int IdOperacion
        {

            get { return _IdOperacion; }
            set { _IdOperacion = value; }
        }

        public int ObjPantallaSistemaID
        {

            get { return _objPantallaSistemaID; }
            set { _objPantallaSistemaID = value; }
        }


        public int IdSesion
        {

            get { return _IdSesion; }
            set { _IdSesion = value; }
        }

        public DateTime FechaSesion
        {

            get { return _FechaSesion; }
            set { _FechaSesion = value; }
        }

        public int UsuarioSesion
        {

            get { return _usuarioSesion; }
            set { _usuarioSesion = value; }
        }

        public String MaquinaSesion
        {

            get { return _MaquinaSesion; }
            set { _MaquinaSesion = value; }
        }

        public String LoginFallido
        {

            get { return _LoginFallido; }
            set { _LoginFallido = value; }
        }

        public int ObjEstadoSesionId
        {

            get { return _ObjEstadoSesionID; }
            set { _ObjEstadoSesionID = value; }
        }

        public int ObjCausaEstadoID
        {

            get { return _objCausaEstadoID; }
            set { _objCausaEstadoID = value; }
        }

        #endregion

        //Ejecuta el procedimiento almacenado para guardar Bitacora Operacion con todos sus parametros respectivos.
        #region "Guarda Operacion"

        public bool GuardaOperacion()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_BitacoraOperacion");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            //Se cargan los parametros del procedimiento almacenado
                SqlParameter prmId = new SqlParameter("@ID", SqlDbType.BigInt);
                prmId.Value = _ID;
                Com.Parameters.Add(prmId);

                SqlParameter prmFecha = new SqlParameter("@Fecha", SqlDbType.DateTime);
                prmFecha.Value = DateTime.Now;
                Com.Parameters.Add(prmFecha);

                SqlParameter prmusuario = new SqlParameter("@Usuario", SqlDbType.BigInt);
                prmusuario.Value = Globales.RetornaIdUsuario();
                Com.Parameters.Add(prmusuario);

                SqlParameter prmMaquina = new SqlParameter("@Maquina", SqlDbType.VarChar);
                prmMaquina.Value = Globales.RetornaIP();
                Com.Parameters.Add(prmMaquina);

                SqlParameter prmTabla = new SqlParameter("@Tabla", SqlDbType.VarChar);
                prmTabla.Value = _Tabla;
                Com.Parameters.Add(prmTabla);

                if (_IdOperacion == 0)
                {
                    _IdOperacion = NumeroRegistro(_Tabla);
                    SqlParameter prmTipoEvento = new SqlParameter("@objTipoEventoID", SqlDbType.Int);
                    prmTipoEvento.Value = IdTipoEventoXNombre("TIPOOPERACIONBITACORA", "INSERT");
                    Com.Parameters.Add(prmTipoEvento);
                }
                else
                {
                    SqlParameter prmTipoEvento = new SqlParameter("@objTipoEventoID", SqlDbType.Int);
                    prmTipoEvento.Value = IdTipoEventoXNombre("TIPOOPERACIONBITACORA", "UPDATE");
                    Com.Parameters.Add(prmTipoEvento);
                }

                  
                SqlParameter prmIdOperacion = new SqlParameter("@IDOperacion", SqlDbType.Int);
                prmIdOperacion.Value = _IdOperacion;
                Com.Parameters.Add(prmIdOperacion);
                    
                  
                SqlParameter prmPantallaSistemaID = new SqlParameter("@objPantallaSistemaID", SqlDbType.Int);
                prmPantallaSistemaID.Value = _objPantallaSistemaID;
                Com.Parameters.Add(prmPantallaSistemaID);

            //Ejecuta el Procemiento almacenado con los respectivos parametros
            if (Com.ExecuteNonQuery() != 0)
            {
                //Cierro todas las conexiones
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
                //Cierro todas las conexiones
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

        //Ejecuta el procedimiento almacenado para guardar Bitacora Operacion con todos sus parametros respectivos.
        #region "Guarda Inicio de Sesion"

        public bool GuardaInicioSesion()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_BitacoraSesion");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

               
                SqlParameter prmId = new SqlParameter("@ID", SqlDbType.BigInt);
                prmId.Value = _IdSesion;
                Com.Parameters.Add(prmId);

                SqlParameter prmFecha = new SqlParameter("@Fecha", SqlDbType.DateTime);
                prmFecha.Value = DateTime.Now;
                Com.Parameters.Add(prmFecha);

                if (Globales.RetornaIdUsuario() == 0)
                {
                    SqlParameter prmusuario = new SqlParameter("@Usuario", SqlDbType.BigInt);
                    prmusuario.Value = null;
                    Com.Parameters.Add(prmusuario);
                }
                else 
                {
                    SqlParameter prmusuario = new SqlParameter("@Usuario", SqlDbType.BigInt);
                    prmusuario.Value = Globales.RetornaIdUsuario();
                    Com.Parameters.Add(prmusuario);
                }

                SqlParameter prmMaquina = new SqlParameter("@Maquina", SqlDbType.VarChar);
                prmMaquina.Value = Globales.RetornaIP();
                Com.Parameters.Add(prmMaquina);

                SqlParameter prmLoginFalla = new SqlParameter("@LogInFallido", SqlDbType.VarChar);
                prmLoginFalla.Value = _LoginFallido;
                Com.Parameters.Add(prmLoginFalla);


                SqlParameter prmEstado = new SqlParameter("@objEstadoSesionID", SqlDbType.Int);
                prmEstado.Value = _ObjEstadoSesionID;
                Com.Parameters.Add(prmEstado);

                if (_objCausaEstadoID == 0)
                {
                    SqlParameter prmCausa = new SqlParameter("@objCausaEstadoID", SqlDbType.Int);
                    prmCausa.Value = null;
                    Com.Parameters.Add(prmCausa);
                }
                else
                {
                    SqlParameter prmCausa = new SqlParameter("@objCausaEstadoID", SqlDbType.Int);
                    prmCausa.Value = _objCausaEstadoID;
                    Com.Parameters.Add(prmCausa);
                }
                    

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

        #region "Retorna Bitacora"
        //retorna Id de los tipos de Evento de bitacora
        public int IdTipoEventoXNombre(String CodigoCatalogo, String CodigoCatalogoValor)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Id from StbCatalogo where Codigo ='" + CodigoCatalogo + "'", Conne);
            result.Fill(tabla);
            int idCatalogo = int.Parse(tabla.Rows[0][0].ToString());
                result = new SqlDataAdapter("select Id from StbCatalogoValor where objCatalogoID=" + idCatalogo + " and Codigo ='" + CodigoCatalogoValor + "'", Conne);
            tabla.Clear();
            result.Fill(tabla);
            Conne.Close();

            int IdCatalogoValor = int.Parse(tabla.Rows[0][0].ToString());
            return IdCatalogoValor;
               
        }

        //retorna Id de los tipos de Operacion de bitacora
        public int IdAccionXNombre(String Codigo)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Id from SegAccion where Codigo ='" + Codigo + "'", Conne);
            result.Fill(tabla);
            int id = int.Parse(tabla.Rows[0][0].ToString());
            Conne.Close();
            return id;

        }

    //Retorna el Id del estado de la sesion por la causa
        public int IdEstadoXCausa(String CodigoCatalogo, String CodigoCatalogoValor)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Id from StbCatalogo where Codigo ='" + CodigoCatalogo + "'", Conne);
            result.Fill(tabla);
            int idCatalogo = int.Parse(tabla.Rows[0][0].ToString());
            tabla.Clear();
            result = new SqlDataAdapter("select * from stbcatalogovalor where objCatalogoID=" + idCatalogo + " and codigo='" + CodigoCatalogoValor + "'", Conne);
            result.Fill(tabla);
            int idCatalogoValor = int.Parse(tabla.Rows[0][0].ToString());

            Conne.Close();
            return idCatalogoValor;

        }


        //retorna Id del registro  de Operacion de bitacora
        public int NumeroRegistro(String NombreTabla)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select max(Id) from " + NombreTabla , Conne);
            result.Fill(tabla);
            int id = int.Parse(tabla.Rows[0][0].ToString());

            Conne.Close();
            return id;

        }

        public DataTable BitacorasOperacion()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select SegBitacoraOperacion.Fecha,SegUsuario.Nombre,SegBitacoraOperacion.Maquina,SegBitacoraOperacion.Tabla, StbCatalogoValor.Valor,SegBitacoraOperacion.IDoperacion as Registro, SegAccion.Nombre as Acción from SegBitacoraOperacion inner join SegUsuario on SegBitacoraOperacion.objUsuarioID=SegUsuario.ID inner join StbCatalogoValor on SegBitacoraOperacion.objTipoEventoID=StbCatalogoValor.ID inner join SegAccion on SegAccion.ID=SegBitacoraOperacion.objAccionID where cast(Fecha as Date) between cast (DATEADD(day, -"+NumerodeDias()+",GETDATE())as Date) and cast (GETDATE()as Date) order by fecha desc" , Conne);
            result.Fill(tabla);
       

            Conne.Close();
            return tabla;

        }

        public DataTable BitacorasSesion()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select SegBitacoraSesion.Fecha,(select Nombre from SegUsuario where ID=SegBitacoraSesion.objUsuarioID) as Usuario,SegBitacoraSesion.Maquina,SegBitacoraSesion.LogInFallido,StbCatalogoValor.Valor,(select Valor from StbCatalogoValor where SegBitacoraSesion.objCausaEstadoID=StbCatalogoValor.ID)as Causa from SegBitacoraSesion inner join StbCatalogoValor on SegBitacoraSesion.objEstadoSesionID=StbCatalogoValor.ID where cast(Fecha as Date) between cast (DATEADD(day, -" + NumerodeDias() + ",GETDATE())as Date) and cast (GETDATE()as Date) order by fecha desc", Conne);
            result.Fill(tabla);


            Conne.Close();
            return tabla;

        }

        public int NumerodeDias()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro WHERE Nombre='DIASMOSTRARBITACORA'", Conne);
            result.Fill(tabla);
            int Valor = int.Parse(tabla.Rows[0][0].ToString());

            Conne.Close();
            return Valor;

        }

        public int IdEstadoSesion(String CodigoCatalogo, String CodigoCatalogoValor)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Id from StbCatalogo where Codigo ='" + CodigoCatalogo + "'", Conne);
            result.Fill(tabla);
            int idCatalogo = int.Parse(tabla.Rows[0][0].ToString());
            tabla.Clear();
            result = new SqlDataAdapter("select * from StbCatalogoValor where objCatalogoID=" + idCatalogo + " and Codigo= '" + CodigoCatalogoValor + "'", Conne);
            result.Fill(tabla);
            int Valor = int.Parse(tabla.Rows[0][0].ToString());

            Conne.Close();
            return Valor;

        }

    //Retorna todas las acciones que existen en la tabla bitacora sesion
        public DataTable AccionesBitacora()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select DISTINCT (Nombre) as Nombre,SegAccion.ID from SegAccion inner join SegBitacoraOperacion on SegAccion.ID=SegBitacoraOperacion.objAccionID order by Nombre asc", Conne);
            result.Fill(tabla);


            Conne.Close();
            return tabla;

        }

    //devuelve El nombre del estado de la sesion
        public String EstadoSesion(string CodigoCatalogo, string CodigoCatalogoValor)
        {
                ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Id from StbCatalogo where Codigo ='" + CodigoCatalogo + "'", Conne);
            result.Fill(tabla);
            int idCatalogo = int.Parse(tabla.Rows[0][0].ToString());
            tabla.Clear();
            string P=" select * from StbCatalogoValor where objCatalogoID=" + idCatalogo + " and Codigo= '" + CodigoCatalogoValor + "'";
            result = new SqlDataAdapter("select * from StbCatalogoValor where objCatalogoID=" + idCatalogo + " and Codigo= '" + CodigoCatalogoValor + "'", Conne);
            result.Fill(tabla);
            String Valor = tabla.Rows[0][2].ToString();

            Conne.Close();
            return Valor;


        }

        public DataTable BitacoraOperacionFechas(string Filtro)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select * from SegBitacoraOperacion where "+Filtro, Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }

        public DataTable BitacoraSesionFechas(string Filtro)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            string Consulta = "select * from SegBitacoraSesion where " + Filtro;
            SqlDataAdapter result = new SqlDataAdapter("select * from SegBitacoraSesion where "+Filtro, Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }
        #endregion

    }
}
