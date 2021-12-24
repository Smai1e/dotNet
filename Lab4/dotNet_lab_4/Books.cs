using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_lab_4 
{
    class Books : IValidatable
    {
        public Books()
        {

        }

        public Books(string name, decimal pledgeCost, decimal rentalCost, JenreEnum janre)
        {
            Name = name;
            PledgeCost = pledgeCost;
            RentalCost = rentalCost;
            Jenre = janre;
        }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Автор
        /// </summary>
        public Author Author { get; set; } = new Author();

        /// <summary>
        /// Залоговая стоимость
        /// </summary>
        public decimal PledgeCost { get; set; } = 100;

        /// <summary>
        /// Стоимость проката
        /// </summary>
        public decimal RentalCost { get; set; } = 100;

        /// <summary>
        /// Жанр
        /// </summary>
        public JenreEnum Jenre { get; set; } = JenreEnum.Fantasy;

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name)) return false;
                if (PledgeCost < 0) return false;
                if (RentalCost < 0) return false;
                if (Author == null) return false;
                return true;
            }
        }


        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        public override string ToString()
        {
            return $"Название: {Name}\r\nЖанр: {Jenre}\r\nАвтор: {Author}\r\nЗалоговая стоимость: {PledgeCost}\r\nСтоимость проката: {RentalCost}\r\n";
        }
    }
}
