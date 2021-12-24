using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHotel.Exception
{
    [Serializable]
    public class InvalidReaderException : System.Exception
    {
        public InvalidReaderException()
        { }

        public InvalidReaderException(string message) : base(message)
        { }

        public InvalidReaderException(string message, System.Exception inner) : base(message, inner)
        { }

        protected InvalidReaderException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        { }
    }
}