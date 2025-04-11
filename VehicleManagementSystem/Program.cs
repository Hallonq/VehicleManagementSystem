using System;
using System.Text;
using VehicleManagementSystem.Vehicles;

namespace VehicleManagementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        VehicleHandler handler = new();
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
            StringBuilder stringBuilder = new();
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

        // frågor och svar
        // Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
        // Kompiler error, kan ej konvertera typen av objekt.

        // Vilken typ bör en lista vara för att rymma alla fordonstyper ?
        // Vehicle, då alla fordonstyper ärver av Vehicle.

        // Kommer du åt metoden Clean() från en lista med typen List<Vehicle>?
        // Ja, men endast om objektet ärver av mitt ICleanable interface.

        // Vad är fördelarna med att använda ett interface här istället för arv?
        // Jag vet inte, jag tror min lösning inte löser problemet på rätt sätt.
    }
}