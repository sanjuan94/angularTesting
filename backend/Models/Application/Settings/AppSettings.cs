using backend.Models.Application.Settings.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Application.Settings
{
    public class AppSettings : IAppSettings
    {
        public DataProvider dataProvider { get; set; }
    }

    public class DataProvider
    {
        public string apiKey { get; set; }
    }
}
