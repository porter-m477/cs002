using System;

namespace Cuentas
{
    class Cuenta
    {   
        private string _noCuenta;
        private string _nombre;
        private string _tipoCuenta;
        private long _dpi;
        private string _nacionalidad;
        private string _direccion;
        private int _saldo;

        public Cuenta(string noCuenta, string nombre, string tipoCuenta, long dpi, string nacionalidad, string direccion, int saldo)
        {
            _noCuenta     = noCuenta;
            _nombre       = nombre;
            _tipoCuenta   = tipoCuenta;
            _dpi          = dpi;
            _nacionalidad = nacionalidad;
            _direccion    = direccion;
            _saldo        = saldo;

        }

        public string NoCuenta
        {
            get => _noCuenta;
            set => _noCuenta = value;
        }
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public string TipoCuenta
        {
            get => _tipoCuenta;
            set => _tipoCuenta = value;
        }
        public long Dpi
        {
            get => _dpi;
            set => _dpi = value;
        }
        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = value;
        }
        public string Direccion
        {
            get => _direccion;
            set => _direccion = value;
        }
        public int Saldo
        {
            get => _saldo;
            set => _saldo = value;
        }
        public int Deposito(int monto)
        {
            _saldo = _saldo + monto;
            return monto;
        }
        public int Retiro(int monto)
        {
            _saldo = _saldo - monto;
            return monto;
        }
    }
}