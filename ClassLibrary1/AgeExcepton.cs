using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AgeExcepton : Exception
    {
        public AgeExcepton() : base("Alder for lav")
        {
        }

        public AgeExcepton(string message) : base(message)
        {

        }

        public AgeExcepton(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgeExcepton(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
