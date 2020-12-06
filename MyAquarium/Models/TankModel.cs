namespace MyAquarium.Models
{
    public class TankModel : BaseModel
    {
        public double CarbonDioxideLevel { get; set; }
        public double NitrateLevel { get; set; }
        public double Temperature { get; set; }
        public double Salinity { get; set; }
        public bool IsFavourite { get; set; }
    }
}