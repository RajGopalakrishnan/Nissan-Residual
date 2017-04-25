using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Nissan.Residual.Repository.Interfaces;
using NissanResidual.Entities;

namespace NissanResidual.Repository
{
    public class VehicleResidualRepository : BaseRepository, IVehicleResidualRepository
    {
        public bool AddVehicleResidual(VehicleResidual vehicleResidual)
        {
            throw new NotImplementedException();
        }

        public bool UpdateVehicleResidual(VehicleResidual vehicleResidual)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVehicleResidual(int vehicleResidualId)
        {
            throw new NotImplementedException();
        }

        public IList<VehicleResidual> GetAllVehicleResiduals()
        {
            IList<VehicleResidual> customerList = DbConnection.Query<VehicleResidual>(@"SELECT * FROM StagingForecast.VehicleResidual").ToList();
            return customerList;
        }

        public VehicleResidual GetVehicleResidualById(int vehicleResidualId)
        {
            var vehicleResidual = DbConnection.Query<VehicleResidual>(@"
                    SELECT *
                    FROM StagingForecast.VehicleResidual
		    WHERE VehicleResidualId = @VehicleResidualId", new { VehicleResidualId = vehicleResidualId }).FirstOrDefault();

            return vehicleResidual;
        }
    }
}
