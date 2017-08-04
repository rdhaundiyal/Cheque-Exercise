using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
namespace Deepend.Core.Exception
{
  public  class SerializationException:System.Exception
  {
      private const string SerializationExceptionMessage = "An error occured while serializing the object.";
      public SerializationException():base(SerializationExceptionMessage)
      {
          
      }
      public SerializationException(string message)
          : base(message)
      {

      }
    }
}
