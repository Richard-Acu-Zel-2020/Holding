using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holding
{
    class ClsValidaCaracteres
    {
        public enum TipoValidacion
        {
            Letras,
            Numerico,
            Telefono,
            SoloLetras,
            SoloNumeros,
            Comillas,
            Espacios,
            LetrasNumerosEspacio,
            LetrasNumerosEspacioPunto,
            LetrasEspacio,
            NumerosEspacio,
            NumerosPunto,
            LetrasGuion,
            LetrasNumerosArroba,
            LetrasNumerosEspacioGuion,
            NumeroGuion,
            LetrasNumerosGuion,
            LetrasNumeros,
            Direccion,
            Horario,
            Email,
            LetrasEspacioComillas,
            LetrasNumerosEspacioPecla
        }

        #region "Funcion para validar"

        //FUNCION QUE VERIFICA SI EL CARACTER INGRESADO ES VALIDO.
        public bool CaracterValido(Int32 Caracter, TipoValidacion tipoValida)
        {

            if (Caracter == 8)
                return true;

            switch (tipoValida)
            {
                    //Valida que solo se ingresen letras
                case TipoValidacion.Letras:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }
                //Valida que solo se ingresen letras y el guion
                case TipoValidacion.LetrasGuion:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter == 45 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }

                case TipoValidacion.Email:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter >= 48 && Caracter <= 57 || Caracter == 64 || Caracter == 46 || Caracter == 45 || Caracter == 47 || Caracter == 95)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.Horario:
                    {
                        if (Caracter >= 48 && Caracter <= 58 || Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter == 45 || Caracter == 32 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }
                //Valida que solo se ingresen letras espacios y guion
                case TipoValidacion.LetrasNumerosEspacioGuion:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter >= 48 && Caracter <= 57 || Caracter == 32 || Caracter == 45 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.LetrasNumerosGuion:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter >= 48 && Caracter <= 57  || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.LetrasNumerosEspacio:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter >= 48 && Caracter <= 57 || Caracter == 32 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }

                case TipoValidacion.LetrasNumerosEspacioPunto:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter >= 48 && Caracter <= 57 || Caracter == 32 || Caracter == 46 || Caracter == 45 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }

                case TipoValidacion.LetrasNumeros:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter >= 48 && Caracter <= 57 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.LetrasNumerosArroba:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter >= 48 && Caracter <= 57 || Caracter == 64 || Caracter == 45 || Caracter == 95 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.LetrasEspacio:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter == 32 || Caracter == 241 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.Numerico:
                    {
                        if (Caracter >= 48 && Caracter <= 57 || Caracter == 46)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.NumeroGuion:
                    {
                        if (Caracter >= 48 && Caracter <= 57 || Caracter == 46 || Caracter == 45)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.Comillas:
                    {
                        if (Caracter == 34 || Caracter == 44 || Caracter == 59 || Caracter == 43)
                            return false;
                        else
                            return true;
                    }
                case TipoValidacion.Telefono:
                    {
                        if ((Caracter >= 48 && Caracter <= 57) || Caracter == 40 || Caracter == 41 || Caracter == 45)

                            return true;
                        else if (Caracter == 56 || Caracter == 57 || Caracter == 109)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.SoloNumeros:
                    {
                        if (Caracter >= 48 && Caracter <= 57)
                            return true;
                        else
                            return false;
                    }

                   case TipoValidacion.Espacios:
                    {
                        if (Caracter == 32)
                            return false;
                        else
                            return true;
                    }

                case TipoValidacion.NumerosEspacio:
                    {
                        if (Caracter >= 48 && Caracter <= 57 || Caracter == 45)
                            return true;
                        else
                            return false;
                    }
                case TipoValidacion.LetrasEspacioComillas:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter == 241 || Caracter == 32 || Caracter == 39 || Caracter == 209)
                            return true;
                        else
                            return false;
                    }
                default:
                    {
                        return false;
                    }

                case TipoValidacion.Direccion:
                    {
                            return true;
                       
                    }
                case TipoValidacion.LetrasNumerosEspacioPecla:
                    {
                        if (Caracter >= 65 && Caracter <= 90 || Caracter >= 97 && Caracter <= 122 || Caracter == 241 || Caracter >= 48 && Caracter <= 57 || Caracter == 32 || Caracter == 47)
                            return true;
                        else
                            return false;
                    }
            }
        }
        #endregion
 
    }
}
