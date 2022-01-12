using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsSvnPagoInversion
    {
        ClsVariablesGoblales globales = new ClsVariablesGoblales();

        int _IdPago = 0;
        int _Inversion = 0;
        String _NumeroTransferencia = "";
        int _IdEstadoPago = 0;
        DateTime _FechaPago;
        int _IdFormaPago = 0;
        int _IdMoneda = 0;
        int _DiasTranscurridos = 0;
        int _DiasMora = 0;
        int _EstadoInversion = 0;
        Decimal _Principal = 0;
        Decimal _InteresCorriente = 0;
        Decimal _InteresMoratorio = 0;
        Decimal _TotalPagado = 0;
        Decimal _PrincipalAnterior = 0;
        Decimal _PrincipalActual = 0;
        Decimal _InteresAnterior = 0;
        Decimal _InteresActual = 0;
        String _CodigoPersona = "";
        String _Observacion = "";
        String _UsuarioCreacion = "";
        DateTime _FechaCreacion;
        String _MaquinaCreacion = "";
        String _UsuarioModificacion = "";
        DateTime _FechaModificacion;
        String _MaquinaModificacion = "";
        String _UsuarioAnula = "";
        DateTime _FechaAnula;
        String _MaquinaAnula = "";
        String _MotivoAnula = "";
        int _IdNotaMotivo = 0;
        String _Cuotas = "";
        Byte _EnCuotas = 0;
        String _NombrePersona = "";

        #region Constructores
        public ClsSvnPagoInversion() { }

        public ClsSvnPagoInversion(int IdPago, int Inversion, String NumeroTransferencia, int IdEstadoPago, DateTime FechaPago, int IdFormaPago, int IdMoneda, int DiasTranscurridos, int DiasMora, int EstadoInversion,
        Decimal Principal, Decimal InteresCorriente, Decimal InteresMoratorio, Decimal TotalPagado, Decimal PrincipalAnterior, Decimal PrincipalActual, Decimal InteresAnterior, Decimal InteresActual, String CodigoPersona,
        String Observacion, String UsuarioCreacion, DateTime FechaCreacion, String MaquinaCreacion, String UsuarioModificacion, DateTime FechaModificacion, String MaquinaModificacion, String UsuarioAnula, DateTime FechaAnula,
        String MaquinaAnula, String MotivoAnula, int IdNotaMotivo, String Cuotas, Byte EnCuotas, String NombrePersona)

        {
            IdPago = _IdPago;
            Inversion = _Inversion;
            NumeroTransferencia = _NumeroTransferencia;
            IdEstadoPago = _IdEstadoPago;
            FechaPago = _FechaPago;
            IdFormaPago = _IdFormaPago;
            IdMoneda = _IdMoneda;
            DiasTranscurridos = _DiasTranscurridos;
            DiasMora = _DiasMora;
            EstadoInversion = _EstadoInversion;
            Principal = _Principal;
            InteresCorriente = _InteresCorriente;
            InteresMoratorio = _InteresMoratorio;
            TotalPagado = _TotalPagado;
            PrincipalAnterior = _PrincipalAnterior;
            PrincipalActual = _PrincipalActual;
            InteresAnterior = _InteresAnterior;
            InteresActual = _InteresActual;
            CodigoPersona = _CodigoPersona;
            Observacion = _Observacion;
            UsuarioCreacion = _UsuarioCreacion;
            FechaCreacion = _FechaCreacion;
            MaquinaCreacion = _MaquinaCreacion;
            UsuarioModificacion = _UsuarioModificacion;
            FechaModificacion = _FechaModificacion;
            MaquinaModificacion = _MaquinaModificacion;
            UsuarioAnula = _UsuarioAnula;
            FechaAnula = _FechaAnula;
            MaquinaAnula = _MaquinaAnula;
            MotivoAnula = _MotivoAnula;
            IdNotaMotivo = _IdNotaMotivo;
            Cuotas = _Cuotas;
            EnCuotas = _EnCuotas;
            NombrePersona = _NombrePersona;
        }
        #endregion

        #region Propiedades
        public int IdPago 
        { 
            get { return _IdPago; } 
            set { _IdPago = value; }
        }

        public int Inversion 
        {
            get { return _Inversion; }
            set { _Inversion = value; }
        }

        public string NumeroTransferencia 
        {
            get { return _NumeroTransferencia; }
            set { _NumeroTransferencia = value; }
        }

        public int IdEstadoPago 
        {
            get { return _IdEstadoPago; }
            set { _IdEstadoPago = value; }
        }

        public DateTime FechaPago 
        {
            get { return _FechaPago; }
            set { _FechaPago = value; }
        }

        public int IdFormaPago
        {
            get { return _IdFormaPago; }
            set { _IdFormaPago = value; }
        }

        public int IdMoneda 
        {
            get { return _IdMoneda; }
            set { _IdMoneda = value; }
        }

        public int DiasTranscurridos 
        {
            get { return _DiasTranscurridos; }
            set { _DiasTranscurridos = value; }
        }

        public int DiasMora 
        {
            get { return _DiasMora; }
            set { _DiasMora = value; }
        }

        public int EstadoInversion 
        {
            get { return _EstadoInversion; }
            set { _EstadoInversion = value; } 
        }

        public decimal Principal 
        {
            get { return _Principal; }
            set { _Principal = value; } 
        }

        public decimal InteresCorriente 
        {
            get { return _InteresCorriente; }
            set { _InteresCorriente = value; }
        }

        public decimal InteresMoratorio 
        {
            get { return _InteresMoratorio; }
            set { _InteresMoratorio = value; }
        }

        public decimal TotalPagado 
        {
            get { return _TotalPagado; }
            set { _TotalPagado = value; }
        }

        public decimal PrincipalAnterior 
        {
            get { return _PrincipalAnterior; }
            set { _PrincipalAnterior = value; }
        }

        public decimal PrincipalActual 
        {
            get { return _PrincipalActual; }
            set { _PrincipalActual = value; }
        }

        public decimal InteresAnterior 
        {
            get { return _InteresAnterior; }
            set { _InteresAnterior = value; }
        }

        public decimal InteresActual 
        {
            get { return _InteresActual; }
            set { _InteresActual = value; }
        }

        public string CodigoPersona 
        {
            get { return _CodigoPersona; }
            set { _CodigoPersona = value; }
        }

        public string Observacion 
        {
            get { return _Observacion; }
            set { _Observacion = value; }
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

        public string UsuarioAnula 
        {
            get { return _UsuarioAnula; }
            set { _UsuarioAnula = value; }
        }

        public DateTime FechaAnula 
        {
            get { return _FechaAnula; }
            set { _FechaAnula = value; }
        }

        public string MaquinaAnula 
        {
            get { return _MaquinaAnula; }
            set { _MaquinaAnula = value; }
        }

        public string MotivoAnula 
        {
            get { return _MotivoAnula; }
            set { _MotivoAnula = value; }
        }

        public int IdNotaMotivo
        {
            get { return _IdNotaMotivo; }
            set { _IdNotaMotivo = value; }
        }

        public string Cuotas
        {
            get { return _Cuotas; }
            set { _Cuotas = value; }
        }

        public byte EnCuotas 
        {
            get { return _EnCuotas; }
            set { _EnCuotas = value; }
        }

        public string NombrePersona 
        {
            get { return NombrePersona; }
            set { _NombrePersona = value; } 
        }
        #endregion

        #region "Carga los Datos del Plan de Pago"
        public DataTable PlanPagos(int idInversion)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT ID, ObjInversionID, NumeroCuota AS [Numero Cuota], FechaPago AS [Fecha Pago], Dias, Principal, Interes, Principal + Interes AS Total, SaldoInicial, SaldoFinal, PrincipalPagado, InteresPagado, InteresesXPagar
            FROM ScrCalendarioInversion WHERE ObjInversionID = " + idInversion + " ORDER BY NumeroCuota asc", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }
        #endregion

        #region "Guarda Pago de la Inversión"
        //Ejecuta el procedimiento almacenado para Guardar Pago
        public bool GuardaInversion()
        {
            ClsConexion conne = new ClsConexion();
            SqlConnection conex = new SqlConnection(conne.Conexion);
            conex.Open();
            SqlCommand Com = new SqlCommand("Spd_SvnPagosInversion_Inserta");
            Com.Connection = conex;
            Com.CommandType = CommandType.StoredProcedure;

            SqlParameter prmIdInv = new SqlParameter("@objInversionID", SqlDbType.Int);
            prmIdInv.Value = _Inversion;
            Com.Parameters.Add(prmIdInv);

            SqlParameter prmRecibo = new SqlParameter("@ConsecutivoRecibo", SqlDbType.Int);
            prmRecibo.Value = _NumeroTransferencia;
            Com.Parameters.Add(prmRecibo);

            SqlParameter prmEstadoPagoID = new SqlParameter("@objEstadoPagoID", SqlDbType.Int);
            prmEstadoPagoID.Value = _IdEstadoPago;
            Com.Parameters.Add(prmEstadoPagoID);

            SqlParameter prmFechaPago = new SqlParameter("@FechaPago", SqlDbType.DateTime);
            prmFechaPago.Value = _FechaPago;
            Com.Parameters.Add(prmFechaPago);

            SqlParameter prmIdFormaPago = new SqlParameter("@objFormaPagoID", SqlDbType.Int);
            prmIdFormaPago.Value = _IdFormaPago;
            Com.Parameters.Add(prmIdFormaPago);

            SqlParameter prmMoneda = new SqlParameter("@objMonedaID", SqlDbType.Int);
            prmMoneda.Value = _IdMoneda;
            Com.Parameters.Add(prmMoneda);

            SqlParameter prmDiasTrans = new SqlParameter("@DiasTranscurridos", SqlDbType.Int);
            prmDiasTrans.Value = _DiasTranscurridos;
            Com.Parameters.Add(prmDiasTrans);

            SqlParameter prmDiasMora = new SqlParameter("@DiasMora", SqlDbType.Int);
            prmDiasMora.Value = _DiasMora;
            Com.Parameters.Add(prmDiasMora);

            SqlParameter prmEstadoInv = new SqlParameter("@objEstadoInversionID", SqlDbType.Int);
            prmEstadoInv.Value = _EstadoInversion;
            Com.Parameters.Add(prmEstadoInv);

            SqlParameter prmPrincipal = new SqlParameter("@Principal", SqlDbType.Decimal);
            prmPrincipal.Value = _Principal;
            Com.Parameters.Add(prmPrincipal);

            SqlParameter prmInteresCorriente = new SqlParameter("@InteresCorriente", SqlDbType.Decimal);
            prmInteresCorriente.Value = _InteresCorriente;
            Com.Parameters.Add(prmInteresCorriente);

            SqlParameter prmInteresMora = new SqlParameter("@InteresMoratorio", SqlDbType.Decimal);
            prmInteresMora.Value = _InteresMoratorio;
            Com.Parameters.Add(prmInteresMora);

            SqlParameter prmTotalPagado = new SqlParameter("@TotalPagado", SqlDbType.Decimal);
            prmTotalPagado.Value = _TotalPagado;
            Com.Parameters.Add(prmTotalPagado);

            SqlParameter prmPrincipalAnte = new SqlParameter("@PrincipalAnterior", SqlDbType.Decimal);
            prmPrincipalAnte.Value = _PrincipalAnterior;
            Com.Parameters.Add(prmPrincipalAnte);

            SqlParameter prmPrincipalAct = new SqlParameter("@PrincipalActual", SqlDbType.Decimal);
            prmPrincipalAct.Value = _PrincipalActual;
            Com.Parameters.Add(prmPrincipalAct);

            SqlParameter prmInteresAnt = new SqlParameter("@InteresAnterior", SqlDbType.Decimal);
            prmInteresAnt.Value = _InteresAnterior;
            Com.Parameters.Add(prmInteresAnt);

            SqlParameter prmInteresAct = new SqlParameter("@InteresActual", SqlDbType.Decimal);
            prmInteresAct.Value = _InteresActual;
            Com.Parameters.Add(prmInteresAct);

            SqlParameter prmCodPersona = new SqlParameter("@CodPersonaRealizaPago", SqlDbType.VarChar);
            prmCodPersona.Value = _CodigoPersona;
            Com.Parameters.Add(prmCodPersona);

            SqlParameter prmObservacion = new SqlParameter("@Observacion", SqlDbType.VarChar);
            prmObservacion.Value = _Observacion;
            Com.Parameters.Add(prmObservacion);

            SqlParameter prmUsuarioCreacion = new SqlParameter("@UsuarioCreacion", SqlDbType.VarChar);
            prmUsuarioCreacion.Value = globales.RetornaLogin();
            Com.Parameters.Add(prmUsuarioCreacion);

            SqlParameter prmfechaCrea = new SqlParameter("@FechaCreacion", SqlDbType.DateTime);
            prmfechaCrea.Value = DateTime.Now;
            Com.Parameters.Add(prmfechaCrea);

            SqlParameter prmMaquinaCrea = new SqlParameter("@MaquinaCreacion", SqlDbType.VarChar);
            prmMaquinaCrea.Value = globales.RetornaIP();
            Com.Parameters.Add(prmMaquinaCrea);

            SqlParameter prmNombrePersona = new SqlParameter("@NombrePersonaTransaccion", SqlDbType.VarChar);
            prmNombrePersona.Value = _NombrePersona;
            Com.Parameters.Add(prmNombrePersona);

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

    }
}