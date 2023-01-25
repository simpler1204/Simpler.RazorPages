var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

// �̵���� �߰�
app.MapRazorPages();  // pages�� ����ϱ� ����
app.UseStaticFiles(); // wwwroot�� ����ϱ� ����(������ html, css, javascript,.. �����ϰ� ������)
//app.UseFileServer();
//app.UseRouting();
//app.MapGet("/", () => "Hello World!!!");


app.Run();
