using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Holding
{
    class LlenaTabla
    {
        //funcion que retorna datatable en dependecia de la consulta que se le pasa
        public DataTable Llenartabla(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla.Clear();
                ClsConexion con = new ClsConexion();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                SqlDataAdapter result = new SqlDataAdapter(consulta, Conne);
                result.SelectCommand.CommandTimeout = 3000;
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }
            catch (Exception IO)
            {
                FrmError frmError = new FrmError("Ha ocurrido un error, favor notificarlo al área de informática", IO.ToString(), "Error al realizar la transacción");
                frmError.ShowDialog();
                return tabla;
            }
        }

        public DataTable LlenartablaOtraSucursal(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla.Clear();
                ClsConexion con = new ClsConexion();
                SqlConnection Conne = new SqlConnection(con.Conexion3);
                SqlDataAdapter result = new SqlDataAdapter(consulta, Conne);
                result.SelectCommand.CommandTimeout = 3000;
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }
            catch (Exception IO)
            {
                FrmError frmError = new FrmError("Ha ocurrido un error, favor notificarlo al área de informática", IO.ToString(), "Error al realizar la transacción");
                frmError.ShowDialog();
                return tabla;
            }
        }
    }
}
