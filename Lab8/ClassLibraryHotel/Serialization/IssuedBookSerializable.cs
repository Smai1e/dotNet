using System;

namespace ClassLibrary.Serialization
{
    [Serializable]
    public class IssuedBookSerializable
    {
        public int BookId { get; set; }
        public int ReaderId { get; set; }
        /// <summary>
        /// Дата выдачи книги
        /// </summary>
        public DateTime IssueDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата возврата книги
        /// </summary>
        public DateTime ReturnDate { get; set; } = DateTime.Now;
    }
}
