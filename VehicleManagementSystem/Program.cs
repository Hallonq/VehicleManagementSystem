using System;

namespace VehicleManagementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        Vehicle bmw = new Vehicle("BMW", "330D", 2024, 1250);
        Vehicle audi = new Vehicle("Audi", "A7", 1980, 2280);

        VehicleHandler handler = new VehicleHandler();
        try
        {
            handler.CreateVehicle(bmw);
            handler.CreateVehicle(audi);
            handler.UpdateVehicle(bmw);
        }
        catch (Exception e)
        {
            throw new ArgumentException(e.Message);
        }

        foreach (Vehicle vehicle in handler.GetVehicles())
        {
            Console.WriteLine($"Brand: {vehicle.Brand}\nModel: {vehicle.Model}\nYear: {vehicle.Year}\nWeight: {vehicle.Weight}\n");
        }

        List<SystemError> errors = [new EngineFailureError(), new BrakeFailureError(), new TransmissionError()];

        foreach (SystemError error in errors)
        {
            Console.WriteLine(error.ErrorMessage());
        }
    }
}