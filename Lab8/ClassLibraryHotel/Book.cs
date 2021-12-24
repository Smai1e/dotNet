using System;

namespace ClassLibrary
{
    /// <summary>
    /// Книга
    /// </summary>
    [Serializable]
    public class Book : IValidatable
    {
        private static int _newBookId;

        public static int NewBookId
        {
            get
            {
                _newBookId++;
                return _newBookId;
            }
            set
            {
                _newBookId = value;
            }
        }
        /// <summary>
        /// Уникальный идентификатор книги
        /// </summary>
        public int BookId { get; set; }

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

        public Book()
        {
            BookId = NewBookId;
        }

        public Book(string name, decimal pledgeCost, decimal rentalCost, JenreEnum janre, Author author)
        {
            Name = name;
            PledgeCost = pledgeCost;
            RentalCost = rentalCost;
            Jenre = janre;
            Author = author;
            BookId = NewBookId;
        }

        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        public override string ToString()
        {
            return $"Название: {Name} \r\nЖанр: {Jenre} \r\nАвтор: {Author} \r\nЗалоговая стоимость: {PledgeCost} \r\nСтоимость проката: {RentalCost} \r\n";
        }
    }
}
