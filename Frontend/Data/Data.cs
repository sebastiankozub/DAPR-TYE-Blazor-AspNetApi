namespace Frontend.Data;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}


public class Car
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Model { get; set; }

    public string Category { get; set; }

    public int ProductionYear { get; set; }
}
