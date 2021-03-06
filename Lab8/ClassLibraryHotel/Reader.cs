using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Читатель
    /// </summary>
    [Serializable]
    public class Reader : Human
    {
        /// <summary>
        /// Уникальный идентификатор нового читателя (аналог автоинкремента)
        /// </summary>
        private static int _newReaderId;

        public static int NewReaderId
        {
            get
            {
                _newReaderId++;
                return _newReaderId;
            }
            set
            {
                _newReaderId = value;
            }
        }
        /// <summary>
        /// Уникальный идентификатор читателя
        /// </summary>
        public int ReaderId { get; set; }

        public Reader()
        {
            ReaderId = NewReaderId;
        }

        public Reader(string firstName, string lastName, string middleName, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Address = address;
            PhoneNumber = phoneNumber;
            ReaderId = NewReaderId;
        }

        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        public override string ToString()
        {
            return $"Фамилия: {LastName} \r\nИмя: {FirstName} \r\nОтчество: {MiddleName} \r\nАдрес: {Address} \r\nНомер телефона: {PhoneNumber} \r\n";
        }
    }
}
