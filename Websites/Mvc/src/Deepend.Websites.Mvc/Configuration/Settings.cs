﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Deepend.Websites.Mvc.Configuration
{
    public class Settings
    {
        public static string ServiceBaseUrl { get { return ConfigurationManager.AppSettings["ServiceBaseUrl"]; } }
    }
}