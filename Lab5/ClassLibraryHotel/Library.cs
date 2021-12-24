using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Library
    {
        /// <summary>
        /// Словарь читателей
        /// </summary>
        public static Dictionary<int, Reader> Readers { get; } = new Dictionary<int, Reader>();
        /// <summary>
        /// Словарь книг
        /// </summary>
        public static Dictionary<int, Book> Books { get; } = new Dictionary<int, Book>();
        /// <summary>
        /// Список выданных книг
        /// </summary>
        public static List<IssuedBook> IssuedBooks { get; } = new List<IssuedBook>();
    }
}
