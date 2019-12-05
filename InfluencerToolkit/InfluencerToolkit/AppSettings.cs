using System;
using System.Drawing;
using System.IO;
using System.Security.Permissions;
using System.Xml.Serialization;

namespace InfluencerToolkit
{
    public class AppSettings
    {
        public static readonly string r_SettingsFilePath = @"C:\Users\Public\InfluencerAppSettings.xml";
        
        public Point LastWindowLocation { get; set; }
        
        public Size LastWindowSize { get; set; }
        
        public bool RememberUser { get; set; }
        
        public string LastAccesToken { get; set; }

        private AppSettings()
        {
            LastWindowLocation = new Point(30, 80);
            LastWindowSize = new Size(900, 540);
            RememberUser = false;
            LastAccesToken = null;
        }

        public static AppSettings LoadFromFileOrInit()
        {
            AppSettings storedAppSettings = new AppSettings();
            if (File.Exists(r_SettingsFilePath))
            {
                using (Stream stream = new FileStream(r_SettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(storedAppSettings.GetType());
                    storedAppSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return storedAppSettings;
        }
        
        public static AppSettings GetDefaultSettings()
        {
            return new AppSettings();
        }

        public void SaveToFile()
        {
            FileIOPermission fileIOPerm = new FileIOPermission(FileIOPermissionAccess.Write, r_SettingsFilePath);
            if (File.Exists(r_SettingsFilePath))
            {
                using (Stream stream = new FileStream(r_SettingsFilePath, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                 using (Stream stream = new FileStream(r_SettingsFilePath, FileMode.CreateNew))
                 {
                     XmlSerializer serializer = new XmlSerializer(this.GetType());
                     serializer.Serialize(stream, this);
                 }
            }
        }
    }
}
