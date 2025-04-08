var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectoinString= builder.Configuration.GetConnectionString("DefaultConnection")??
    throw new InvalidCastException ("no connection string was found");
builder.Services.AddDbContext<ApplicationDbContext>(options=>
 options.UseSqlServer(connectoinString));
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IDeviceService, DeviceService>();
builder.Services.AddScoped<IGameService, GameService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
