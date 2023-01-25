var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

// 미들웨어 추가
app.MapRazorPages();  // pages를 사용하기 위해
app.UseStaticFiles(); // wwwroot를 사용하기 위해(정적인 html, css, javascript,.. 실행하고 싶을때)
//app.UseFileServer();
//app.UseRouting();
//app.MapGet("/", () => "Hello World!!!");


app.Run();
