using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem
{
    internal class VehicleHandler
    {
        List<Vehicle> _vehicles = new List<Vehicle>();
        public void CreateVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _vehicles.Remove(vehicle);
            vehicle.Weight += 50;
            _vehicles.Add(vehicle);
        }

        public List<Vehicle> GetVehicles()
        {
            return _vehicles;
        }
    }
}
