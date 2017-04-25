using System;
using System.Data;
using System.Data.SqlClient;

namespace NissanResidual.Repository
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection DbConnection;
        public BaseRepository()
        {
            var stagingForecastConnectionString = "Data Source=irv-dev-vimsdb1;Initial Catalog=StagingForecast;Integrated Security=True";
            DbConnection = new SqlConnection(stagingForecastConnectionString);
        }

        public void Dispose()
        {
            DbConnection.Dispose();
        }
    }
}
