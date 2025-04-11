namespace VehicleManagementSystem.Vehicles
{
    internal class Car : Vehicle, ICleanable
    {
        private int windowsDown;
        public int WindowsDown
        {
            get { return windowsDown; }
            private set
            {
                if (value > 0 && value <= 4)
                {
                    windowsDown = value;
                }
            }
        }

        public Car(string brand, string model, int year, double weight, int windowsDown) : base(brand, model, year, weight)
        {
            this.WindowsDown = windowsDown;
        }

        public override string StartEngine()
        {
            return $"Starting gasoline engine... Started with {windowsDown} windows down";
        }

        public override string Stats()
        {
            return $"{this.GetType().Name} has {windowsDown} windows down";
        }

        public bool Clean()
        {
            return true;
        }
    }
}
