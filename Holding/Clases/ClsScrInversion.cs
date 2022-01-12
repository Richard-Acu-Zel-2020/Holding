using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Holding
{
    class ClsScrInversion
    {
        ClsVariablesGoblales globales = new ClsVariablesGoblales();

        int _IdInversion = 0;
        String _Numero = "";
        int _IdCliente = 0;
        String _NombreCliente = "";
        DateTime _FechaOtorgamiento;
        DateTime _FechaVencimiento;
        DateTime _FechaUltimoPago;
        Decimal _TasaInteresCorriente = 0;
        Decimal _TasaInteresMoratorio = 0;
        Decimal _TasaComision = 0;
        Decimal _Monto = 0;
        int _Plazo = 0;
        int _PeriodoGracia = 0;
        int _IdEstadoInversion = 0;
        int _IdFormaPagoInteres = 0;
        int _IdFormaPagoPrincipal = 0;
        int _IdMoneda = 0;
        String _DiasDelMes = "";
        int _BaseAnual = 0;
        Decimal _PrincipalPagado = 0;
        Decimal _InteresPagado = 0;
        Decimal _MoraPagada = 0;
        Decimal _ComisionPagada = 0;
        Decimal _SaldoPrincipal = 0;
        Decimal _SaldoInteres = 0;
        Decimal _SaldoMora = 0;
        Decimal _SaldoComision = 0;
        Decimal _CuotaVencida = 0;
        String _UsuarioCreacion = "";
        DateTime _FechaCreacion;
        String _MaquinaCreacion = "";
        String _UsuarioModificacion = "";
        DateTime _FechaModificacion;
        String _MaquinaModificacion = "";
        String _UsuarioAnulacion = "";
        DateTime _FechaAnulacion;
        String _MaquinaAnulacion = "";


        #region Constructores
        public ClsScrInversion() { }

        public ClsScrInversion(int IdInversion, String Numero, int IdCliente, String NombreCliente, DateTime FechaOtorgamiento, DateTime FechaVencimiento, DateTime FechaUltimoPago, Decimal TasaInteresCorriente, Decimal TasaInteresMoratorio, Decimal TasaComision,
        Decimal Monto, int Plazo, int PeriodoGracia, int IdEstadoInversion, int IdFormaPagoInteres, int IdFormaPagoPrincipal, int IdMoneda, String DiasDelMes, int BaseAnual, Decimal PrincipalPagado, Decimal InteresPagado, Decimal MoraPagada,
        Decimal ComisionPagada, Decimal SaldoPrincipal, Decimal SaldoInteres, Decimal SaldoMora, Decimal SaldoComision, Decimal CuotaVencida, String UsuarioCreacion, DateTime FechaCreacion, String MaquinaCreacion, String UsuarioModificacion,
        DateTime FechaModificacion, String MaquinaModificacion, String UsuarioAnulacion, DateTime FechaAnulacion, String MaquinaAnulacion) 
        {
            IdInversion = _IdInversion;
            Numero = _Numero;
            IdCliente = _IdCliente;
            NombreCliente = _NombreCliente;
            FechaOtorgamiento = _FechaOtorgamiento;
            FechaVencimiento = _FechaVencimiento;
            FechaUltimoPago = _FechaUltimoPago;
            TasaInteresCorriente = _TasaInteresCorriente;
            TasaInteresMoratorio = _TasaInteresMoratorio;
            TasaComision = _TasaComision;
            Monto = _Monto;
            Plazo = _Plazo;
            PeriodoGracia = _PeriodoGracia;
            IdEstadoInversion = _IdEstadoInversion;
            IdFormaPagoInteres = _IdFormaPagoInteres;
            IdFormaPagoPrincipal = _IdFormaPagoPrincipal;
            IdMoneda = _IdMoneda;
            DiasDelMes = _DiasDelMes;
            BaseAnual = _BaseAnual;
            PrincipalPagado = _PrincipalPagado;
            InteresPagado = _InteresPagado;
            MoraPagada = _MoraPagada;
            ComisionPagada = _ComisionPagada;
            SaldoPrincipal = _SaldoPrincipal;
            SaldoInteres = _SaldoInteres;
            SaldoMora = _SaldoMora;
            SaldoComision = _SaldoComision;
            CuotaVencida = _CuotaVencida;
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

        #region Propiedades
        public int IdInversion
        {
            get { return _IdInversion; }
            set { _IdInversion = value; }
        }

        public string Numero 
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public int IdCliente 
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public string NombreCliente
        {
            get { return _NombreCliente; }
            set { _NombreCliente = value; }
        }

        public DateTime FechaOtorgamiento 
        {
            get { return _FechaOtorgamiento; }
            set { _FechaOtorgamiento = value; } 
        }

        public DateTime FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set { _FechaVencimiento = value; }
        }

        public DateTime FechaUltimoPago
        {
            get { return _FechaUltimoPago; }
            set { _FechaUltimoPago = value; }
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


        public decimal TasaComision
        {
            get { return _TasaComision; }
            set { _TasaComision = value; }
        }

        public decimal Monto 
        {
            get { return _Monto; }
            set { _Monto = value; }
        }

        public int Plazo 
        {
            get { return _Plazo; }
            set { _Plazo = value; }
        }

        public int PeriodoGracia
        {
            get { return _PeriodoGracia; }
            set { _PeriodoGracia = value; }
        }

        public int IdEstadoInversion
        {
            get { return _IdEstadoInversion; }
            set { _IdEstadoInversion = value; }
        }

        public int IdFormaPagoInteres 
        {
            get { return _IdFormaPagoInteres; }
            set { _IdFormaPagoInteres = value; }
        }

        public int IdFormaPagoPrincipal 
        {
            get { return _IdFormaPagoPrincipal; }
            set { _IdFormaPagoPrincipal = value; } 
        }

        public int IdMoneda
        {
            get { return _IdMoneda; }
            set { _IdMoneda = value; }
        }

        public string DiasDelMes 
        {
            get { return _DiasDelMes; }
            set { _DiasDelMes = value; }
        }

        public int BaseAnual 
        {
            get { return _BaseAnual; }
            set { _BaseAnual = value; }
        }

        public decimal PrincipalPagado 
        {
            get { return _PrincipalPagado; }
            set { _PrincipalPagado = value; } 
        }

        public decimal InteresPagado
        {
            get { return _InteresPagado; }
            set { _InteresPagado = value; }
        }

        public decimal MoraPagada 
        {
            get { return _MoraPagada; }
            set { _MoraPagada = value; }
        }

        public decimal ComisionPagada
        {
            get { return _ComisionPagada; }
            set { _ComisionPagada = value; }
        }

        public decimal SaldoPrincipal 
        {
            get { return _SaldoPrincipal; }
            set { _SaldoPrincipal = value; }
        }

        public decimal SaldoInteres 
        {
            get { return _SaldoInteres; }
            set { _SaldoInteres = value; }
        }

        public decimal SaldoMora 
        {
            get { return _SaldoMora; }
            set { _SaldoMora = value; }
        }

        public decimal SaldoComision 
        {
            get { return _SaldoComision; }
            set { _SaldoComision = value; }
        }

        public decimal CuotaVencida
        {
            get { return _CuotaVencida; }
            set { _CuotaVencida = value; }
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

        #region Cargar Datos
        //Listar las Inversiones
        public DataTable Inversiones()
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT SI.ID, SI.Numero, ISNULL(SC.Nombre1,'') + ' ' + ISNULL(SC.Nombre2,'') + ' ' + ISNULL(SC.Apellido1,'') + ' ' + ISNULL(SC.Apellido2,'') AS Cliente, 
            --SI.FechaOtorgamiento, SI.FechaVencimiento, SI.FechaUltimoPago, SI.TasaInteresCorriente, SI.TasaInteresMoratorio, SI.TasaComision, 
            SI.Monto, SI.Plazo, 
            --SI.PeriodoGracia, 
            SV1.Valor [Estado Inversion],
            --SV2.Valor PagoInteres, SV3.Valor PagoPrincipal, 
            SV4.Valor Moneda, 
            --SI.DiasDelMes, SI.BaseAnual, 
            --SI.PrincipalPagado,
            SI.InteresPagado as [Interes Pagado], SI.MoraPagada AS [Mora Pagada], SI.ComisionPagada AS [Comision Pagada], 
            SI.SaldoPrincipal As [Saldo Principal], SI.SaldoIntereses [Saldo Interes], SI.SaldoMora [Saldo Mora], 
            --SI.SaldoComision, 
            SI.CuotaVencida [Cuota Vencida],
            SV4.ID AS idMoneda
            FROM ScrInversion SI 
            INNER JOIN StbCliente SC ON SI.ObjClienteID=SC.ID
            INNER JOIN StbCatalogoValor SV1 ON SI.objEstadoInversionID=SV1.ID
            INNER JOIN StbCatalogoValor SV2 ON SI.objFormaPagoInteresID=SV2.ID 
            INNER JOIN StbCatalogoValor SV3 ON SI.objFormaPagoPrincipalID=SV3.ID
            INNER JOIN StbCatalogoValor SV4 ON SI.objMonedaID = SV4.ID
            ORDER BY SI.Numero asc", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }

        public DataTable BuscarXNombre(String Nombre)
        {
            ClsConexion con = new ClsConexion();
            DataTable tabla = new DataTable();
            tabla.Clear();
            SqlConnection Conne = new SqlConnection(con.Conexion);
            Conne.Open();
            SqlDataAdapter result = new SqlDataAdapter(@"SELECT SI.ID, SI.Numero, ISNULL(SC.Nombre1,'') + ' ' + ISNULL(SC.Nombre2,'') + ' ' + ISNULL(SC.Apellido1,'') + ' ' + ISNULL(SC.Apellido2,'') AS Cliente, 
            --SI.FechaOtorgamiento, SI.FechaVencimiento, SI.FechaUltimoPago, SI.TasaInteresCorriente, SI.TasaInteresMoratorio, SI.TasaComision, 
            SI.Monto, SI.Plazo, 
            --SI.PeriodoGracia, 
            SV1.Valor [Estado Inversion],
            --SV2.Valor PagoInteres, SV3.Valor PagoPrincipal, 
            SV4.Valor Moneda, 
            --SI.DiasDelMes, SI.BaseAnual, 
            --SI.PrincipalPagado,
            SI.InteresPagado as [Interes Pagado], SI.MoraPagada AS [Mora Pagada], SI.ComisionPagada AS [Comision Pagada], 
            SI.SaldoPrincipal As [Saldo Principal], SI.SaldoIntereses [Saldo Interes], SI.SaldoMora [Saldo Mora], 
            --SI.SaldoComision, 
            SI.CuotaVencida [Cuota Vencida],
            SV4.ID AS idMoneda
            FROM ScrInversion SI 
            INNER JOIN StbCliente SC ON SI.ObjClienteID=SC.ID
            INNER JOIN StbCatalogoValor SV1 ON SI.objEstadoInversionID=SV1.ID
            INNER JOIN StbCatalogoValor SV2 ON SI.objFormaPagoInteresID=SV2.ID 
            INNER JOIN StbCatalogoValor SV3 ON SI.objFormaPagoPrincipalID=SV3.ID
            INNER JOIN StbCatalogoValor SV4 ON SI.objMonedaID = SV4.ID
            WHERE SC.Nombre1 like '" + Nombre + "%' ORDER BY SI.Numero asc", Conne);
            result.Fill(tabla);
            result.Dispose();
            Conne.Dispose();
            Conne.Close();
            return tabla;
        }
        #endregion
    }
}
