var app = WebApplication.CreateBuilder(args).Build();
app.UseStaticFiles();
app.Run();