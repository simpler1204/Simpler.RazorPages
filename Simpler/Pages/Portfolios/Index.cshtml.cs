using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Simpler.Models;
using Simpler.Services;

namespace Simpler.Pages.Portfolios
{
    public class IndexModel : PageModel
    {
        private readonly PortfolioServiceJsonFile _service;

        //�������� �Ű������� ����(�������丮) Ŭ���� ����
        //cshtml(View)������ @inject PortfolioServiceJsonFile  PortfolioService �� ���������
        //cshtml.cs(Model)������ �������� �Ű������� �������� �����Ѵ�.

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
