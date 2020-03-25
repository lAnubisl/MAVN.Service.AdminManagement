﻿using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.AdminManagement.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
        public string DbConnectionString { get; set; }
    }
}
