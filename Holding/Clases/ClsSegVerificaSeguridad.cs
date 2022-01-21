using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

/*Realizado por Rene Jarquin
 * Fecha        10/04/2014
 * Descripción: Clase objeto para la verificación de los permisos de acceso por usuario a los diferentes formularios del sistema.
 */


namespace Holding
{
    class ClsVerificaSeguridad
    {
        //FUNCION Q VERIFICA SI EL USUARIO Q ESTA EJECUTANDO LA APLICACIONES TIENE DETERMINADO PERMISO
        public bool VerificaSeguridad(string Permiso)
        {
            ClsVariablesGoblales Global= new ClsVariablesGoblales();
            bool TienePermiso = false;
            LlenaTabla Acciones = new LlenaTabla();
            DataTable AccionesXLogin = new DataTable();
            AccionesXLogin = Acciones.Llenartabla("SELECT CODIGO FROM dbo.vw_Seg_AccionesxLogin WHERE LOGIN ='" + Global.RetornaLogin() + "'");
            
            //i sera la variable que determine el registro que se va recorriendo
            for (int i = 0; i < AccionesXLogin.Rows.Count; i++)
            {
                if (Permiso == AccionesXLogin.Rows[i][0].ToString())
                {
                    TienePermiso= true;
                    return TienePermiso;
                  
                }
                
            }

            return TienePermiso;
        }
    }
}
