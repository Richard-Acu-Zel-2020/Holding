using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Realizado por Rene Jarquin
 * Fecha        14/04/2014
 */

namespace Holding
{
    class ClsVariablesGoblales
    {
        public static string _Login = "";
        public static string _IP = "";
        public static int _IdUsuario = 0;

        public static string _SiglaPais = "";

        public static string _TextoMonedaPrincipal = "";    // Moneda de desembolsos
        public static string _TextoMonedaSecundaria = "";    // Moneda contable
        public static string _SimboloMonedaPrincipal = "";    // Moneda de desembolsos
        public static string _SimboloMonedaSecundaria = "";    // Moneda contable

        public static string _UsuarioSistema = "";              // Usuario de dominio active directory que utiliza el sistema para conectarse al servidor
        public static string _UsuarioOriginal = "";

        public static int _ContadorTiempo = 0;

        public string MsgRegistroExitosoInserta = "El registro se ha guardado exitosamente!";
        public string MsgRegistroExitosoActualiza = "El registro se ha actualizado exitosamente!";
        public string MsgRegistroExitosoElimina = "El registro se ha eliminado exitosamente!";
        public string MsgError = "Ha ocurrido un error, favor notificarlo al área de informática.";
        public string MsgErrorFinal = "Error al realizar la transacción.";
        public string MsgErrorBitacora = "Ocurrió un error al guardar la bitácora, favor notificar al área de informática.";
        public string MsgNoTienePermiso = "Usted no tiene permiso para realizar esta acción, consulte con su jefe superior.";
        public string MsgCancelar = "¿Está seguro que desea cancelar la transacción?";
        public string MsgRegistroEliminar = "¿Está seguro que desea eliminar el registro actual?";
        public string MsgErrorValidarDatos = "Ha ocurrido un error, favor revisar los datos ingresados.";
             
        //FUNCION Q DEFINE EL LOGIN Y EL IP DEL USUARIO QUE EJECUTA LA APLICACION
        public void accesarVariable(String Login, String Ip, int IdUsuario, string SiglaPais)
        {
            ClsVariablesGoblales._Login = Login;
            ClsVariablesGoblales._IP = Ip;
            ClsVariablesGoblales._IdUsuario = IdUsuario;

            ClsVariablesGoblales._SiglaPais = SiglaPais;
        }

        //FUNCION que llena las monedas para el sistema
        public void LlenaMonedas(String TextoMonedaPrincipal, String TextoMonedaSecundaria, String SimboloMonedaPrincipal, String SimboloMonedaSecundaria)
        {
            ClsVariablesGoblales._TextoMonedaPrincipal = TextoMonedaPrincipal;
            ClsVariablesGoblales._TextoMonedaSecundaria = TextoMonedaSecundaria;
            ClsVariablesGoblales._SimboloMonedaPrincipal = SimboloMonedaPrincipal;
            ClsVariablesGoblales._SimboloMonedaSecundaria = SimboloMonedaSecundaria;
        }

        public void AsignaContadorTiempo(int Contador)
        {
            ClsVariablesGoblales._ContadorTiempo = Contador;
        }

        public void NuevoUsuarioSistema(string user)
        {
            _UsuarioSistema = user;
        }

        public void NuevoUsuarioOriginal(string userOrig)
        {
            _UsuarioOriginal = userOrig;
        }

        //Retorna el login del usuario que esta ejecutando
        public string RetornaLogin()
        {
            return _Login;
        }

        //Retorna el IP del usuario que esta ejecutando
        public string RetornaIP()
        {
            return _IP;
        }

        //Retorna el ID del usuario que se esta ejecutando
        public int RetornaIdUsuario()
        {
            return _IdUsuario;
        }

        //Retorna el texto de la moneda principal
        public string RetornaTextoMonedaPrincipal()
        {
            return _TextoMonedaPrincipal;
        }

        //Retorna el texto de la moneda secundaria
        public string RetornaTextoMonedaSecundaria()
        {
            return _TextoMonedaSecundaria;
        }

        //Retorna el simbolo de la moneda principal
        public string RetornaSimboloMonedaPrincipal()
        {
            return _SimboloMonedaPrincipal;
        }

        //Retorna el simbolo de la moneda secundaria
        public string RetornaSimboloMonedaSecundaria()
        {
            return _SimboloMonedaSecundaria;
        }  

        public string SiglaPais()
        {
            return _SiglaPais;
        }

        // Retorna la variable que controla el tiempo de actividad del sistema
        public int ContadorTiempo()
        {
            return _ContadorTiempo;
        }

        public void ReiniciaContadorTiempo()
        {
            //Reinicia el tiempo de actividad
            AsignaContadorTiempo(0);
        }

        public string UsuarioSistema()
        {
            return _UsuarioSistema;
        }

        public string UsuarioOriginal()
        {
            return _UsuarioOriginal;
        }

    }
}
