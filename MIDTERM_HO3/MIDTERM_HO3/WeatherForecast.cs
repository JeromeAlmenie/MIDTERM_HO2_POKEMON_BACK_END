namespace MIDTERM_HO3
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
    public class Pokemon
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string NextEvolution { get; set; }

        public string BaseEvolution { get; set; }

        public string Generation { get; set; }

        public float Weight { get; set; }

        public float Height { get; set; }

        public float id { get; set; }
    }
}


