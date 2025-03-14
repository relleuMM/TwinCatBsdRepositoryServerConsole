using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tc3_TcBsd_CopyLocalRepository
{
    internal class ApplikationSettings
    {
        public WebServer webserver {  get; set; }
        public Repository repository { get; set; }

    }

    internal class WebServer
    {
        public uint Port { get; set; }
        public WebServer(uint port)
        {
            this.Port = port;
        }
    }
    internal class Repository
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }


        public Repository(string name, string url, string path)
        {
            this.Name = name;
            this.Url = url;
            this.Path = path;
        }
    }
}
