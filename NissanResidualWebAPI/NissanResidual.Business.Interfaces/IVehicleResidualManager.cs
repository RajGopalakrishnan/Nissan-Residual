using System;
using System.Collections.Generic;
using System.Text;
using NissanResidual.Entities;

namespace NissanResidual.Business.Interfaces
{
    public interface IVehicleResidualManager
    {
        bool AddVehicleResidual(VehicleResidual vehicleResidual);
        bool UpdateVehicleResidual(VehicleResidual vehicleResidual);
        bool DeleteVehicleResidual(int vehicleResidualId);
        IList<VehicleResidual> GetAllVehicleResiduals();
        VehicleResidual GetVehicleResidualById(int vehicleResidualId);
    }
}
