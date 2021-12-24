using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Автор
    /// </summary>
    [Serializable]
    public class Author : Human
    {
        public Author()
        {

        }

        public Author(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        public override string ToString()
        {
            return $"Фамилия: {LastName} \r\nИмя: {FirstName} \r\nОтчество: {MiddleName} \r\n";
        }
    }
}
