using DanskeTask.Interfaces;
using DanskeTask.Sorting;

namespace DanskeTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddSingleton<IFileOperationsHandler, FileOperationsHandler>();

            WebApplication app = builder.Build();

            app.UseHttpsRedirection()
               .UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}