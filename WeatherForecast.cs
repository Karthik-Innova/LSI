namespace LSI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public string windspeed { get; set; }

        public string NewProperty { get; set; }

        public string NewProperty123 { get; set; }

        public string NewProperty5 { get; set; }

 
        public string NewProperty6 { get; set; }
 
        public string NewProperty7 { get; set; }
 

    }
}
