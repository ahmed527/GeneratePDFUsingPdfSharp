
namespace GeneratePDFUsingPdfSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
             

            builder.Services.AddControllers();
           
            builder.Services.AddOpenApi();

            var app = builder.Build();
            PdfSharp.Fonts.GlobalFontSettings.FontResolver = new MinimalFontResolver();

          
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
