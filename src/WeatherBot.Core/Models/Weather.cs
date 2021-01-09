namespace WeatherBot.Core.Models
{
    public class Weather
    {
        public string DescriptionShort { get; set; }
        
        public string Description { get; set; }
        
        public string IconCode { get; set; }
        
        public double CurrentTemperature { get; set; }
        
        public double MinimumTemperature { get; set; }
        
        public double MaximumTemperature { get; set; }
        
        public double WindSpeed { get; set; }
    }
}