using Simpler.Models;
using System.Text.Json;

namespace Simpler.Services
{
    public class PortfolioServiceJsonFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PortfolioServiceJsonFile(IWebHostEnvironment webHostEnvironment) 
        {
            // IWebHostEnvironment : WebHost의 전반적인 내용이 담겨져 있다.
            // ASP.NET에서 제공해 준다.
            // DI(종속성(의존성) 주입)
            this._webHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get
            {
                //return _webHostEnvironment.WebRootPath + "\\Portfolios" + "\\portpolis.json";
                return Path.Combine(_webHostEnvironment.WebRootPath, "Portfolios" , "portpolis.json");
            }
        }

        public IEnumerable<Portfolio> GetPortfolios()
        {
            //var jsonFileName = @"C:\DotNetNote\Razor\Simpler.RazorPages\Simpler.RazorPages\Simpler\wwwroot\Portfolios\portpolis.json";

            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var option = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                var portfolios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), option);
                return portfolios!;
            }
        }
    }
}

