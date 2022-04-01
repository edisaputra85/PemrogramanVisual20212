using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_App
{
    class Connection
    {
        //protected String conString = "server=localhost; database=dbpos; uid=root; SslMode = none; password=";
        protected String conString = ConfigurationManager.ConnectionStrings["dbpos"].ConnectionString;
    }
}
