using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Deepend.Services.Cheque.Configuration
{
    public class Settings
    {
        public static string ChequeDataXmlPath { get { return ConfigurationManager.AppSettings["ChequeDataXmlPath"]; } }
    }
}