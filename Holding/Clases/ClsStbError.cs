using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsStbError
    {

        ClsVariablesGoblales Globales = new ClsVariablesGoblales();
        ClsSegBitacora Bitacora = new ClsSegBitacora();
        
        int _ID = 0;
        String _UsuarioOperacion = "";
        String _MaquinaOperacion = "";
        String _Tabla= "";
        String _Formulario= "";
        String _DetalleError = "";

        #region"Constructores"
            public ClsStbError() { }

            public ClsStbError(int IdOper, String UsuarioOperacion, String Maquina, String Tabla, String Formulario)
            {
                IdOper =_ID;
                UsuarioOperacion = _UsuarioOperacion;
                Maquina = _MaquinaOperacion;
                Tabla = _Tabla;
                Formulario = _Formulario;
            }
      #endregion

        #region"Properties"

            public int IdError
            {
                get { return _ID; }
                set { _ID = value; }
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

            public String Formulario
            {
                get { return _Formulario; }
                set { _Formulario = value; }
            }                  

            public String DetalleError
            {
                get { return _DetalleError; }
                set { _DetalleError = value; }
            }
            
            #endregion

        #region "Guarda Operacion"

        public bool GuardaError()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Stb_Error_Inserta");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            //Se cargan los parametros del procedimiento almacenado
            SqlParameter prmId = new SqlParameter("@ID", SqlDbType.BigInt);
            prmId.Value = _ID;
            Com.Parameters.Add(prmId);
                        
            SqlParameter prmusuario = new SqlParameter("@Usuario", SqlDbType.BigInt);
            prmusuario.Value = Globales.RetornaIdUsuario();
            Com.Parameters.Add(prmusuario);

            SqlParameter prmMaquina = new SqlParameter("@Maquina", SqlDbType.VarChar);
            prmMaquina.Value = Globales.RetornaIP();
            Com.Parameters.Add(prmMaquina);

            SqlParameter prmTabla = new SqlParameter("@Tabla", SqlDbType.VarChar);
            prmTabla.Value = _Tabla;
            Com.Parameters.Add(prmTabla);

            SqlParameter prmFormulario = new SqlParameter("@Formulario", SqlDbType.VarChar);
            prmFormulario.Value = _Formulario;
            Com.Parameters.Add(prmFormulario);
            
            SqlParameter prmDetalleError = new SqlParameter("@Error", SqlDbType.VarChar);
            prmDetalleError.Value = _DetalleError;
            Com.Parameters.Add(prmDetalleError);

            //Ejecuta el Procemiento almacenado con los respectivos parametros
            if (Com.ExecuteNonQuery() != 0)
            {
                //Cierro todas las conexiones
                Com.Dispose();
                Com = null;
                if (conex.State == ConnectionState.Open)
                    conex.Close();

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
                    conex.Close();

                conex.Dispose();
                conex = null;
                return false;
            }

        }


        #endregion

    }
}
