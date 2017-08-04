using System.Configuration;

namespace Deepend.Service.Provider.Configuration
{
    class Settings
    {
        public static string ChequeDataXmlPath { get { return ConfigurationManager.AppSettings["ChequeDataXmlPath"]; } } 
    }
}
