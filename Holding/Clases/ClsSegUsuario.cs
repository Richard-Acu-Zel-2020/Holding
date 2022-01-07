using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsSegUsuario
    {
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        int _IdUsuario = 0;
        String _PrimerNombre = "";
        String _SegundoNombre = "";
        String _PrimerApellido = "";
        String _SegundoApellido = "";
        String _Cedula = "";
        String _Login = "";
        String _Clave = "";
        int _Activo = 0;
        int _IdRol = 0;
        String _UsuarioCreacion = "";
        DateTime _FechaCreacion;
        String _MaquinaCreacion = "";
        String _UsuarioModificacion = "";
        DateTime _FechaModificacion;
        String _MaquinaModificacion = "";
        int _objEmpleadoId=0;
        DateTime _fechaActualizaClave;
        DateTime? _fechaInactivaCuenta;

        String _CorreoLaboral = "";
        String _ClaveEncriptada = "";

        #region"Constructores"
            public ClsSegUsuario() { }

            public ClsSegUsuario(int IdUsuario,String PrimerNombre, String SegundoNombre, String PrimerApellido, String SegundoApellido, String Cedula,String Login,String Clave,int Activo,
                String UsuarioCreacion,DateTime FechaCreacion, String MaquinaCreacion,String Usuariomodificacion,
                DateTime FechaModificacion,String MaquinaModificacion,int IdRol,DateTime FechaActualizaClave,
                DateTime? FechainactivaCuenta,int ObjEmpleadoId, String CorreoLaboral, String ClaveEncriptada)
            {
                IdUsuario = _IdUsuario;
                PrimerNombre = _PrimerNombre;
                SegundoNombre = _SegundoNombre;
                PrimerApellido = _PrimerApellido;
                SegundoApellido = _SegundoApellido;
                Cedula = _Cedula;
                Login = _Login;
                Clave = _Clave;
                Activo = _Activo;
                IdRol = _IdRol;
                UsuarioCreacion = _UsuarioCreacion;
                FechaCreacion = _FechaCreacion;
                MaquinaCreacion = _MaquinaCreacion;
                Usuariomodificacion = _UsuarioModificacion;
                FechaModificacion = _FechaModificacion;
                MaquinaModificacion = _MaquinaModificacion;
                FechaActualizaClave = _fechaActualizaClave;
                FechainactivaCuenta = _fechaInactivaCuenta;
                ObjEmpleadoId = _objEmpleadoId;

                CorreoLaboral = _CorreoLaboral;
                ClaveEncriptada = _ClaveEncriptada;
            }
        #endregion

        #region"Properties"

            public int Idusuario
            {

                get { return _IdUsuario; }
                set { _IdUsuario = value; }
            }

            public int ObjEmpleadoId
            {

                get { return _objEmpleadoId; }
                set { _objEmpleadoId = value;}
            }

            public String PrimerNombre
            {

                get { return _PrimerNombre; }
                set { _PrimerNombre = value; }
            }

            public String SegundoNombre
            {

            get { return _SegundoNombre; }
            set { _SegundoNombre = value; }
            }

            public String PrimerApellido
            {

            get { return _PrimerApellido; }
            set { _PrimerApellido = value; }
            }

            public String SegundoApellido
            {

            get { return _SegundoApellido; }
            set { _SegundoApellido = value; }
            }

            public String Cedula
            {

            get { return _Cedula; }
            set { _Cedula = value; }
            }


            public String Login
            {

                get { return _Login; }
                set { _Login = value; }
            }

            public String Clave
            {

                get { return _Clave; }
                set { _Clave = value; }
            }

            public int  Activo
            {

                get { return _Activo; }
                set { _Activo = value; }
            }

            public int IdRol
            {

                get { return _IdRol; }
                set { _IdRol = value; }
            }
            public String UsuarioCreacion
            {

                get { return _UsuarioCreacion; }
                set { _UsuarioCreacion= value; }
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
                set { _UsuarioModificacion= value; }
            }

            public DateTime FechaModificacion
            {

                get { return _FechaModificacion; }
                set { _FechaModificacion= value; }
            }

            public String MaquinaModificacion
            {

                get { return _MaquinaModificacion; }
                set { _MaquinaModificacion = value; }
            }

            public DateTime FechaActualizaClave
            {

                get { return _fechaActualizaClave; }
                set { _fechaActualizaClave = value; }
            }

            public DateTime? FechaInactivaCuenta
            {

                get { return _fechaInactivaCuenta; }
                set { _fechaInactivaCuenta = value; }
            }

            public String CorreoLaboral
            {
                get { return _CorreoLaboral; }
                set { _CorreoLaboral = value; } 
            }

            public String ClaveEncriptada
            {
                get { return _ClaveEncriptada; }
                set { _ClaveEncriptada = value; }
            }

        #endregion

        #region "Guarda Usuario"
        //Ejecuta el procedimiento almacenado para guardar usuario.
        public bool GuardaUsuario()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_Usuarios_Ingresa");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

                SqlParameter prmIdUsu = new SqlParameter("@ID", SqlDbType.Int);
                prmIdUsu.Value = _IdUsuario;
                Com.Parameters.Add(prmIdUsu);

                SqlParameter prmPrimerNombre = new SqlParameter("@PrimerNombre", SqlDbType.VarChar);
                prmPrimerNombre.Value = _PrimerNombre;
                Com.Parameters.Add(prmPrimerNombre);

                SqlParameter prmSegundoNombre = new SqlParameter("@SegundoNombre", SqlDbType.VarChar);
                prmSegundoNombre.Value = _SegundoNombre;
                Com.Parameters.Add(prmSegundoNombre);

                SqlParameter prmPrimerApellido = new SqlParameter("@PrimerApellido", SqlDbType.VarChar);
                prmPrimerApellido.Value = _PrimerApellido;
                Com.Parameters.Add(prmPrimerApellido);

                SqlParameter prmSegundoApellido = new SqlParameter("@SegundoApellido", SqlDbType.VarChar);
                prmSegundoApellido.Value = _SegundoApellido;
                Com.Parameters.Add(prmSegundoApellido);

                SqlParameter prmCedula = new SqlParameter("@Cedula", SqlDbType.NVarChar);
                prmCedula.Value = _Cedula;
                Com.Parameters.Add(prmCedula);

                SqlParameter prmEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                prmEmail.Value = _CorreoLaboral;
                Com.Parameters.Add(prmEmail);

                SqlParameter prmLogin = new SqlParameter("@Login", SqlDbType.VarChar);
                prmLogin.Value = _Login;
                Com.Parameters.Add(prmLogin);

                SqlParameter prmClave = new SqlParameter("@Password", SqlDbType.VarChar);
                prmClave.Value = _Clave;
                Com.Parameters.Add(prmClave);

                SqlParameter prmActivo = new SqlParameter("@Activo", SqlDbType.Int);
                prmActivo.Value = _Activo;
                Com.Parameters.Add(prmActivo);

                SqlParameter prmRolId = new SqlParameter("@objRolID", SqlDbType.Int);
                prmRolId.Value = _IdRol;
                Com.Parameters.Add(prmRolId);

                SqlParameter prmempleadoId = new SqlParameter("@objEmpleadoID", SqlDbType.Int);
                if (_objEmpleadoId != 0)
                {
                    prmempleadoId.Value = _objEmpleadoId;
                }
                else
                {
                    prmempleadoId.Value = DBNull.Value ;
                }
                Com.Parameters.Add(prmempleadoId);

                SqlParameter prmFechaActualizaPass = new SqlParameter("@FechaActualizaContrasena", SqlDbType.DateTime);
                prmFechaActualizaPass.Value = DateTime.Now;
                Com.Parameters.Add(prmFechaActualizaPass);

                SqlParameter prmFechaInactivaCuenta = new SqlParameter("@FechaInactivaCuenta", SqlDbType.DateTime);
                prmFechaInactivaCuenta.Value = _fechaInactivaCuenta;
                Com.Parameters.Add(prmFechaInactivaCuenta);

                SqlParameter prmUsuarioCrea= new SqlParameter("@UsuarioCreacion", SqlDbType.VarChar);
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

        #region "Modifica Usuario"
            //Ejecuta el procedimiento almacenado para Modificar usuario.
            public bool ModificaUsuario()
            {
                ClsConexion conne = new ClsConexion();
                SqlConnection conex = new SqlConnection(conne.Conexion);
                conex.Open();
                SqlCommand Com = new SqlCommand("Spd_Seg_Usuarios_Modifica");
                Com.Connection = conex;
                Com.CommandType = CommandType.StoredProcedure;

               
                    SqlParameter prmIdUsu = new SqlParameter("@ID", SqlDbType.Int);
                    prmIdUsu.Value = _IdUsuario;
                    Com.Parameters.Add(prmIdUsu);

                    SqlParameter prmEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                    prmEmail.Value = _CorreoLaboral;
                    Com.Parameters.Add(prmEmail);

                    SqlParameter prmClave = new SqlParameter("@Password", SqlDbType.VarChar);
                    prmClave.Value = _Clave;
                    Com.Parameters.Add(prmClave);

                    SqlParameter prmActivo = new SqlParameter("@Activo", SqlDbType.Int);
                    prmActivo.Value = _Activo;
                    Com.Parameters.Add(prmActivo);

                    SqlParameter prmFechaInactivaCuenta = new SqlParameter("@FechaInactivaCuenta", SqlDbType.DateTime);
                    prmFechaInactivaCuenta.Value = _fechaInactivaCuenta;
                    Com.Parameters.Add(prmFechaInactivaCuenta);

                    SqlParameter prmUsuarioModifica = new SqlParameter("@UsuarioModificacion", SqlDbType.VarChar);
                    prmUsuarioModifica.Value = globales.RetornaLogin();
                    Com.Parameters.Add(prmUsuarioModifica);


                    SqlParameter prmFechaModificacion = new SqlParameter("@FechaModificacion", SqlDbType.DateTime);
                    prmFechaModificacion.Value = DateTime.Now ;
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

        #region "Modifica Password"
            //Ejecuta el procedimiento almacenado para Modificar clave del usuario.
            public bool ModificaPass()
            {
                ClsConexion conne = new ClsConexion();
                SqlConnection conex = new SqlConnection(conne.Conexion);
                conex.Open();
                SqlCommand Com = new SqlCommand("Spd_Seg_Usuarios_Modifica_Clave");
                Com.Connection = conex;
                Com.CommandType = CommandType.StoredProcedure;

               
                    SqlParameter prmIdUsu = new SqlParameter("@ID", SqlDbType.Int);
                    prmIdUsu.Value = _IdUsuario;
                    Com.Parameters.Add(prmIdUsu);

                    SqlParameter prmClave = new SqlParameter("@Password", SqlDbType.VarChar);
                    prmClave.Value = _Clave;
                    Com.Parameters.Add(prmClave);

                    SqlParameter prmFechaActualizaPass = new SqlParameter("@FechaActualizaContrasena", SqlDbType.DateTime);
                    prmFechaActualizaPass.Value = DateTime.Now;
                    Com.Parameters.Add(prmFechaActualizaPass);

                    SqlParameter prmUsuarioModifica = new SqlParameter("@UsuarioModificacion", SqlDbType.VarChar);
                    prmUsuarioModifica.Value = globales.RetornaLogin();
                    Com.Parameters.Add(prmUsuarioModifica);


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

        public bool ReiniciaPassword()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Seg_Usuarios_ReniciaPassword");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            SqlParameter prmLogin = new SqlParameter("@user", SqlDbType.VarChar);
            prmLogin.Value = _Login;
            Com.Parameters.Add(prmLogin);

            SqlParameter prmClave = new SqlParameter("@password", SqlDbType.VarChar);
            prmClave.Value = _Clave;
            Com.Parameters.Add(prmClave);

            SqlParameter prmClaveEncriptada = new SqlParameter("@passwordencriptada", SqlDbType.VarChar);
            prmClaveEncriptada.Value = _ClaveEncriptada;
            Com.Parameters.Add(prmClaveEncriptada);

            SqlParameter prmCorreo = new SqlParameter("@correo", SqlDbType.VarChar);
            prmCorreo.Value = _CorreoLaboral;
            Com.Parameters.Add(prmCorreo);

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

        #region"Retorna Datatables"
        //Retorna el usuario al que pertenece determinado login.
        public DataTable UsuarioXLogin(string Login)
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("select * from SegUsuario where Login='" + Login + "'", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }

            public DataTable DatosxUsuario(string login)
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter(@"SELECT SrhEmpleado.EmailLaboral, SegUsuario.Login, objEmpleadoId,
                (CASE WHEN SegUsuario.Activo = 1 THEN 1 ELSE 0 END) AS UserActivo
                FROM SegUsuario 
                INNER JOIN SrhEmpleado ON SegUsuario.objEmpleadoId = SrhEmpleado.ID
                WHERE SegUsuario.Login = '" + login +"'", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }

            //Retorna todos los usuarios con el mismo nombre.
            public DataTable TodosUsuarios(String Nombre)
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("Select * From SegUsuario Where PrimerNombre like '%"+Nombre+"%' order by PrimerNombre asc", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }


            //Retorna todos los usuarios por login
            public DataTable ListaTodosUsuariosOrdenLogin()
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("SELECT ID, Login + ' - ' + Nombre AS Nombre FROM SegUsuario ORDER BY Login ASC", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }

            //Retorna todos los usuarios activos por login
            public DataTable ListaTodosUsuariosActivosOrdenLogin()
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("SELECT ID, Login + ' - ' + Nombre AS Nombre FROM SegUsuario WHERE Activo=1 ORDER BY Login ASC", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }

            //Retorna todos los usuarios con sus respectivos roles. 
            public DataTable UsuariosRol(string Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter("Select SU.ID,SU.Activo Estado,SU.Login AS [Usuario],SU.PrimerNombre AS [Primer Nombre], SU.SegundoNombre AS [Segundo Nombre], SU.PrimerApellido AS [Primer Apellido], SU.SegundoApellido [Segundo Apellido], SU.Cedula AS Cédula, SU.Email, SR.NOMBRE Rol,SR.ID IdROL,SU.PASSWORD,SU.FechaInactivaCuenta,SU.ObjEmpleadoID from SegUsuario SU INNER JOIN SEGROL SR ON SU.OBJROLID=SR.ID where SU.PrimerNombre Like '" + Nombre + "%' order by Estado desc,SU.PrimerNombre asc", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

            //Retorna el usuario que a ingresado a la aplicacion.
            public DataTable UsuarioIngresa(string Login,String Clave)
            {
                DataTable tabla = new DataTable(); 
                ClsEncripta Encripta = new ClsEncripta();
                ClsConexion con = new ClsConexion();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("Select * from SegUsuario where Login= '" + Login + "' and Password= '" + Encripta.Encriptar(Clave) + "'", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;     
            }

            //Verifica los dias que le quedan al usuario antes de vencerse su clave
            public Double CaducidadClave()
            {
                ClsVariablesGoblales globales = new ClsVariablesGoblales();
                LlenaTabla tabla = new LlenaTabla();
                DataTable parametro = tabla.Llenartabla("Select valor from StbParametro where Nombre='AdvertenciaVenceClave'");
                int diasParametro = int.Parse(parametro.Rows[0][0].ToString());
                DataTable Usuario = new DataTable();
                Usuario = UsuarioXLogin(globales.RetornaLogin());
                DateTime VenceClave = DateTime.Parse(Usuario.Rows[0][7].ToString());
                TimeSpan Intervalo = VenceClave - DateTime.Today;
                if (diasParametro >= Math.Ceiling(Intervalo.TotalDays))
                {
                    return Math.Ceiling(Intervalo.TotalDays);
                }
                else
                {
                    return -1;
                }

            }

            public DataTable TodosUsuariosActivo(String Nombre)
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("select * from SegUsuario where Nombre like'%" + Nombre + "%' AND Activo=1  order by Nombre asc", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }

            public DataTable RolXUsuario(String Nombre)
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("select SegRol.Nombre from SegUsuario inner join SegRol on SegUsuario.objRolID=SegRol.ID where SegUsuario.login like'%" + Nombre + "%' order by Nombre asc", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }

            public DataTable ValidaIp(String ip)
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                tabla.Clear();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("select 1 from StbParametro where Nombre='IPCAJA' and Valor like '%"+ip+"%'", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }

            public DataTable SimbolosYNombres_Monedas_SiglaPais_Sistema()
            {
                DataTable tabla = new DataTable();
                tabla.Clear();
                ClsEncripta Encripta = new ClsEncripta();
                ClsConexion con = new ClsConexion();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("SELECT Valor FROM StbParametro WHERE Nombre IN ('SIMBOLOMONEDAPRIMARIA', 'SIMBOLOMONEDASECUNDARIA', 'NOMBREMONEDAPRIMARIA', 'NOMBREMONEDASECUNDARIA', 'SIGLAPAISBASE') ORDER BY FechaCreacion", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                return tabla;
            }

            public bool DevuelveEstadoLogin(int ID)
            {
                DataTable tabla = new DataTable();
                ClsEncripta Encripta = new ClsEncripta();
                ClsConexion con = new ClsConexion();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("SELECT Activo FROM SegUsuario WHERE ID='" + ID + "' AND Activo='TRUE' ", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                if (tabla.Rows.Count == 0)
                    return false;
                else
                    return true;
            }

            public String IPCAJAS()
            {
                DataTable tabla = new DataTable();
                ClsEncripta Encripta = new ClsEncripta();
                ClsConexion con = new ClsConexion();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("SELECT Valor FROM StbParametro WHERE Nombre IN ('IPCAJA')", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                if (tabla.Rows.Count > 0)
                {
                    string cajas = tabla.Rows[0][0].ToString();
                    return cajas;
                }
                else
                    return "";
            }

            public String RolXLogin(String Nombre)
            {
                ClsConexion con = new ClsConexion();
                DataTable tabla = new DataTable();
                SqlConnection Conne = new SqlConnection(con.Conexion);
                Conne.Open();
                SqlDataAdapter result = new SqlDataAdapter("select SegRol.Codigo from SegUsuario inner join SegRol on SegUsuario.objRolID=SegRol.ID where SegUsuario.login like'%" + Nombre + "%' order by SegRol.Nombre asc", Conne);
                result.Fill(tabla);
                result.Dispose();
                Conne.Dispose();
                Conne.Close();
                if (tabla.Rows.Count > 0)
                {
                    string Rol = tabla.Rows[0][0].ToString();
                    return Rol;
                }
                else
                    return "";
            }

        #endregion

    }
}
