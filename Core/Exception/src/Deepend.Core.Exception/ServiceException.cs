﻿namespace Deepend.Core.Exception
{
    public class ServiceException:System.Exception
    {
        private const string ServiceExceptionMessage = "An error occured while processing your request";
        public ServiceException()
            : base(ServiceExceptionMessage)
      {
          
      }
      public ServiceException(string message)
          : base(message)
      {

      } 
    }
}