using Aula8Api.Domain;

namespace Aula8Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddTransient<IContadorDeVisitaService, ContadorDeVisitaArquivoService>();
            builder.Services.AddTransient<IContadorDeVisitaService, ContadorDeVisitaService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}