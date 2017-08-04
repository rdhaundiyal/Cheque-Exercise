﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deepend.Core.Exception
{
    class ConversionException:System.Exception
    {
        private const string ConversionExceptionMessage = "An error occured while converting item";
        public ConversionException()
            : base(ConversionExceptionMessage)
      {
          
      }
         public ConversionException(string message)
          : base(message)
      {

      }
    }
}
