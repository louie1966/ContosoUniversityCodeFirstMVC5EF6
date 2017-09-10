using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.DAL {
    public class SchoolConfiguration : DbConfiguration {
        public SchoolConfiguration() {
            //SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());

            // Uncomment next lines if these are not present in Global.asax

            //DbInterception.Add(new SchoolInterceptorTransientErrors());
            //DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}