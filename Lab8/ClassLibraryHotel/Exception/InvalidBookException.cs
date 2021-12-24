using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exception
{
    [Serializable]
    public class InvalidBookException : System.Exception
    {
        public InvalidBookException()
        { }

        public InvalidBookException(string message) : base(message)
        { }

        public InvalidBookException(string message, System.Exception inner) : base(message, inner)
        { }

        protected InvalidBookException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        { }
    }
}
