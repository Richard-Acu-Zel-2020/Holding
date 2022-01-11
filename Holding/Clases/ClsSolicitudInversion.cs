using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsSolicitudInversion
    {
        public DataTable SolicitudInversion()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter();
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

    }
}
