using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Sistema
{
    class DetPago
    {
        private Medio_de_Pago _Medio_de_Pago;
        private DateTime _FechaPago;
        private int _MontoPago;
               
        public Medio_de_Pago Medio_De_Pago
        {
            get
            {
                return _Medio_de_Pago;
            }
            set
            {
                _Medio_de_Pago = value;
            }
        }

        public DetPago()
        {

        }
       
        public DateTime FechaPago
        {
            get
            {
                return _FechaPago;
            }
            set
            {
                _FechaPago = value;
            }
        }
        public int MontoPago
        {
            get
            {
                return _MontoPago;
            }
            set
            {
                _MontoPago = value;
            }
        }
        public DetPago(Medio_de_Pago parMedio_de_Pago, DateTime parFechapago, int parMontoPago)
        {
            this._Medio_de_Pago = parMedio_de_Pago;
            this._FechaPago = parFechapago;
            this._MontoPago = parMontoPago;
        }
    }
}
