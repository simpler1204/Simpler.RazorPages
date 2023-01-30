using Simpler.Models;
using Simpler.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//Di(������ ����)
//PortfolioServiceJsonFile����
builder.Services.AddTransient<PortfolioServiceJsonFile>();

var app = builder.Build();

// �̵���� �߰�
app.MapRazorPages();  // pages�� ����ϱ� ����
app.MapBlazorHub();
app.UseStaticFiles(); // wwwroot�� ����ϱ� ����(������ html, css, javascript,.. �����ϰ� ������)

//app.UseFileServer();
//app.UseRouting();
//app.MapGet("/", () => "Hello World!!!");


app.Run();
