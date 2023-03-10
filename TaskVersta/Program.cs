using Microsoft.EntityFrameworkCore;
using TaskVersta.Data;
using TaskVersta.Repositories;
using TaskVersta.Repositories.Implementation;
using TaskVersta.Repositories.Interfaces;
using TaskVersta.Utility.FloatingPointModelBinding;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region ConfigureServices
builder.Services.AddControllersWithViews(options =>
{
    options.ModelBinderProviders.Insert(0, new CustomFloatingPointModelBinderProvider());
});
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnetion"))
);

//Repostiories
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IRepositoryWrapper, RepositoryWrapper>(); 
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStatusCodePagesWithReExecute("/Home/Warning");
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Order}/{action=Index}/{id?}");

app.Run();
