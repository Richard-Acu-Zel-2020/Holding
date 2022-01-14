using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsScrSolicitudInversion
    {
        ClsVariablesGoblales globales = new ClsVariablesGoblales();

        int _IdSolicitud = 0;
        int _NumSolicitud = 0;
        String _Nombre1 = "";
        String _Nombre2 = "";
        String _Apellido1 = "";
        String _Apellido2 = "";
        DateTime _FechaNacimiento;
        int _objTipoDocumentoID = 0;
        String _DNI = "";
        DateTime _FechaEmision;
        DateTime _FechaVencimiento;
        int _objTipoPersonaID = 0;
        int _objSexoID = 0;
        int _objEstadoCivil = 0;
        String _CorreoElectronico = "";
        int _Telefono1 = 0;
        int _Telefono2 = 0;
        double _Ubicacion = 0;
        int _IdObligacion = 0;
        int _objPropietarioID = 0;
        int _objSectorID = 0;
        int _PeriocidadInt = 0;
        int _PeriocidadPrin = 0;
        Decimal _Monto = 0;
        String _TipoCliente = "";
        String _UsuarioCreacion = "";
        DateTime _FechaCreacion;
        String _MaquinaCreacion = "";
        String _UsuarioModificacion = "";
        DateTime _FechaModificacion;
        String _MaquinaModificacion = "";
        String _UsuarioAnulacion = "";
        DateTime _FechaAnulacion;
        String _MaquinaAnulacion = "";

        #region "Constructores"
        public ClsScrSolicitudInversion() { }

        public ClsScrSolicitudInversion(int IdSolicitud, int NumSolicitud, string Nombre1, string Nombre2, string Apellido1, string Apellido2, DateTime FechaNacimiento, int objTipoDocumentoID, 
                                        string DNI, DateTime FechaEmision, DateTime FechaVencimiento, int objTipoPersonaID, int objSexoID, int objEstadoCivil, string CorreoElectronico, int Telefono1, int Telefono2, 
                                        double Ubicacion, int IdObligacion, int objPropietarioID, int objSectorID, int PeriocidadInt, int PeriocidadPrin, decimal Monto, string TipoCliente, String UsuarioCreacion, 
                                        DateTime FechaCreacion, String MaquinaCreacion, String UsuarioModificacion, DateTime FechaModificacion, String MaquinaModificacion, String UsuarioAnulacion, DateTime FechaAnulacion, String MaquinaAnulacion)
        {
            IdSolicitud = _IdSolicitud;
            NumSolicitud = _NumSolicitud;
            Nombre1 = _Nombre1;
            Nombre2 = _Nombre2;
            Apellido1 = _Apellido1;
            Apellido2 = _Apellido2;
            FechaNacimiento = _FechaNacimiento;
            objTipoDocumentoID = _objTipoDocumentoID;
            DNI = _DNI;
            FechaEmision = _FechaEmision;
            FechaVencimiento = _FechaVencimiento;
            objTipoPersonaID = _objTipoPersonaID;
            objSexoID = _objSexoID;
            objEstadoCivil = _objEstadoCivil;
            CorreoElectronico = _CorreoElectronico;
            Telefono1 = _Telefono1;
            Telefono2 = _Telefono2;
            Ubicacion = _Ubicacion;
            IdObligacion = _IdObligacion;
            objPropietarioID = _objPropietarioID;
            objSectorID = _objSectorID;
            PeriocidadInt = _PeriocidadInt;
            PeriocidadPrin = _PeriocidadPrin;
            Monto = _Monto;
            TipoCliente = _TipoCliente;
            UsuarioCreacion = _UsuarioCreacion;
            FechaCreacion = _FechaCreacion;
            MaquinaCreacion = _MaquinaCreacion;
            UsuarioModificacion = _UsuarioModificacion;
            FechaModificacion = _FechaModificacion;
            MaquinaModificacion = _MaquinaModificacion;
            UsuarioAnulacion = _UsuarioAnulacion;
            FechaAnulacion = _FechaAnulacion;
            MaquinaAnulacion = _MaquinaAnulacion;
        }
        #endregion

        #region "Propiedades"
        public int IdSolicitud 
        {
            get { return _IdSolicitud; }
            set { _IdSolicitud = value; }
        }

        public int NumSolicitud 
        {
            get { return _NumSolicitud; }
            set { _NumSolicitud = value; }
        }

        public string Nombre1 
        {
            get { return _Nombre1; }
            set { _Nombre1 = value; } 
        }

        public string Nombre2 
        {
            get { return _Nombre2; }
            set { _Nombre2 = value; }
        }

        public string Apellido1 
        {
            get { return _Apellido1; }
            set { _Apellido1 = value; }
        }

        public string Apellido2 
        {
            get { return _Apellido2; }
            set { _Apellido2 = value; }
        }

        public DateTime FechaNacimiento 
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public int ObjTipoDocumentoID 
        { 
            get => _objTipoDocumentoID; 
            set => _objTipoDocumentoID = value; 
        }

        public string DNI 
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

        public DateTime FechaEmision 
        {
            get { return _FechaEmision; }
            set { _FechaEmision = value; }
        }

        public DateTime FechaVencimiento 
        {
            get { return _FechaVencimiento; }
            set { _FechaVencimiento = value; }
        }

        public int ObjTipoPersonaID 
        {
            get { return _objTipoPersonaID; }
            set { _objTipoPersonaID = value; }
        }

        public int ObjSexoID 
        {
            get { return _objSexoID; }
            set { _objSexoID = value; }
        }

        public int ObjEstadoCivil 
        {
            get { return _objEstadoCivil; }
            set { _objEstadoCivil = value; }
        }

        public string CorreoElectronico 
        {
            get { return _CorreoElectronico; }
            set { _CorreoElectronico = value; }
        }

        public int Telefono1 
        {
            get { return _Telefono1; }
            set { _Telefono1 = value; }
        }

        public int Telefono2 
        {
            get { return _Telefono2; }
            set { _Telefono2 = value; }
        }

        public double Ubicacion 
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }

        public int IdObligacion 
        {
            get { return _IdObligacion; }
            set { _IdObligacion = value; }
        }

        public int ObjPropietarioID 
        {
            get { return _objPropietarioID; }
            set { _objPropietarioID = value; } 
        }

        public int ObjSectorID 
        {
            get { return _objSectorID; }
            set { _objSectorID = value; }
        }

        public int PeriocidadInt 
        {
            get { return _PeriocidadInt; }
            set { _PeriocidadInt = value; } 
        }

        public int PeriocidadPrin 
        {
            get { return _PeriocidadPrin; }
            set { _PeriocidadPrin = value; }
        }

        public decimal Monto 
        {
            get { return _Monto; }
            set { _Monto = value; }
        }

        public string TipoCliente 
        {
            get { return _TipoCliente; }
            set { _TipoCliente = value; }
        }

        public string UsuarioCreacion
        {
            get { return _UsuarioCreacion; }
            set { _UsuarioCreacion = value; }
        }

        public DateTime FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public string MaquinaCreacion
        {
            get { return _MaquinaCreacion; }
            set { _MaquinaCreacion = value; }
        }

        public string UsuarioModificacion
        {
            get { return _UsuarioModificacion; }
            set { _UsuarioModificacion = value; }
        }

        public DateTime FechaModificacion
        {
            get { return _FechaModificacion; }
            set { _FechaModificacion = value; }
        }

        public string MaquinaModificacion
        {
            get { return _MaquinaModificacion; }
            set { _MaquinaModificacion = value; }
        }

        public string UsuarioAnulacion
        {
            get { return _UsuarioAnulacion; }
            set { _UsuarioAnulacion = value; }
        }

        public DateTime FechaAnulacion
        {
            get { return _FechaAnulacion; }
            set { _FechaAnulacion = value; }
        }

        public string MaquinaAnulacion
        {
            get { return _MaquinaAnulacion; }
            set { _MaquinaAnulacion = value; }
        }
        #endregion

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
