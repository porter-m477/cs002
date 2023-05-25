using System;

namespace Inheritance
{
    class Publication
    {
        private string _name;

        public Publication(string name, int pagecount, decimal price)
        {
            _name = name;
            PageCount = pagecount;
            Price = price;
        }

        // Propiedad PageCount no tiene backing field
        public int PageCount
        {
            get; set;
        }

        public decimal Price
        {
            get; set;
        }

        public string Name
        {
            // return name
            get { return _name; }

            // usar el setter para validar el value de la nueva propiedad
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be blank");
                }
                _name = value;
            }
        }

        // TODO: "virtual" keyword usada para indicar que un method
        // puede ser overridden por subclasses para personalizar comportamiento
        public virtual string GetDescripcion()
        {
            return $"{Name}, {PageCount}";
        }

    }
}