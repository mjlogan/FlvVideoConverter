using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SunMrm.VideoConversion
{

    public class ConfigHandler : IConfigurationSectionHandler
    {
        public ConfigHandler() { }

        #region IConfigurationSectionHandler Members

        public object Create(object parent, object configContext, System.Xml.XmlNode section)
        {
            ConverterSettings objSettings = new ConverterSettings();
            objSettings.TempVideoPath = section.SelectSingleNode("TempVideoPath").InnerText;
            objSettings.FinalVideoPath = section.SelectSingleNode("FinalVideoPath").InnerText;
            objSettings.ImagePath = section.SelectSingleNode("ImagePath").InnerText;
            objSettings.VideoConverterEnginePath = section.SelectSingleNode("VideoConverterEnginePath").InnerText;

            return objSettings;
        }
        #endregion
    }

    public class ConverterSettings
    {
        public ConverterSettings() { }

        public string TempVideoPath
        {
            get;
            set;
        }
        public string FinalVideoPath
        {
            get;
            set;
        }
        public string ImagePath
        {
            get;
            set;
        }
        public string VideoConverterEnginePath
        {
            get;
            set;
        }
    }
}
