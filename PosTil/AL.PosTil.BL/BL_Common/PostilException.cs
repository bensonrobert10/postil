using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AL.PosTil.BL
{
    [global::System.Serializable]
    public class PostilException : Exception
    {
        public PostilException() { }
        public PostilException(string message) : base(message) { }
        public PostilException(string message, Exception inner) : base(message, inner) { }
        protected PostilException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
