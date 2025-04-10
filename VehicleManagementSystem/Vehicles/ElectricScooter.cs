namespace VehicleManagementSystem.Vehicles
{
    internal class ElectricScooter : Vehicle
    {
        public double BatteryCapacity { get; set; }

        public ElectricScooter(string brand, string model, int year, double weight, double batteryCapacity) : base(brand, model, year, weight)
        {
            this.BatteryCapacity = batteryCapacity;
        }

        public override string StartEngine()
        {
            return $"{this.GetType().Name} started through app!";
        }

        public override string Stats()
        {
            return $"{this.GetType().Name} has battery capacity of {BatteryCapacity}";
        }
    }
}
