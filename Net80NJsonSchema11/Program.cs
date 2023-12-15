namespace Net80NJsonSchema11;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers().AddJsonOptions(o => o.JsonSerializerOptions.Converters.Add(new NetTopologySuite.IO.Converters.GeoJsonConverterFactory()));
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerDocument();

        var app = builder.Build();
        app.MapControllers();

        app.Run();
    }
}