using IntegracionApi.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Configuration["ApiSettings:BaseUrl"];
var baseURL = builder.Configuration["ApiSettings:BaseUrl"];

builder.Services.AddHttpClient<IServicio_API, Servicio_API>(client =>
{
    client.BaseAddress = new Uri(baseURL);
    client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Inicio}/{action=Inicio}/{id?}")
    .WithStaticAssets();


app.Run();
