using System;

namespace Inheritance
{
    // TODO: Declarar "Magazine" como subclass de Publication
    class Magazine
    {
        private string _publisher;
        private int _pagecount;
        private decimal _price;

        // TODO: base() keyword usada para iniciar el base class
        public Magazine(string name, string publisher, int pagecount, decimal price)
        {
            _publisher = publisher;
        }

        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }
    }
}
