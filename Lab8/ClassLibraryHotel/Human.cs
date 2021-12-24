using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Human : IValidatable
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; } = "";

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; } = "";

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; } = "";

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (string.IsNullOrWhiteSpace(Address)) return false;
                if (string.IsNullOrWhiteSpace(PhoneNumber)) return false;
                return true;
            }
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
