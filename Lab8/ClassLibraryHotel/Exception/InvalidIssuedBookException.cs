using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exception
{
    [Serializable]
    public class InvalidIssuedBookException : System.Exception
    {
        public InvalidIssuedBookException()
        { }

        public InvalidIssuedBookException(string message) : base(message)
        { }

        public InvalidIssuedBookException(string message, System.Exception inner) : base(message, inner)
        { }

        protected InvalidIssuedBookException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        { }
    }
}
