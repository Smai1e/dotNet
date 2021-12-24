using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_lab_4
{
    class IssuedBook : IValidatable
    {
        /// <summary>
        /// Книга
        /// </summary>
        public Books Book { get; set; } = new Books();

        /// <summary>
        /// Читатель
        /// </summary>
        public Reader Reader { get; set; } = new Reader();

        /// <summary>
        /// Дата Выдачи
        /// </summary>
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// Дата возврата
        /// </summary>
        public DateTime ReturnDate { get; set; }

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

        public override string ToString()
        {
            return $"Книга: {Book}\r\nЧитатель: {Reader}\r\nДата выдачи: {IssueDate}\r\nДата возврата: {ReturnDate}\r\n";
        }
    }
}
