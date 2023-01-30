using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Simpler.Models;
using Simpler.Services;

namespace Simpler.Pages.Portfolios
{
    public class IndexModel : PageModel
    {
        private readonly PortfolioServiceJsonFile _service;

        //생성자의 매개변수로 서비스(리포지토리) 클래스 주입
        //cshtml(View)에서는 @inject PortfolioServiceJsonFile  PortfolioService 로 사용했지만
        //cshtml.cs(Model)에서는 생성자의 매개변수로 인젝션을 실행한다.

        public IndexModel(PortfolioServiceJsonFile service)
        {
            this._service = service;
        }

        public IEnumerable<Portfolio>  Portfolios { get; private set; }

        public void OnGet()
        {
            Portfolios = _service.GetPortfolios();
        }
    }
}
