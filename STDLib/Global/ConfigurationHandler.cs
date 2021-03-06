﻿using ChaseLabs.CLConfiguration.List;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChaseLabs.Games.SWF.STDLib.Global
{
    public class ConfigurationHandler
    {
        private static ConfigurationHandler _singleton;
        public static ConfigurationHandler Singleton
        {
            get
            {
                if (_singleton == null) _singleton = new ConfigurationHandler();
                return _singleton;
            }
        }

        public ConfigManager manager;

        private ConfigurationHandler()
        {
            manager = new ConfigManager(Values.ConfigFilePath);
            manager.Add(new CLConfiguration.Object.Config("Web UI Port", "5050", manager));
        }

    }
}
