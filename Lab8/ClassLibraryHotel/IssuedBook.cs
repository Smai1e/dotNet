using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Выданные книги
    /// </summary>
    public class IssuedBook : IValidatable
    {
        /// <summary>
        /// Книга
        /// </summary>
        public Book Book { get; set; }

        /// <summary>
        /// Читатель
        /// </summary>
        public Reader Reader { get; set; }

        /// <summary>
        /// Дата Выдачи
        /// </summary>
        public DateTime IssueDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Дата возврата
        /// </summary>
        public DateTime ReturnDate { get; set; } = DateTime.Now;

        public bool IsValid
        {
            get
            {
                if (IssueDate == null) return false;
                if (ReturnDate == null) return false;
                if (Book == null) return false;
                if (Reader == null) return false;
                return true;
            }
        }

        public IssuedBook()
        {

        }

        public IssuedBook(Book book, Reader reader, DateTime issueDate, DateTime returnDate)
        {
            Book = book;
            Reader = reader;
            IssueDate = issueDate;
            ReturnDate = returnDate;
        }
        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        public override string ToString()
        {
            return $"Книга: {Book} \r\nЧитатель: {Reader} \r\nДата выдачи: {IssueDate} \r\nДата возврата: {ReturnDate} \r\n";
        }
    }
}
