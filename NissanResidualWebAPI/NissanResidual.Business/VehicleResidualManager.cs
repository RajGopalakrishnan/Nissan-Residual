
using System.Collections.Generic;
using Nissan.Residual.Repository.Interfaces;
using NissanResidual.Business.Interfaces;
using NissanResidual.Entities;

namespace NissanResidual.Business
{
    public class VehicleResidualManager : IVehicleResidualManager
    {
        readonly IVehicleResidualRepository _vehicleResidualRepository;

        public VehicleResidualManager(IVehicleResidualRepository vehicleResidualRepository)
        {
            _vehicleResidualRepository = vehicleResidualRepository;
        }
        public bool AddVehicleResidual(VehicleResidual vehicleResidual)
        {
            return _vehicleResidualRepository.AddVehicleResidual(vehicleResidual);
        }

        public bool UpdateVehicleResidual(VehicleResidual vehicleResidual)
        {
            return _vehicleResidualRepository.UpdateVehicleResidual(vehicleResidual);
        }

        public bool DeleteVehicleResidual(int vehicleResidualId)
        {
            return _vehicleResidualRepository.DeleteVehicleResidual(vehicleResidualId);
        }

        public IList<VehicleResidual> GetAllVehicleResiduals()
        {
            return _vehicleResidualRepository.GetAllVehicleResiduals();
        }

        public VehicleResidual GetVehicleResidualById(int vehicleResidualId)
        {
            return _vehicleResidualRepository.GetVehicleResidualById(vehicleResidualId);
        }
    }
}
