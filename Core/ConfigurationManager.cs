using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ConfigurationManager
    {
        private static AppConfiguration? _appConfiguration { get; set; }
        public static string BaseUrl => _appConfiguration.BaseUrl;

        public ConfigurationManager() 
        {
            _appConfiguration = GetConfiguration();
        }

        public AppConfiguration GetConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var appConfiguration = new AppConfiguration();
            configuration.Bind(appConfiguration);

            return appConfiguration;
        }
    }
}
