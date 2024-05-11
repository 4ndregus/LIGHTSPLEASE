using System.Configuration;

namespace DataAccess
{
    public class Connection
    {
        public string get()
        {
            return ConfigurationManager.ConnectionStrings["myConString"].ToString();
        }
    }
}
