namespace VehicleManagementSystem.Vehicles
{
    internal abstract class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;
        public string Brand
        {
            get { return brand; }
            set
            {
                brand = ValidateStringProperites(value);
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                model = ValidateStringProperites(value);
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1886 && value < DateTime.Now.Year)
                    year = value;

                else
                    throw new ArgumentException($"{value} must be between production year (1886) and current year ({DateTime.Now.Year})");
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;

                else
                    throw new ArgumentException($"{value} must be positive");
            }
        }

        public Vehicle(string brand, string model, int year, double weight)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Weight = weight;
        }

        private string ValidateStringProperites(string value)
        {
            if (value.Length >= 2 && value.Length <= 20)
                return value;

            else
                throw new ArgumentException($"{value} must be between 2 and 20 symbols");
        }

        public abstract string StartEngine();
        public abstract string Stats();
    }
}
