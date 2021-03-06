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
        int _objPaisOrigenID = 0;
        int _objSexoID = 0;
        int _objEstadoCivil = 0;
        int _objEstadoSolicitudID = 0;
        String _CorreoElectronico = "";
        int _Telefono1 = 0;
        int _Telefono2 = 0;
        double _UbicacionLat = 0;
        double _UbicacionLon = 0;
        int _objDepartamentoID = 0;
        int _objMunicipioID = 0;
        String _ObservacionComite = "";
        Decimal _TasaInteresCorriente = 0;
        Decimal _TasaInteresMoratorio = 0;
        Decimal _MontoAprobado = 0;
        Decimal _MontoComision = 0;
        Decimal _TasaComision = 0;
        int _PlazoAprobado = 0;
        int _objPeriocidadInteresAproID = 0;
        int _objPeriocidadPrincipalAproID = 0;
        DateTime _FechaDesembolso;
        String _Observacion = "";
        int _IdObligacion = 0;
        String _Propietario = "";
        int _objSectorID = 0;
        int _objMonedaID = 0;
        int _PeriocidadInt = 0;
        int _PeriocidadPrin = 0;
        Decimal _Monto = 0;
        int _objTipoClienteID = 0;
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

        public ClsScrSolicitudInversion(int IdSolicitud, int NumSolicitud, string Nombre1, string Nombre2, string Apellido1, string Apellido2, DateTime FechaNacimiento, int objTipoDocumentoID,  string DNI, DateTime FechaEmision, DateTime FechaVencimiento, int objTipoPersonaID, int objPaisOrigenID, int objSexoID, int objEstadoCivil, int objEstadoSolicitudID, string CorreoElectronico, int Telefono1, int Telefono2, 
                                        double UbicacionLat, double UbicacionLon, int objDepartamenteID, int objMunicipioID, string ObservacionComite, Decimal TasaInteresCorriente, Decimal TasaInteresMoratorio, Decimal MontoAprobado, Decimal MontoComision, Decimal TasaComision, int PlazoAprobado, int objPeriocidadInteresAproID, int objPeriocidadPrincipalAproID, DateTime FechaDesembolso,
                                        string Observacion, int IdObligacion, string Propietario, int objSectorID, int objMonedaID, int PeriocidadInt, int PeriocidadPrin, decimal Monto, int objTipoClienteID, String UsuarioCreacion, DateTime FechaCreacion, String MaquinaCreacion, String UsuarioModificacion, DateTime FechaModificacion, String MaquinaModificacion, String UsuarioAnulacion, DateTime FechaAnulacion, String MaquinaAnulacion)
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
            objPaisOrigenID = _objPaisOrigenID;
            objSexoID = _objSexoID;
            objEstadoCivil = _objEstadoCivil;
            objEstadoSolicitudID = _objEstadoSolicitudID;
            CorreoElectronico = _CorreoElectronico;
            Telefono1 = _Telefono1;
            Telefono2 = _Telefono2;
            UbicacionLat = _UbicacionLat;
            UbicacionLon = _UbicacionLon;
            objDepartamenteID = _objDepartamentoID;
            objMunicipioID = _objMunicipioID;
            ObservacionComite = _ObservacionComite;
            TasaInteresCorriente = _TasaInteresCorriente;
            TasaInteresMoratorio = _TasaInteresMoratorio;
            MontoAprobado = _MontoAprobado;
            MontoComision = _MontoComision;
            TasaComision = _TasaComision;
            PlazoAprobado = _PlazoAprobado;
            objPeriocidadInteresAproID = _objPeriocidadInteresAproID;
            objPeriocidadPrincipalAproID = _objPeriocidadPrincipalAproID;
            FechaDesembolso = _FechaDesembolso;
            Observacion = _Observacion;
            IdObligacion = _IdObligacion;
            Propietario = _Propietario;
            objSectorID = _objSectorID;
            objMonedaID = _objMonedaID;
            PeriocidadInt = _PeriocidadInt;
            PeriocidadPrin = _PeriocidadPrin;
            Monto = _Monto;
            objTipoClienteID = _objTipoClienteID;
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
            get { return _objTipoDocumentoID; }
            set { _objTipoDocumentoID = value; }
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

        public int ObjPaisOrigenID
        {
            get { return _objPaisOrigenID; }
            set { _objPaisOrigenID = value; }
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

        public int ObjEstadoSolicitudID
        {
            get { return _objEstadoSolicitudID; }
            set { _objEstadoSolicitudID = value; }
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

        public double UbicacionLat
        {
            get { return _UbicacionLat; }
            set { _UbicacionLat = value; }
        }

        public double UbicacionLon
        {
            get { return _UbicacionLon; }
            set { _UbicacionLon = value; }
        }

        public int objDepartamentoID
        {
            get { return _objDepartamentoID; }
            set { _objDepartamentoID = value; }
        }

        public int objMunicipioID
        {
            get { return _objMunicipioID; }
            set { _objMunicipioID = value; }
        }

        public string ObservacionComite
        {
            get { return _ObservacionComite; }
            set { _ObservacionComite = value; }
        }

        public decimal TasaInteresCorriente
        {
            get { return _TasaInteresCorriente; }
            set { _TasaInteresCorriente = value; }
        }

        public decimal TasaInteresMoratorio
        {
            get { return _TasaInteresMoratorio; }
            set { _TasaInteresMoratorio = value; }
        }

        public decimal MontoAprobado
        {
            get { return _MontoAprobado; }
            set { _MontoAprobado = value; }
        }

        public decimal MontoComision
        {
            get { return _MontoComision; }
            set { _MontoComision = value; }
        }

        public decimal TasaComision
        {
            get { return _TasaComision; }
            set { _TasaComision = value; }
        }

        public int PlazoAprobado
        {
            get { return _PlazoAprobado; }
            set { _PlazoAprobado = value; }
        }

        public int objPeriocidadInteresAproID
        {
            get { return _objPeriocidadInteresAproID; }
            set { _objPeriocidadInteresAproID = value; }
        }

        public int objPeriocidadPrincipalAproID
        {
            get { return _objPeriocidadPrincipalAproID; }
            set { _objPeriocidadPrincipalAproID = value; }
        }

        public DateTime FechaDesembolso
        {
            get { return _FechaDesembolso; }
            set { _FechaDesembolso = value; }
        }

        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; }
        }

        public int IdObligacion 
        {
            get { return _IdObligacion; }
            set { _IdObligacion = value; }
        }

        public string Propietario 
        {
            get { return _Propietario; }
            set { _Propietario = value; } 
        }

        public int ObjSectorID 
        {
            get { return _objSectorID; }
            set { _objSectorID = value; }
        }

        public int ObjMonedaID
        {
            get { return _objMonedaID; }
            set { _objMonedaID = value; }
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

        public int objTipoClienteID 
        {
            get { return _objTipoClienteID; }
            set { _objTipoClienteID = value; }
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

        #region "Cargar Datos"
        public DataTable SolicitudInversion()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT SO.ID, SO.NumeroSolicitud AS[Número Solicitud], SO.PrimerNombre AS[Primer Nombre], SO.SegundoNombre AS[Segundo Nombre], SO.PrimerApellido AS[Primer Apellido], SO.SegundoApellido AS[Segundo Apellido], SO.FechaNacimiento AS[Fecha Nacimiento], SV1.Valor AS[Tipo Documento],
            SO.DNI, SO.FechaEmisionDNI, SO.FechaVencimientoDNI, SV2.Valor AS[Tipo Persona], SC.Nombre AS[País Origen], SV3.Valor AS Sexo, SV4.Valor AS[Estado Cívil], SO.Correo, SO.Telefono1, SO.Telefono2, SO.Observacion, SO.UbicacionLatitud, SO.UbicacionLongitud, SC1.Nombre AS Departamento,
			SC2.Nombre AS Municipio, SO.IDObligacion, SO.Propietario, SV5.Valor AS Sector, SV6.Valor AS Moneda, SV7.Valor AS[Periocidad Interes], SV8.Valor AS[Periocidad Principal], SO.MontoSolicitud AS[Monto Solicitud], SV9.Valor AS[Tipo Cliente], SV10.Valor AS[Estado Solicitud],
            SO.objTipoDocumentoID, SO.objTipoPersonaID, SO.objPaisOrigenID, SO.objSexoID, SO.objEstadoCivilID, SO.objDepartamentoID, SO.objMunicipioID, SO.objSectorID, SO.objMonedaID, SO.objPeriocidadInteresID, SO.objPeriocidadPrincipalID, SO.objTipoClienteID, SO.objEstadoSolicitudID
            FROM ScrSolicitudInversion SO
            INNER JOIN StbUbicacionGeografica SC ON SO.objPaisOrigenID = SC.ID
			INNER JOIN StbUbicacionGeografica SC1 ON SO.objDepartamentoID = SC1.ID
			INNER JOIN StbUbicacionGeografica SC2 ON SO.objMunicipioID = SC2.ID
            INNER JOIN StbCatalogoValor SV1 ON SO.objTipoDocumentoID = SV1.ID
            INNER JOIN StbCatalogoValor SV2 ON SO.objTipoPersonaID = SV2.ID
            INNER JOIN StbCatalogoValor SV3 ON SO.objSexoID = SV3.ID
            INNER JOIN StbCatalogoValor SV4 ON SO.objEstadoCivilID = SV4.ID
            INNER JOIN StbCatalogoValor SV5 ON SO.objSectorID = SV5.ID
            INNER JOIN StbCatalogoValor SV6 ON SO.objMonedaID = SV6.ID
            INNER JOIN StbCatalogoValor SV7 ON SO.objPeriocidadInteresID = SV7.ID
            INNER JOIN StbCatalogoValor SV8 ON SO.objPeriocidadPrincipalID = SV8.ID
            INNER JOIN StbCatalogoValor SV9 ON SO.objTipoClienteID = SV9.ID
            INNER JOIN StbCatalogoValor SV10 ON SO.objEstadoSolicitudID = SV10.ID
            ORDER BY SO.NumeroSolicitud asc", Conne );
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }
        #endregion

        #region "Guardar Solicitud"
        //Ejecuta el procedimiento almacenado para guardar la solicitud.
        public bool GuardaSolicitud()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Scr_Solicitud_Ingresa");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            SqlParameter prmPrimerNombre = new SqlParameter("@PrimerNombre", SqlDbType.VarChar);
            prmPrimerNombre.Value = _Nombre1;
            Com.Parameters.Add(prmPrimerNombre);

            SqlParameter prmSegundoNombre = new SqlParameter("@SegundoNombre", SqlDbType.VarChar);
            prmSegundoNombre.Value = _Nombre2;
            Com.Parameters.Add(prmSegundoNombre);

            SqlParameter prmPrimerApellido = new SqlParameter("@PrimerApellido", SqlDbType.VarChar);
            prmPrimerApellido.Value = _Apellido1;
            Com.Parameters.Add(prmPrimerApellido);

            SqlParameter prmSegundoApellido = new SqlParameter("@SegundoApellido", SqlDbType.VarChar);
            prmSegundoApellido.Value = _Apellido2;
            Com.Parameters.Add(prmSegundoApellido);

            SqlParameter prmFechaNac = new SqlParameter("@FechaNacimiento", SqlDbType.DateTime);
            prmFechaNac.Value = _FechaNacimiento;
            Com.Parameters.Add(prmFechaNac);

            SqlParameter prmTipoDocumento = new SqlParameter("@objTipoDocumentoID", SqlDbType.Int);
            prmTipoDocumento.Value = _objTipoDocumentoID;
            Com.Parameters.Add(prmTipoDocumento);

            SqlParameter prmDNI = new SqlParameter("@DNI", SqlDbType.VarChar);
            prmDNI.Value = _DNI;
            Com.Parameters.Add(prmDNI);

            SqlParameter prmFechaEmision = new SqlParameter("@FechaEmisionDNI", SqlDbType.DateTime);
            prmFechaEmision.Value = _FechaEmision;
            Com.Parameters.Add(prmFechaEmision);

            SqlParameter prmFechaVencimiento = new SqlParameter("@FechaVencimientoDNI", SqlDbType.DateTime);
            prmFechaVencimiento.Value = _FechaVencimiento;
            Com.Parameters.Add(prmFechaVencimiento);

            SqlParameter prmTipoPersona = new SqlParameter("@objTipoPersonaID", SqlDbType.Int);
            prmTipoPersona.Value = _objTipoPersonaID;
            Com.Parameters.Add(prmTipoPersona);

            SqlParameter prmPaisOrigen = new SqlParameter("@objPaisOrigenID", SqlDbType.Int);
            prmPaisOrigen.Value = _objPaisOrigenID;
            Com.Parameters.Add(prmPaisOrigen);

            SqlParameter prmSexo = new SqlParameter("@objSexoID", SqlDbType.Int);
            prmSexo.Value = _objSexoID;
            Com.Parameters.Add(prmSexo);

            SqlParameter prmEstadoCivil = new SqlParameter("@objEstadoCivilID", SqlDbType.Int);
            prmEstadoCivil.Value = _objEstadoCivil;
            Com.Parameters.Add(prmEstadoCivil);

            SqlParameter prmCorreo = new SqlParameter("@Correo", SqlDbType.VarChar);
            prmCorreo.Value = _CorreoElectronico;
            Com.Parameters.Add(prmCorreo);

            SqlParameter prmTelefono1 = new SqlParameter("@Telefono1", SqlDbType.VarChar);
            prmTelefono1.Value = _Telefono1;
            Com.Parameters.Add(prmTelefono1);

            SqlParameter prmTelefono2 = new SqlParameter("@Telefono2", SqlDbType.VarChar);
            prmTelefono2.Value = _Telefono2;
            Com.Parameters.Add(prmTelefono2);

            SqlParameter prmObservacion = new SqlParameter("@Observacion", SqlDbType.VarChar);
            prmObservacion.Value = _Observacion;
            Com.Parameters.Add(prmObservacion);

            SqlParameter prmUbicacionLat = new SqlParameter("@UbicacionLatitud", SqlDbType.VarChar);
            prmUbicacionLat.Value = _UbicacionLat;
            Com.Parameters.Add(prmUbicacionLat);

            SqlParameter prmUbicacionLon = new SqlParameter("@UbicacionLongitud", SqlDbType.VarChar);
            prmUbicacionLon.Value = _UbicacionLon;
            Com.Parameters.Add(prmUbicacionLon);

            SqlParameter prmDepartamento = new SqlParameter("@objDepartamentoID", SqlDbType.Int);
            prmDepartamento.Value = _objDepartamentoID;
            Com.Parameters.Add(prmDepartamento);

            SqlParameter prmMunicipio = new SqlParameter("@objMunicipioID", SqlDbType.Int);
            prmMunicipio.Value = _objMunicipioID;
            Com.Parameters.Add(prmMunicipio);

            SqlParameter prmObligacion = new SqlParameter("@IDObligacion", SqlDbType.Int);
            prmObligacion.Value = _IdObligacion;
            Com.Parameters.Add(prmObligacion);

            SqlParameter prmPropietario = new SqlParameter("@Propietario", SqlDbType.VarChar);
            prmPropietario.Value = _Propietario;
            Com.Parameters.Add(prmPropietario);

            SqlParameter prmSector = new SqlParameter("@objSectorID", SqlDbType.Int);
            prmSector.Value = _objSectorID;
            Com.Parameters.Add(prmSector);

            SqlParameter prmMoneda = new SqlParameter("@objMonedaID", SqlDbType.Int);
            prmMoneda.Value = _objMonedaID;
            Com.Parameters.Add(prmMoneda);

            SqlParameter prmPeriocidadInt = new SqlParameter("@objPeriocidadInteresID", SqlDbType.Int);
            prmPeriocidadInt.Value = _PeriocidadInt;
            Com.Parameters.Add(prmPeriocidadInt);

            SqlParameter prmPeriocidadPrin = new SqlParameter("@objPeriocidadPrincipalID", SqlDbType.Int);
            prmPeriocidadPrin.Value = _PeriocidadPrin;
            Com.Parameters.Add(prmPeriocidadPrin);

            SqlParameter prmMontoSolicitud = new SqlParameter("@MontoSolicitud", SqlDbType.Decimal);
            prmMontoSolicitud.Value = _Monto;
            Com.Parameters.Add(prmMontoSolicitud);

            SqlParameter prmTipoCliente = new SqlParameter("@objTipoClienteID", SqlDbType.Int);
            prmTipoCliente.Value = _objTipoClienteID;
            Com.Parameters.Add(prmTipoCliente);

            SqlParameter prmEstadoSolicitud = new SqlParameter("@objEstadoSolicitudID", SqlDbType.Int);
            prmEstadoSolicitud.Value = _objEstadoSolicitudID;
            Com.Parameters.Add(prmEstadoSolicitud);

            SqlParameter prmUsuarioCrea = new SqlParameter("@UsuarioCreacion", SqlDbType.VarChar);
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

        #region "Modificar Solicitud"
        //Ejecuta el procedimiento almacenado para guardar la solicitud.
        public bool ModificarSolicitud()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Scr_Solicitud_Modifica");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            SqlParameter prmID = new SqlParameter("@ID", SqlDbType.Int);
            prmID.Value = _IdSolicitud;
            Com.Parameters.Add(prmID);

            SqlParameter prmPrimerNombre = new SqlParameter("@PrimerNombre", SqlDbType.VarChar);
            prmPrimerNombre.Value = _Nombre1;
            Com.Parameters.Add(prmPrimerNombre);

            SqlParameter prmSegundoNombre = new SqlParameter("@SegundoNombre", SqlDbType.VarChar);
            prmSegundoNombre.Value = _Nombre2;
            Com.Parameters.Add(prmSegundoNombre);

            SqlParameter prmPrimerApellido = new SqlParameter("@PrimerApellido", SqlDbType.VarChar);
            prmPrimerApellido.Value = _Apellido1;
            Com.Parameters.Add(prmPrimerApellido);

            SqlParameter prmSegundoApellido = new SqlParameter("@SegundoApellido", SqlDbType.VarChar);
            prmSegundoApellido.Value = _Apellido2;
            Com.Parameters.Add(prmSegundoApellido);

            SqlParameter prmFechaNac = new SqlParameter("@FechaNacimiento", SqlDbType.DateTime);
            prmFechaNac.Value = _FechaNacimiento;
            Com.Parameters.Add(prmFechaNac);

            SqlParameter prmTipoDocumento = new SqlParameter("@objTipoDocumentoID", SqlDbType.Int);
            prmTipoDocumento.Value = _objTipoDocumentoID;
            Com.Parameters.Add(prmTipoDocumento);

            SqlParameter prmDNI = new SqlParameter("@DNI", SqlDbType.VarChar);
            prmDNI.Value = _DNI;
            Com.Parameters.Add(prmDNI);

            SqlParameter prmFechaEmision = new SqlParameter("@FechaEmisionDNI", SqlDbType.DateTime);
            prmFechaEmision.Value = _FechaEmision;
            Com.Parameters.Add(prmFechaEmision);

            SqlParameter prmFechaVencimiento = new SqlParameter("@FechaVencimientoDNI", SqlDbType.DateTime);
            prmFechaVencimiento.Value = _FechaVencimiento;
            Com.Parameters.Add(prmFechaVencimiento);

            SqlParameter prmTipoPersona = new SqlParameter("@objTipoPersonaID", SqlDbType.Int);
            prmTipoPersona.Value = _objTipoPersonaID;
            Com.Parameters.Add(prmTipoPersona);

            SqlParameter prmPaisOrigen = new SqlParameter("@objPaisOrigenID", SqlDbType.Int);
            prmPaisOrigen.Value = _objPaisOrigenID;
            Com.Parameters.Add(prmPaisOrigen);

            SqlParameter prmSexo = new SqlParameter("@objSexoID", SqlDbType.Int);
            prmSexo.Value = _objSexoID;
            Com.Parameters.Add(prmSexo);

            SqlParameter prmEstadoCivil = new SqlParameter("@objEstadoCivilID", SqlDbType.Int);
            prmEstadoCivil.Value = _objEstadoCivil;
            Com.Parameters.Add(prmEstadoCivil);

            SqlParameter prmCorreo = new SqlParameter("@Correo", SqlDbType.VarChar);
            prmCorreo.Value = _CorreoElectronico;
            Com.Parameters.Add(prmCorreo);

            SqlParameter prmTelefono1 = new SqlParameter("@Telefono1", SqlDbType.VarChar);
            prmTelefono1.Value = _Telefono1;
            Com.Parameters.Add(prmTelefono1);

            SqlParameter prmTelefono2 = new SqlParameter("@Telefono2", SqlDbType.VarChar);
            prmTelefono2.Value = _Telefono2;
            Com.Parameters.Add(prmTelefono2);

            SqlParameter prmObservacion = new SqlParameter("@Observacion", SqlDbType.VarChar);
            prmObservacion.Value = _Observacion;
            Com.Parameters.Add(prmObservacion);

            SqlParameter prmUbicacionLat = new SqlParameter("@UbicacionLatitud", SqlDbType.VarChar);
            prmUbicacionLat.Value = _UbicacionLat;
            Com.Parameters.Add(prmUbicacionLat);

            SqlParameter prmUbicacionLon = new SqlParameter("@UbicacionLongitud", SqlDbType.VarChar);
            prmUbicacionLon.Value = _UbicacionLon;
            Com.Parameters.Add(prmUbicacionLon);

            SqlParameter prmDepartamento = new SqlParameter("@objDepartamentoID", SqlDbType.Int);
            prmDepartamento.Value = _objDepartamentoID;
            Com.Parameters.Add(prmDepartamento);

            SqlParameter prmMunicipio = new SqlParameter("@objMunicipioID", SqlDbType.Int);
            prmMunicipio.Value = _objMunicipioID;
            Com.Parameters.Add(prmMunicipio);

            SqlParameter prmObligacion = new SqlParameter("@IDObligacion", SqlDbType.Int);
            prmObligacion.Value = _IdObligacion;
            Com.Parameters.Add(prmObligacion);

            SqlParameter prmPropietario = new SqlParameter("@Propietario", SqlDbType.VarChar);
            prmPropietario.Value = _Propietario;
            Com.Parameters.Add(prmPropietario);

            SqlParameter prmSector = new SqlParameter("@objSectorID", SqlDbType.Int);
            prmSector.Value = _objSectorID;
            Com.Parameters.Add(prmSector);

            SqlParameter prmMoneda = new SqlParameter("@objMonedaID", SqlDbType.Int);
            prmMoneda.Value = _objMonedaID;
            Com.Parameters.Add(prmMoneda);

            SqlParameter prmPeriocidadInt = new SqlParameter("@objPeriocidadInteresID", SqlDbType.Int);
            prmPeriocidadInt.Value = _PeriocidadInt;
            Com.Parameters.Add(prmPeriocidadInt);

            SqlParameter prmPeriocidadPrin = new SqlParameter("@objPeriocidadPrincipalID", SqlDbType.Int);
            prmPeriocidadPrin.Value = _PeriocidadPrin;
            Com.Parameters.Add(prmPeriocidadPrin);

            SqlParameter prmMontoSolicitud = new SqlParameter("@MontoSolicitud", SqlDbType.Decimal);
            prmMontoSolicitud.Value = _Monto;
            Com.Parameters.Add(prmMontoSolicitud);

            SqlParameter prmTipoCliente = new SqlParameter("@objTipoClienteID", SqlDbType.Int);
            prmTipoCliente.Value = _objTipoClienteID;
            Com.Parameters.Add(prmTipoCliente);

            SqlParameter prmEstadoSolicitud = new SqlParameter("@objEstadoSolicitudID", SqlDbType.Int);
            prmEstadoSolicitud.Value = _objEstadoSolicitudID;
            Com.Parameters.Add(prmEstadoSolicitud);

            SqlParameter prmUsuarioCrea = new SqlParameter("@UsuarioModificacion", SqlDbType.VarChar);
            prmUsuarioCrea.Value = globales.RetornaLogin();
            Com.Parameters.Add(prmUsuarioCrea);

            SqlParameter prmfechaCrea = new SqlParameter("@FechaModificacion", SqlDbType.DateTime);
            prmfechaCrea.Value = DateTime.Now;
            Com.Parameters.Add(prmfechaCrea);

            SqlParameter prmMaquinaCrea = new SqlParameter("@MaquinaModificacion", SqlDbType.VarChar);
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

        #region "Gestionar la Solicitud"
        public bool GestionarSolicitud()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_Scr_Solicitud_Gestion");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            SqlParameter prmID = new SqlParameter("@ID", SqlDbType.Int);
            prmID.Value = _IdSolicitud;
            Com.Parameters.Add(prmID);

            SqlParameter prmObservacionCo = new SqlParameter("@ObservacionComite", SqlDbType.VarChar);
            prmObservacionCo.Value = _ObservacionComite;
            Com.Parameters.Add(prmObservacionCo);

            SqlParameter prmTasaIntCor = new SqlParameter("@TasaInteresCorriente", SqlDbType.Decimal);
            prmTasaIntCor.Value = _TasaInteresCorriente;
            Com.Parameters.Add(prmTasaIntCor);

            SqlParameter prmTasaIntMor = new SqlParameter("@TasaInteresMoratorio", SqlDbType.Decimal);
            prmTasaIntMor.Value = _TasaInteresMoratorio;
            Com.Parameters.Add(prmTasaIntMor);

            SqlParameter prmMontoAprobado = new SqlParameter("@MontoAprobado", SqlDbType.Decimal);
            prmMontoAprobado.Value = _MontoAprobado;
            Com.Parameters.Add(prmMontoAprobado);

            SqlParameter prmMontoComision = new SqlParameter("@MontoComision", SqlDbType.Decimal);
            prmMontoComision.Value = _MontoComision;
            Com.Parameters.Add(prmMontoComision);

            SqlParameter prmTasaComision = new SqlParameter("@TasaComision", SqlDbType.Decimal);
            prmTasaComision.Value = _TasaComision;
            Com.Parameters.Add(prmTasaComision);

            SqlParameter prmPlazoAprobado = new SqlParameter("@PlazoAprobado", SqlDbType.Int);
            prmPlazoAprobado.Value = _PlazoAprobado;
            Com.Parameters.Add(prmPlazoAprobado);

            SqlParameter prmMoneda = new SqlParameter("@objMonedaID", SqlDbType.Int);
            prmMoneda.Value = _objMonedaID;
            Com.Parameters.Add(prmMoneda);

            SqlParameter prmPeriocidadIntApro = new SqlParameter("@objPeriocidadInteresAproID", SqlDbType.Int);
            prmPeriocidadIntApro.Value = _objPeriocidadInteresAproID;
            Com.Parameters.Add(prmPeriocidadIntApro);

            SqlParameter prmPeriocidadPrinApro = new SqlParameter("@objPeriocidadPrincipalAproID", SqlDbType.Int);
            prmPeriocidadPrinApro.Value = _objPeriocidadPrincipalAproID;
            Com.Parameters.Add(prmPeriocidadPrinApro);

            SqlParameter prmFechaDesembolso = new SqlParameter("@FechaDesembolso", SqlDbType.DateTime);
            prmFechaDesembolso.Value = _FechaDesembolso;
            Com.Parameters.Add(prmFechaDesembolso);

            SqlParameter prmEstadoSolicitud = new SqlParameter("@objEstadoSolicitudID", SqlDbType.Int);
            prmEstadoSolicitud.Value = _objEstadoSolicitudID;
            Com.Parameters.Add(prmEstadoSolicitud);

            SqlParameter prmUsuarioCrea = new SqlParameter("@UsuarioModificacion", SqlDbType.VarChar);
            prmUsuarioCrea.Value = globales.RetornaLogin();
            Com.Parameters.Add(prmUsuarioCrea);

            SqlParameter prmfechaCrea = new SqlParameter("@FechaModificacion", SqlDbType.DateTime);
            prmfechaCrea.Value = DateTime.Now;
            Com.Parameters.Add(prmfechaCrea);

            SqlParameter prmMaquinaCrea = new SqlParameter("@MaquinaModificacion", SqlDbType.VarChar);
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

        #region "Buscar x Nombre"
        public DataTable BuscarSolicitudInversion(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT SO.ID, SO.NumeroSolicitud AS[Número Solicitud], SO.PrimerNombre AS[Primer Nombre], SO.SegundoNombre AS[Segundo Nombre], SO.PrimerApellido AS[Primer Apellido], SO.SegundoApellido AS[Segundo Apellido], SO.FechaNacimiento AS[Fecha Nacimiento], SV1.Valor AS[Tipo Documento],
            SO.DNI, SO.FechaEmisionDNI, SO.FechaVencimientoDNI, SV2.Valor AS[Tipo Persona], SC.Nombre AS[País Origen], SV3.Valor AS Sexo, SV4.Valor AS[Estado Cívil], SO.Correo, SO.Telefono1, SO.Telefono2, SO.Observacion, SO.UbicacionLatitud, SO.UbicacionLongitud, SC1.Nombre AS Departamento,
			SC2.Nombre AS Municipio, SO.IDObligacion, SO.Propietario, SV5.Valor AS Sector, SV6.Valor AS Moneda, SV7.Valor AS[Periocidad Interes], SV8.Valor AS[Periocidad Principal], SO.MontoSolicitud AS[Monto Solicitud], SV9.Valor AS[Tipo Cliente], SV10.Valor AS[Estado Solicitud],
            SO.objTipoDocumentoID, SO.objTipoPersonaID, SO.objPaisOrigenID, SO.objSexoID, SO.objEstadoCivilID, SO.objDepartamentoID, SO.objMunicipioID, SO.objSectorID, SO.objMonedaID, SO.objPeriocidadInteresID, SO.objPeriocidadPrincipalID, SO.objTipoClienteID, SO.objEstadoSolicitudID
            FROM ScrSolicitudInversion SO
            INNER JOIN StbUbicacionGeografica SC ON SO.objPaisOrigenID = SC.ID
			INNER JOIN StbUbicacionGeografica SC1 ON SO.objDepartamentoID = SC1.ID
			INNER JOIN StbUbicacionGeografica SC2 ON SO.objMunicipioID = SC2.ID
            INNER JOIN StbCatalogoValor SV1 ON SO.objTipoDocumentoID = SV1.ID
            INNER JOIN StbCatalogoValor SV2 ON SO.objTipoPersonaID = SV2.ID
            INNER JOIN StbCatalogoValor SV3 ON SO.objSexoID = SV3.ID
            INNER JOIN StbCatalogoValor SV4 ON SO.objEstadoCivilID = SV4.ID
            INNER JOIN StbCatalogoValor SV5 ON SO.objSectorID = SV5.ID
            INNER JOIN StbCatalogoValor SV6 ON SO.objMonedaID = SV6.ID
            INNER JOIN StbCatalogoValor SV7 ON SO.objPeriocidadInteresID = SV7.ID
            INNER JOIN StbCatalogoValor SV8 ON SO.objPeriocidadPrincipalID = SV8.ID
            INNER JOIN StbCatalogoValor SV9 ON SO.objTipoClienteID = SV9.ID
            INNER JOIN StbCatalogoValor SV10 ON SO.objEstadoSolicitudID = SV10.ID
            WHERE SO.PrimerNombre like '" + Nombre + "%' ORDER BY SO.NumeroSolicitud asc", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }
        #endregion
    }
}
