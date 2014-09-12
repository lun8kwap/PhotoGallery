using System.Configuration;
using System.Data.SqlClient;
using System.Web.Management;

namespace PhotoGallery.EF
{
    public class ApplicationServices
    {
        readonly static string DefaultConnectionString = ConfigurationManager.AppSettings["DefaultConnectionString"];
        readonly static string ConnectionString = ConfigurationManager.ConnectionStrings[DefaultConnectionString].ConnectionString;
        readonly static SqlConnectionStringBuilder MyBuilder = new SqlConnectionStringBuilder(ConnectionString);

        public static void InstallServices(SqlFeatures sqlFeatures)
        {
            SqlServices.Install(MyBuilder.InitialCatalog, sqlFeatures, ConnectionString);
        }

        public static void UninstallServices(SqlFeatures sqlFeatures)
        {
            SqlServices.Uninstall(MyBuilder.InitialCatalog, sqlFeatures, ConnectionString);
        }
    }
}
