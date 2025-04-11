namespace VehicleManagementSystem.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public int NumberOfWheels { get; private set; }
        public Motorcycle(string brand, string model, int year, double weight, int numberOfWheels) : base(brand, model, year, weight)
        {
            this.NumberOfWheels = numberOfWheels;
        }

        public override string StartEngine()
        {
            return $"{this.GetType().Name} kickstarted!";
        }

        public override string Stats()
        {
            return $"{this.GetType().Name} has {NumberOfWheels} wheels!";
        }
    }
}
