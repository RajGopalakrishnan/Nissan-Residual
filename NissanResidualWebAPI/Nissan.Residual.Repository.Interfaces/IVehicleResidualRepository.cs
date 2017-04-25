using System.Collections.Generic;
using NissanResidual.Entities;

namespace Nissan.Residual.Repository.Interfaces
{
    public interface IVehicleResidualRepository
    {
        bool AddVehicleResidual(VehicleResidual vehicleResidual);
        bool UpdateVehicleResidual(VehicleResidual vehicleResidual);
        bool DeleteVehicleResidual(int vehicleResidualId);
        IList<VehicleResidual> GetAllVehicleResiduals();
        VehicleResidual GetVehicleResidualById(int vehicleResidualId);
    }
}
