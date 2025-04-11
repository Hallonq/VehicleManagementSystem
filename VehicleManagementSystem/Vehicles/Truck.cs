namespace VehicleManagementSystem.Vehicles
{
    internal class Truck : Vehicle, ICleanable
    {
        public double CargoBedSize { get; private set; }
        public Truck(string brand, string model, int year, double weight, double cargoBedSize) : base(brand, model, year, weight)
        {
            this.CargoBedSize = cargoBedSize;
        }

        public override string StartEngine()
        {
            return $"V8 {this.GetType().Name} engine starting...";
        }

        public override string Stats()
        {
            return $"Cargo bed size: {CargoBedSize}";
        }

        public bool Clean()
        {
            return false;
        }
    }
}
