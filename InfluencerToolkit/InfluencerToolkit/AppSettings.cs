using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;

namespace InfluencerToolkit
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccesToken { get; set; }

        public AppSettings()
        {
            LastWindowLocation = new Point(30, 80);
            LastWindowSize = new Size(500, 800);
            RememberUser = false;
            LastAccesToken = null;
        }

        public void SaveToFile()
        {

            using (Stream stream = new FileStream(@"C:\InfluencerAppSettings.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }

        }

        public static AppSettings LoadFromFile()
        {
            AppSettings storedAppSettings = new AppSettings();
            using (Stream stream = new FileStream(@"C:\InfluencerAppSettings.xml",FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                storedAppSettings = serializer.Deserialize(stream) as AppSettings;
            }
            return storedAppSettings;


        }

    }
}
