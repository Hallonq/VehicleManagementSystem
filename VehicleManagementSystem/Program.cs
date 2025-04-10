using System.Text;
using VehicleManagementSystem.Vehicles;

namespace VehicleManagementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        VehicleHandler handler = new VehicleHandler();
        try
        {
            Vehicle bmw = new Car("BMW", "330E", 2024, 1250, 3);
            Vehicle fordTruck = new Truck("Ford", "F150", 2020, 3000, double.MaxValue);
            Vehicle KawasakiBike = new Motorcycle("Kawasaki", "Ninja", 2015, 300, 2);
            Vehicle Voi = new ElectricScooter("Voi", "max250U", 2021, 100, 650);

            handler.CreateVehicle(bmw);
            handler.CreateVehicle(fordTruck);
            handler.CreateVehicle(KawasakiBike);
            handler.CreateVehicle(Voi);

            handler.UpdateVehicle(bmw);
        }
        catch (Exception e)
        {
            throw new ArgumentException(e.Message);
        }

        foreach (Vehicle vehicle in handler.GetVehicles())
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Brand: {vehicle.Brand}\n" +
                $"Model: {vehicle.Model}\n" +
                $"Year: {vehicle.Year}\n" +
                $"Weight: {vehicle.Weight}\n" +
                $"Stats: {vehicle.Stats()}\n" +
                $"Engine status: {vehicle.StartEngine()}\n");

            if (vehicle is ICleanable cleanable)
            {
                stringBuilder.Append($"Clean status: {cleanable.Clean()}\n");
            }
            Console.WriteLine(stringBuilder);
        }

        List<SystemError> errors = [new EngineFailureError(), new BrakeFailureError(), new TransmissionError()];

        foreach (SystemError error in errors)
        {
            Console.WriteLine($"{error.ErrorMessage()}");
        }
    }
}