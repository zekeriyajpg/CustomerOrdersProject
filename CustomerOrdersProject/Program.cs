var builder = WebApplication.CreateBuilder(args);

// MVC controller'lar� i�in hizmetleri ekleyin
builder.Services.AddControllers();

var app = builder.Build();

// MVC y�nlendirmesini kullanmak i�in
app.UseRouting();

// Endpoint'leri tan�mlama
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

// Basit bir GET iste�i
app.MapGet("/", () => "Hello World!");

app.Run();
