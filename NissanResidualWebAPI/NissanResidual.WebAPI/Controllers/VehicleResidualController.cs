using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NissanResidual.Business.Interfaces;
using NissanResidual.Entities;

namespace NissanResidual.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/VehicleResidual")]
    public class VehicleResidualController : Controller
    {
        IVehicleResidualManager _vehicleResidualManager;
        
        public VehicleResidualController(IVehicleResidualManager vehicleResidualManager) {  
            _vehicleResidualManager = vehicleResidualManager;  
        }  
        // GET<td style="border<td style="border: 1px dashed #ababab;"> 1px dashed #ababab;"> api/vehicleresidual  
        [HttpGet]  
        public IEnumerable <VehicleResidual> Get()
        {
            return _vehicleResidualManager.GetAllVehicleResiduals();
        }  
        // GET api/vehicleresidual/5  
        [HttpGet("{id}")]  
        public VehicleResidual Get(int id) {  
            return _vehicleResidualManager.GetVehicleResidualById(id);  
        }  
        // POST api/vehicleresidual  
        [HttpPost]  
        public void Post([FromBody] VehicleResidual vehicleResidual) {  
            _vehicleResidualManager.AddVehicleResidual(vehicleResidual);  
        }  
        // PUT api/vehicleresidual/5  
        [HttpPut("{id}")]  
        public void Put(int id, [FromBody] VehicleResidual vehicleResidual) {  
            _vehicleResidualManager.UpdateVehicleResidual(vehicleResidual);  
        }  
        // DELETE api/vehicleresidual/5  
        [HttpDelete("{id}")]  
        public void Delete(int vehicleResidualId) {  
            _vehicleResidualManager.DeleteVehicleResidual(vehicleResidualId);  
        }  
    }
}