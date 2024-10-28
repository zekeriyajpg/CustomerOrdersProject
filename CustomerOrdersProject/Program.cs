var builder = WebApplication.CreateBuilder(args);

// MVC controller'larý için hizmetleri ekleyin
builder.Services.AddControllers();

var app = builder.Build();

// MVC yönlendirmesini kullanmak için
app.UseRouting();

// Endpoint'leri tanýmlama
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

// Basit bir GET isteði
app.MapGet("/", () => "Hello World!");

app.Run();
