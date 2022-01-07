using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

/*
 * Realizado por Rene Jarquin
 * Fecha        04/04/2014
 * Descripción: Clase objeto con los valores para la conexión entre sistema y el servidor de base de datos.
 */

/* MODIFICADO POR RICARDO ACUÑA 
   10/01/2019 */

namespace Holding
{
    class ClsConexion
    {
        ClsEncripta encripta = new ClsEncripta();
        //ClsAdmSucursales Sucursales = new ClsAdmSucursales();

        //lee el App config y retorna el valor de la variable "Conexion"
        String _conexion = "";
        String _conexion2 = "";

        public static String _conexion3 = "";
        public static String _NameDB = "";
        public static String _conexion4 = "";

        public ClsConexion()
        {

            _conexion = "Server=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Server"].ToString()) + ";Database=" +
                encripta.Desencriptar(ConfigurationManager.AppSettings["Database"].ToString()) +
                ";User Id=" + encripta.Desencriptar(ConfigurationManager.AppSettings["User"].ToString()) +
                ";Password=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Password"].ToString());

            _conexion2 = "Server=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Server"].ToString()) + ";Database=" +
                encripta.Desencriptar(ConfigurationManager.AppSettings["Database2"].ToString()) +
                ";User Id=" + encripta.Desencriptar(ConfigurationManager.AppSettings["User"].ToString()) +
                ";Password=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Password"].ToString());

            _conexion4 = "Server=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Server"].ToString()) + ";Database=" +
             encripta.Desencriptar(ConfigurationManager.AppSettings["Database3"].ToString()) +
             ";User Id=" + encripta.Desencriptar(ConfigurationManager.AppSettings["User"].ToString()) +
             ";Password=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Password"].ToString());


        }

        public void ObtieneCadenaConexion(int idsucursal)
        {
            //_conexion3 = "";
            //_NameDB = "";
            //_NameDB = Sucursales.SucursalXID(idsucursal);
            //_conexion3 = "Server=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Server"].ToString()) +
            //    ";Database=" + NameDB +
            //    ";User Id=" + encripta.Desencriptar(ConfigurationManager.AppSettings["User"].ToString()) +
            //    ";Password=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Password"].ToString());
            
            if ( _conexion3 == null )
            {
                _conexion3 = "";
                _NameDB = "";
            }
        }

        public void BaseDatos(string nombredb)
        {
            _conexion3 = "";
            _NameDB = "";
            _NameDB = nombredb;
            _conexion3 = "Server=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Server"].ToString()) +
                ";Database=" + nombredb +
                ";User Id=" + encripta.Desencriptar(ConfigurationManager.AppSettings["User"].ToString()) +
                ";Password=" + encripta.Desencriptar(ConfigurationManager.AppSettings["Password"].ToString());

            if (_conexion3 == null)
            {
                _conexion3 = "";
                _NameDB = "";
            }
        }

        public ClsConexion(String Conexion,String Conexion2, String Conexion3, String NameDB, String Conexion4)
        {
            Conexion = _conexion;
            Conexion2 = _conexion2;
            Conexion3 = _conexion3;
            Conexion4 = _conexion4;
            NameDB = _NameDB;
        }

        public String Conexion
        {

            get { return _conexion; }
            set { _conexion = value; }
        }

        public String Conexion2
        {

            get { return _conexion2; }
            set { _conexion2 = value; }
        }

        public String Conexion3
        {
            get { return _conexion3 ; }
            set { _conexion3 = value; }
        }

        public String NameDB
        {
            get { return _NameDB; }
            set { _NameDB = value; }
        }

        public String Conexion4
        {
            get { return _conexion4; }
            set { _conexion4 = value; }
        }



    }
}
