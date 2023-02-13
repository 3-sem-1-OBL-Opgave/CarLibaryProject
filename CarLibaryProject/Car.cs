namespace CarLibaryProject
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string LicensePlate { get; set; }

        public void ModelValidator()
        {
            if (Model.Length < 4)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void PriceValidator()
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void LPValidator()
        {
            if (LicensePlate.Length <= 2 || LicensePlate.Length > 7)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}