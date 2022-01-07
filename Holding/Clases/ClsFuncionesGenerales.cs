using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.IO;
/*
 * Realizado por Rene Jarquin
 * Fecha        11/03/2015
 * Descripción: Clase objeto con funciones compartidas de utilidad para otros objetos del sistema
 */

/*Michelle Reyes*/
//Modificacion Rene
namespace Holding
{
    class ClsFuncionesGenerales
    {

        /*---------------------------------------Funciones Rene Jarquin-------------------------------------------------------------------*/
         //Retorna todos los Catalogos Valor de un determinado catalogo
        public DataTable TodosCatalogoValorXCatalogo(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.* from StbCatalogo" +
                " inner join StbCatalogoValor on StbCatalogo.ID= StbCatalogoValor.objCatalogoID where StbCatalogo.Codigo='" + Nombre + "' order by StbCatalogoValor.Valor", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable TodosCatalogoValorXCatalogoActivos(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.* from StbCatalogo" +
                " inner join StbCatalogoValor on StbCatalogo.ID = StbCatalogoValor.objCatalogoID where StbCatalogo.Codigo = '" + Nombre + "' AND Activo = 1 order by StbCatalogoValor.Valor ASC", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable TodosCatalogoValorXCatalogoActivosCasaMatriz(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            DataTable tabla2 = new DataTable();
            tabla2.Clear();
            SqlDataAdapter NombreDB = new SqlDataAdapter("SELECT TOP 1 NombreDB FROM StbSucursal WHERE Siglas = (SELECT Valor FROM StbParametro WHERE Nombre = 'NOMBRESIGLAMATRIZ')", con.Conexion);
            NombreDB.Fill(tabla2);
            string nombresiglamatriz = tabla2.Rows[0][0].ToString();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter(@"select StbCatalogoValor.* "
            + " from "+ nombresiglamatriz +".dbo.StbCatalogo "
            + " inner join " + nombresiglamatriz + ".dbo.StbCatalogoValor on StbCatalogo.ID= StbCatalogoValor.objCatalogoID "
            + " where StbCatalogo.Codigo='" + Nombre + "' AND Activo=1 order by StbCatalogoValor.Valor", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        //Retorna un catalogo valor determinado de determinado catalogo
        public DataTable CatalogoValorXCatalogo(String NombreCatalogoValor, string NombreCatalogo)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.* from StbCatalogo inner join StbCatalogoValor" +
                " on StbCatalogo.ID= StbCatalogoValor.objCatalogoID where StbCatalogo.Codigo='" + NombreCatalogo + "' " +
                " and StbCatalogoValor.Codigo='" + NombreCatalogoValor + "' order by StbCatalogoValor.Valor ", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        // Sucursales
        public DataTable CatalogoValorXCatalogoSucursales(String NombreCatalogoValor, string NombreCatalogo)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion3);
            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.* from StbCatalogo inner join StbCatalogoValor" +
                " on StbCatalogo.ID= StbCatalogoValor.objCatalogoID where StbCatalogo.Codigo='" + NombreCatalogo + "' " +
                " and StbCatalogoValor.Codigo='" + NombreCatalogoValor + "' order by StbCatalogoValor.Valor ", Conne);
            result.Fill(tabla);
            Conne.Close();
            return tabla;
        }

        //Retorna un catalogo valor determinado de determinado catalogo
        public DataTable CatalogoValorXCatalogoBASEMATRIZ(String NombreCatalogoValor, string NombreCatalogo)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla.Clear();
            tabla2.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter siglamatriz = new SqlDataAdapter("SELECT TOP 1 NombreDB FROM StbSucursal WHERE Siglas = (SELECT Valor FROM StbParametro WHERE Nombre = 'NOMBRESIGLAMATRIZ')", Conne);
            siglamatriz.Fill(tabla2);
            siglamatriz.Dispose();
            string nombresiglamatriz = tabla2.Rows[0][0].ToString();

            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.* from " + nombresiglamatriz + ".dbo.StbCatalogo inner join " + nombresiglamatriz + ".dbo.StbCatalogoValor" +
                " on StbCatalogo.ID= StbCatalogoValor.objCatalogoID where StbCatalogo.Codigo='" + NombreCatalogo + "' " +
                " and StbCatalogoValor.Codigo='" + NombreCatalogoValor + "' order by StbCatalogoValor.Valor ", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public int IDCatalogoValorXCatalogoBASEMATRIZ(String NombreCatalogoValor, string NombreCatalogo)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla.Clear();
            tabla2.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter siglamatriz = new SqlDataAdapter("SELECT TOP 1 NombreDB FROM StbSucursal WHERE Siglas = (SELECT Valor FROM StbParametro WHERE Nombre = 'NOMBRESIGLAMATRIZ')", Conne);
            siglamatriz.Fill(tabla2);
            siglamatriz.Dispose();
            string nombresiglamatriz = tabla2.Rows[0][0].ToString();

            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.ID from " + nombresiglamatriz + ".dbo.StbCatalogo inner join " + nombresiglamatriz + ".dbo.StbCatalogoValor" +
                " on StbCatalogo.ID= StbCatalogoValor.objCatalogoID where StbCatalogo.Codigo='" + NombreCatalogo + "' " +
                " and StbCatalogoValor.Codigo='" + NombreCatalogoValor + "' order by StbCatalogoValor.Valor ", Conne);
            result.Fill(tabla);
            int ID = Convert.ToInt32(tabla.Rows[0][0]);

            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return ID;
        }

        public DataTable CatalogoXId(int id)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.* from StbCatalogoValor where StbCatalogoValor.ID = " + id + " ", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable FFinanciamientoXid(String id)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select * from ScrFuenteFinanciamiento where id=" + id, Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable VerificaCaja()
        {
            ClsConexion con = new ClsConexion();
            ClsVariablesGoblales globales = new ClsVariablesGoblales();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select * from ScrCaja inner join SegUsuario on ScrCaja.objEmpleadoID=SegUsuario.objEmpleadoId where ScrCaja.Activo=1 and SegUsuario.Login='" + globales.RetornaLogin() + "'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        //Retorna Productos por pantalla
        public DataTable ProductosXPantalla(string Pantalla)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select ScrProducto.ID,ScrProducto.Nombre as Producto,StbCatalogoValor.Valor as Pantalla from StbCatalogoValor inner join ScrProductoPantalla on StbCatalogoValor.ID=ScrProductoPantalla.ObjPantallaId inner join ScrProducto on ScrProducto.ID=ScrProductoPantalla.ObjProductoId where StbCatalogoValor.Codigo='" + Pantalla + "' order by ScrProducto.Nombre asc", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public string SucursalConectada()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("SELECT TOP 1 NombreDB FROM StbSucursal WHERE Estado = 1", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla.Rows[0][0].ToString();
        }

        //Retorna un catalogo valor determinado de determinado catalogo
        public DataTable CatalogoValorXCatalogo2(String NombreCatalogoValor, string NombreCatalogo)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.* from StbCatalogo inner join StbCatalogoValor" +
                " on StbCatalogo.ID= StbCatalogoValor.objCatalogoID where StbCatalogo.Codigo='" + NombreCatalogo + "' " +
                " and StbCatalogoValor.Codigo='" + NombreCatalogoValor + "'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }
        
        

        //Reterna un numero mostrado en letras
        public string enletras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }
               
            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
                dec = " CON " + decimales.ToString() + "/100";
            res = toText(Convert.ToDouble(entero)) + dec;
            return res;
        }

        //Reterna un numero mostrado en letras
        public string enletras2(string num)
        {

            string res, dec = "";
            string residuo = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
                residuo = toText(Convert.ToDouble(entero)) + dec;
            }
            else if (decimales == 0)
            {
                //dec = decimales.ToString() + " NETOS";
                residuo = toText(Convert.ToDouble(entero)) + " NETOS";
            }
            res = residuo;
            return res;
        }

        //Reterna un numero mostrado en letras
        public string enletras3(string num, string Moneda)
        {
            string res, dec = "";
            string residuo = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
                residuo = toText(Convert.ToDouble(entero)) + dec;
            }
            else if (decimales == 0)
            {
                //dec = decimales.ToString() + " NETOS";
                residuo = toText(Convert.ToDouble(entero)) + " " + Moneda + " NETOS";
            }
            res = residuo;
            return res;
        }

        // Convierte numero el letras
        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }
            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;
        }


        //Retorna valor determinado de determinado Parametro
        public DataTable ValorParametro(String NombreParametro)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro where Nombre='" + NombreParametro + "'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        //Retorna valor determinado de determinado Parametro
        public DataTable ValorParametroOtraSucursal(String NombreParametro)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion3);
            SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro where Nombre='" + NombreParametro + "'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        // Verifica desglose
        public string VerificaDesglose(DataTable GridDesglose, string Moneda, string valordenominacion, string denominacion)
        {
            ClsVariablesGoblales globales = new ClsVariablesGoblales();
            ClsConexion con = new ClsConexion();
            DataTable DesgloseActual = new DataTable();
            DataTable TodoDesglose = new DataTable();
            DesgloseActual.Clear();
            TodoDesglose.Clear();
            int cajaid = 0; 
            SqlConnection Conne = new SqlConnection(con.Conexion);
            //SqlDataAdapter result = new SqlDataAdapter("select ISNULL(Cantidad,0),DenominacionMoneda,TipoMoneda from SvnDesgloseActual inner join ScrCaja on ScrCaja.ID=SvnDesgloseActual.objCajaId inner join SegUsuario on SegUsuario.objEmpleadoId=ScrCaja.objEmpleadoID where SegUsuario.Login='" + globales.RetornaLogin() + "' and tipoMoneda='" + Moneda + "'", Conne);
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT ISNULL(Cantidad,0) AS Cantidad, DenominacionMoneda, TipoMoneda, ObjCajaId, ValorMoneda FROM SvnDesgloseActual INNER JOIN ScrCaja ON ScrCaja.ID = SvnDesgloseActual.objCajaId 
                                                INNER JOIN SegUsuario ON SegUsuario.objEmpleadoId = ScrCaja.objEmpleadoID WHERE SegUsuario.Login = '" + globales.RetornaLogin() + "' AND TipoMoneda = '" + Moneda + "'", Conne);    
            result.Fill(DesgloseActual);
            result.Dispose();
            int filaGridDesg = 0;
            string valor = "";
            if (DesgloseActual.Rows.Count > 0)
            {
                cajaid = int.Parse(DesgloseActual.Rows[0][3].ToString());
                for (int filaDesgActual = 0; filaDesgActual < DesgloseActual.Rows.Count; filaDesgActual++)
                {            
                    for (filaGridDesg = 0; filaGridDesg < GridDesglose.Rows.Count; filaGridDesg++)
                    {
                        if (int.Parse(DesgloseActual.Rows[filaDesgActual]["DenominacionMoneda"].ToString()) == int.Parse(GridDesglose.Rows[filaGridDesg]["ID"].ToString()))
                        {
                            if ((int.Parse(DesgloseActual.Rows[filaDesgActual]["Cantidad"].ToString()) < int.Parse(GridDesglose.Rows[filaGridDesg]["Cantidad"].ToString())))
                            {
                                valor = GridDesglose.Rows[filaGridDesg]["Denominación"].ToString();
                                return valor;
                            }
                        }
                    }            
                 }

                SqlDataAdapter TodoDesgloseActualXDen = new SqlDataAdapter(@"SELECT DISTINCT Denominaciones.Codigo, Denominaciones.Valor AS Denominación, CONVERT(DECIMAL(8,2), (SELECT Valor FROM StbCatalogoValor "
                +"INNER JOIN StbCatalogo ON StbCatalogoValor.objCatalogoID = StbCatalogo.ID WHERE StbCatalogo.Codigo = '"+ valordenominacion +"' AND StbCatalogoValor.Codigo = Denominaciones.Codigo)) "
                +"AS ValorMonetario, 0 AS Cantidad, Denominaciones.ID FROM StbCatalogo "
                +"INNER JOIN StbCatalogoValor AS Denominaciones ON Denominaciones.objCatalogoID = StbCatalogo.ID "
                +"LEFT OUTER JOIN SvnDesgloseActual ON SvnDesgloseActual.DenominacionMoneda = Denominaciones.ID "
                +"WHERE StbCatalogo.Codigo = '"+ denominacion +"' AND "
                +"Denominaciones.ID NOT IN (SELECT DISTINCT SvnDesgloseActual.DenominacionMoneda FROM SvnDesgloseActual WHERE objcajaid = "+ cajaid +" ) "
                +"ORDER BY ValorMonetario DESC", Conne);
                TodoDesgloseActualXDen.Fill(TodoDesglose);
                TodoDesgloseActualXDen.Dispose();

                for (filaGridDesg = 0; filaGridDesg < GridDesglose.Rows.Count; filaGridDesg++)
                {
                    if (int.Parse(GridDesglose.Rows[filaGridDesg]["Cantidad"].ToString()) > 0)
                    {
                        for (int fila = 0; fila < TodoDesglose.Rows.Count; fila++)
                        {
                            if (int.Parse(GridDesglose.Rows[filaGridDesg]["ID"].ToString()) == int.Parse(TodoDesglose.Rows[fila]["ID"].ToString()))
                            {
                                valor = GridDesglose.Rows[filaGridDesg]["Denominación"].ToString();
                                Conne.Close();
                                return valor;
                            }
                        }
                    }
                }
                Conne.Dispose();
                Conne.Close();
                return "";
            }
            else
            {
                for (filaGridDesg = 0; filaGridDesg < GridDesglose.Rows.Count; filaGridDesg++)
                {
                    if (int.Parse(GridDesglose.Rows[filaGridDesg]["Cantidad"].ToString()) > 0)
                    {
                        valor = GridDesglose.Rows[filaGridDesg]["Denominación"].ToString();
                        Conne.Dispose();
                        Conne.Close();
                        return valor;
                    }
                }
                Conne.Dispose();
                Conne.Close();
                return "";
            }            
        }


        public void guardarValorConfiguracion(string clave, string valor)
        {
            try
            {
                ExeConfigurationFileMap Archivo = new ExeConfigurationFileMap();
                Archivo.ExeConfigFilename = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
                string directorioActual = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
                //directorioActual = "C:\\Users\\Usuario\\Desktop\\Fuente MC\\MiCredito";
                string pathFichero = directorioActual + "\\MiCredito.exe.config";
                Archivo.ExeConfigFilename = pathFichero;
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(Archivo, ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
                //Elimina la el nodo en la clave 
                configuration.AppSettings.Settings.Remove(clave);
                ClsEncripta encripta = new ClsEncripta();
                //Agrega el nodo con la misma clave y el nuevo valor.
                configuration.AppSettings.Settings.Add(clave, encripta.Encriptar(valor));
                //Salva los cambios
                configuration.Save(ConfigurationSaveMode.Full);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar valor de configuración: " +
                     System.Environment.NewLine + System.Environment.NewLine +
                     ex.GetType().ToString() + System.Environment.NewLine +
                     ex.Message, "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*---------------------------------------------------------------------------------------------------------------------------*/
       //--------------------------------------Funciones creadas por: Joseline Silva------------------------------//
        public DataTable PaisNombre(string id)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select * from StbUbicacionGeografica where ID=" + id, Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public void CargarCombobox(ComboBox cbo, DataTable dt)
        {
            cbo.DataSource = dt.DefaultView;
            cbo.DisplayMember = "Codigo";
            cbo.ValueMember = "ID";
        }

        public DataTable CargaProducto()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select ID,Nombre as Codigo from ScrProducto where Activo=1", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable Promotor()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select ID,Nombre as Codigo from SrhPromotor where Activo=1", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable Combos(String valor)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.ID,StbCatalogoValor.Valor as Codigo from StbCatalogoValor inner join StbCatalogo on StbCatalogoValor.objCatalogoID=StbCatalogo.ID where StbCatalogo.Codigo='" + valor + "' and Activo=1 ORDER BY StbCatalogoValor.VALOR ASC", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public String Nombrelugar(int id)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Nombre from StbUbicacionGeografica where ID=" + id, Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();

            String Nombre = tabla.Rows[0][0].ToString();
            return Nombre;
        }

        public int idlugar(int id)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select objUbicacionGeograficaAnteriorID from StbUbicacionGeografica where ID=" + id, Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();

            int lugar = Convert.ToInt32(tabla.Rows[0][0]);
            return lugar;
        }

        public DataTable Suc()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select ID,Nombre as Codigo from StbSucursal", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable Sucursalinicial(String siglas)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select ID,Nombre as Codigo from StbSucursal where Siglas='" + siglas + "'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable SucursalActiva()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select distinct * from StbSucursal where Estado = 1", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DateTime FechaOperacion()
        {            
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Valor from stbparametro where Nombre='FECHAOPERACION'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();

            DateTime fecha = Convert.ToDateTime(tabla.Rows[0][0]);
            return fecha;
        }

        //----Metodo que busca existencia del nombre de la persona en las listas negras de la empresa
        public DataTable ListasNegras(string Nombre, string Cedula)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            DataTable tabla2 = new DataTable();
            tabla2.Clear();
            SqlDataAdapter NombreDB = new SqlDataAdapter("SELECT TOP 1 NombreDB FROM StbSucursal WHERE Siglas = (SELECT Valor FROM StbParametro WHERE Nombre = 'NOMBRESIGLAMATRIZ')", Conne);
            NombreDB.Fill(tabla2);
            string nombresiglamatriz = tabla2.Rows[0][0].ToString();
            SqlDataAdapter result = new SqlDataAdapter(@"select * from (select (isnull(Nombre1,'')+' '+isnull(Nombre2,'')+' '+ isnull(Nombre3,'')+' '+isnull(Nombre4,'')+' '
            +isnull(Nombre5,'')+' '+isnull(Nombre6,'')+' '+isnull(Nombre7,'')+' '+isnull(Nombre8,'')) as Nombre, ScrListaNegraDetalle.Aka,ScrListaNegraDetalle.Aka2, 
            ScrListaNegraDetalle.FechaNacimiento,ScrListaNegraDetalle.Identificacion,ScrListaNegraDetalle.Nacionalidad,ScrListaNegraDetalle.Pasaporte,ScrListaNegraDetalle.Origen "

            + " from "+ nombresiglamatriz + ".dbo.ScrListaNegra "
            + " inner join " + nombresiglamatriz + ".dbo.ScrListaNegraDetalle on ScrListaNegra.ID = ScrListaNegraDetalle.objListaNegraID) as lista "

            + " where Nombre like '%" + Nombre + "%' or lista.Aka = '" + Nombre + "' or lista.Aka2 = '" + Nombre + "' or lista.Identificacion = '" + Cedula + "'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable ActividadesXSector(int IDSector)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("SELECT IDActividad, CodigoActividad, ValorActividad, IDSector, CodigoSector FROM Vw_Stb_ActividadesXSector WHERE IDSector = " + IDSector + "", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable RubroActXActividad(int idcatalogovalor)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT IDActividad, CodigoActividad, ValorActividad, IDSector, CodigoSector FROM Vw_Stb_ActividadesXSector 
            WHERE TipoActividad = (SELECT CodigoCatalogoValor FROM vw_Stb_CatalogoParametro WHERE IDCatalogoValor =" + idcatalogovalor + ")", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable ActividadesPredominantes(int idcatalogovalor, int idcatalogovalor2, int idcatalogovalor3)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT IDActividad, CodigoActividad, ValorActividad, IDSector, CodigoSector FROM Vw_Stb_ActividadesXSector 
            WHERE IDActividad IN (" + idcatalogovalor + "," + idcatalogovalor2 + "," + idcatalogovalor3 + ") ORDER BY ValorActividad ASC ", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

//        public Boolean ExisteListaNegraXNombre(String solicitante)
//        {
//            ClsConexion con = new ClsConexion();
//            using (SqlConnection conexion = new SqlConnection(con.Conexion))
//            {
//                string query = string.Format(@"select count(Nombre1) from (select Nombre1,Nombre2,Nombre3,Nombre4,Nombre5,Nombre6,Nombre7,Nombre8,ScrListaNegraDetalle.Aka,ScrListaNegraDetalle.Aka2 from ScrListaNegra inner join ScrListaNegraDetalle on ScrListaNegra.ID=ScrListaNegraDetalle.objListaNegraID) as lista
//                      where (lista.Nombre1 + ' ' + CASE WHEN lista.Nombre2 IS NULL 
//                      THEN '' ELSE lista.Nombre2 END + ' ' + CASE WHEN lista.Nombre3 IS NULL THEN '' ELSE lista.Nombre3 END + ' ' + CASE WHEN lista.Nombre4 IS NULL 
//                      THEN '' ELSE lista.Nombre4 END + ' ' + CASE WHEN lista.Nombre5 IS NULL THEN '' ELSE lista.Nombre5 END + ' ' + CASE WHEN lista.Nombre6 IS NULL 
//                      THEN '' ELSE lista.Nombre6 END + ' ' + CASE WHEN lista.Nombre7 IS NULL THEN '' ELSE lista.Nombre7 END + ' ' + CASE WHEN lista.Nombre8 IS NULL 
//                      THEN '' ELSE lista.Nombre8 END )like '%" + solicitante + "%' or  (lista.Nombre8 + ' ' + CASE WHEN lista.Nombre7 IS NULL " +
//                      "THEN '' ELSE lista.Nombre7 END + ' ' + CASE WHEN lista.Nombre6 IS NULL THEN '' ELSE lista.Nombre6 END + ' ' + CASE WHEN lista.Nombre5 IS NULL " +
//                      "THEN '' ELSE lista.Nombre5 END + ' ' + CASE WHEN lista.Nombre4 IS NULL THEN '' ELSE lista.Nombre4 END + ' ' + CASE WHEN lista.Nombre3 IS NULL " +
//                      "THEN '' ELSE lista.Nombre3 END + ' ' + CASE WHEN lista.Nombre2 IS NULL THEN '' ELSE lista.Nombre2 END + ' ' + CASE WHEN lista.Nombre1 IS NULL " +
//                      "THEN '' ELSE lista.Nombre1 END ) like '%" + solicitante + "%' or lista.Aka ='" + solicitante + "' or lista.Aka2 = '" + solicitante + "'");
//                using (SqlCommand comando = new SqlCommand(query, conexion))
//                {
//                    conexion.Open();
//                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
//                        return true;
//                }
//            }
//            return false;
//        }

//        //----Metodo que busca existencia de la cedula de la persona en las listas negras de la empresa
//        public bool ExisteListaNegraXCedula(String cedula)
//        {
//            ClsConexion con = new ClsConexion();
//            using (SqlConnection conexion = new SqlConnection(con.Conexion))
//            {
//                string query = string.Format(@"select count(ScrListaNegraDetalle.Identificacion) from ScrListaNegra inner join ScrListaNegraDetalle on ScrListaNegra.ID=ScrListaNegraDetalle.objListaNegraID where ScrListaNegraDetalle.Identificacion like '%" + cedula + "%'");
//                using (SqlCommand comando = new SqlCommand(query, conexion))
//                {
//                    conexion.Open();
//                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
//                        return true;
//                }
//            }
//            return false;
//        }


        public int CerosRellenoSolicitud()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro where Nombre='CEROSRELLENOSOLICITUDCREDITO'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();

            int cero = Convert.ToInt32(tabla.Rows[0][0]);
            return cero;
        }

        //----Metodo que busca existencia del nombre de la persona en las lista gris de la empresa
        public bool ExisteListaGrisXNombre(String solicitante)
        {
            ClsConexion con = new ClsConexion();
            using (SqlConnection conexion = new SqlConnection(con.Conexion))
            {
                string query = string.Format(@"select COUNT(Nombre1) from (select Nombre1,Nombre2,Apellido1,Apellido2 from ScrListaGris) as lista
                                             where (lista.Nombre1 + ' ' + CASE WHEN lista.Nombre2 IS NULL 
                                             THEN '' ELSE lista.Nombre2 END + ' ' + CASE WHEN lista.Apellido1 IS NULL THEN '' ELSE lista.Apellido1 END 
                                             + ' ' + CASE WHEN lista.Apellido2 IS NULL THEN '' ELSE lista.Apellido2 END)='" + solicitante + "'");
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)                        
                        return true;
                }
                conexion.Dispose();
                conexion.Close();
            }
            return false;
        }

        //----Metodo que busca existencia de la cedula de la persona en las lista gris de la empresa
        public bool ExisteListaGrisXCedula(String cedula)
        {
            ClsConexion con = new ClsConexion();
            using (SqlConnection conexion = new SqlConnection(con.Conexion))
            {
                string query = string.Format(@" select count(Cedula) from ScrListaGris where Cedula like '%" + cedula + "%'");
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                    {
                        conexion.Dispose();
                        conexion.Close();
                        return true;
                    }
                }
            }
            return false;
        }

        //----Metodo que busca existencia del nombre de la persona en la lista de cliente de la empresa
        public bool ExisteListaClienteXNombre(String solicitante)
        {
            ClsConexion con = new ClsConexion();
            using (SqlConnection conexion = new SqlConnection(con.Conexion))
            {
                string query = string.Format(@"select COUNT(Nombre1) from (select Nombre1,Nombre2,Apellido1,Apellido2 from ScrListaClientes) as lista
                                             where (lista.Nombre1 + ' ' + CASE WHEN lista.Nombre2 IS NULL 
                                             THEN '' ELSE lista.Nombre2 END + ' ' + CASE WHEN lista.Apellido1 IS NULL THEN '' ELSE lista.Apellido1 END 
                                             + ' ' + CASE WHEN lista.Apellido2 IS NULL THEN '' ELSE lista.Apellido2 END)='" + solicitante + "'");
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                    {
                        conexion.Dispose();
                        conexion.Close();
                        return true;
                    }
                }
            }
            return false;
        }

        //----Metodo que busca existencia de la cedula de la persona en la lista de cliente de la empresa
        public bool ExisteListaClienteXCedula(String cedula)
        {
            ClsConexion con = new ClsConexion();
            using (SqlConnection conexion = new SqlConnection(con.Conexion))
            {
                string query = string.Format(@" select count(Cedula) from ScrListaClientes where Cedula like '%" + cedula + "%'");
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                    {
                        conexion.Dispose();
                        conexion.Close();
                        return true;
                    }
                }
            }
            return false;
        }

        public int OrigenInicio(String valor)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select StbCatalogoValor.ID from StbCatalogoValor inner join StbCatalogo on StbCatalogoValor.objCatalogoID=StbCatalogo.ID where StbCatalogoValor.Codigo='" + valor + "'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();

            int origen = Convert.ToInt32(tabla.Rows[0][0]);
            return origen;
        }
        //-----------------------------------------------------------------------------------------------------
        //--------------------------------------Funciones creadas por: Osmar Vindel------------------------------//

        //Reterna el numero del meses en letras
        public string mesesletras(string num)
        {

            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;
            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }
            res = toTextmes(Convert.ToDouble(entero)) + dec;
            return res;
        }

        //Reterna las letras del numero del mes 
        public string toTextmes(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 1) Num2Text = "ENERO";
            else if (value == 2) Num2Text = "FEBRERO";
            else if (value == 3) Num2Text = "MARZO";
            else if (value == 4) Num2Text = "ABRIL";
            else if (value == 5) Num2Text = "MAYO";
            else if (value == 6) Num2Text = "JUNIO";
            else if (value == 7) Num2Text = "JULIO";
            else if (value == 8) Num2Text = "AGOSTO";
            else if (value == 9) Num2Text = "SEPTIEMBRE";
            else if (value == 10) Num2Text = "OCTUBRE";
            else if (value == 11) Num2Text = "NOVIEMBRE";
            else if (value == 12) Num2Text = "DICIEMBRE";
            return Num2Text;
        }

        //Reterna el numero del mes en letras
        public string MesNumero(string value)
        {
            string NumText = "";

            if (value == "ENERO") NumText = "1";

            else if (value == "FEBRERO") NumText = "2";
            else if (value == "MARZO") NumText = "3";
            else if (value == "ABRIL") NumText = "4";
            else if (value == "MAYO") NumText = "5";
            else if (value == "JUNIO") NumText = "6";
            else if (value == "JULIO") NumText = "7";
            else if (value == "AGOSTO") NumText = "8";
            else if (value == "SEPTIEMBRE") NumText = "9";
            else if (value == "OCTUBRE") NumText = "10";
            else if (value == "NOVIEMBRE") NumText = "11";
            else if (value == "DICIEMBRE") NumText = "12";

            return NumText;
        }

        //Carga los ceros de rellono de las presolicitudes
        public int CerosRellenoPreSolicitud()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro where Nombre='CEROSRELLENOSPRESOLICITUDCREDITO'", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            int cero = Convert.ToInt32(tabla.Rows[0][0]);
            return cero;
        }

        public string NombreBDConectado()//Danilo - Obtener el nombre de la DB conectado
        {
            string NombreBD = string.Empty;
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("SELECT DB_NAME() AS [Current Database]", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            NombreBD = tabla.Rows[0][0].ToString();
            return NombreBD;
        }

        public String NombreBDCasaMatriz() // Ricardo, devuelve el nombre de la base datos de casa matriz
        {
            string NombreBD = "";
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT TOP 1 NombreDB FROM StbSucursal WHERE Siglas = (SELECT Valor FROM StbParametro WHERE Nombre = 'NOMBRESIGLAMATRIZ')", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            NombreBD = tabla.Rows[0][0].ToString();
            return NombreBD;
        }

        public String NombreSucCasaMatriz() // Ricardo, devuelve el nombre de la sucursal de casa matriz
        {
            string NombreSuc = "";
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT TOP 1 Nombre FROM StbSucursal WHERE Siglas = (SELECT Valor FROM StbParametro WHERE Nombre = 'NOMBRESIGLAMATRIZ')", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            NombreSuc = tabla.Rows[0][0].ToString();
            return NombreSuc;
        }

        public string ValorParametroString(String NombreParametro)
        {
            string valorparametro = "";
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro where Nombre='" + NombreParametro + "'", Conne);
            result.Fill(tabla);
            valorparametro = tabla.Rows[0][0].ToString();
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return valorparametro;
        }

        public bool ObtenerPagosElectronicosMonedaBase(string Login, DateTime fecha)
        {
            return true;
            //int RecuperacionesPendientes = 0;
            //ClsConexion con = new ClsConexion();
            //DataTable tabla = new DataTable();
            //SqlConnection Conne = new SqlConnection(con.Conexion);
            //SqlDataAdapter result = new SqlDataAdapter("select Valor from StbParametro where Nombre='" + NombreParametro + "'", Conne);
            //result.Fill(tabla);
            //valorparametro = tabla.Rows[0][0].ToString();
            //return valorparametro;
        }
    }
}
