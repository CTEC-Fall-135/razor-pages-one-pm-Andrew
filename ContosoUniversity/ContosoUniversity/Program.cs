using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();

// Configure the database context to use SQL Server
builder.Services.AddDbContext<SchoolContext>(options => // configure DbContext with SQL Server
  options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolContext"))); // get connection string from configuration

// Add database exception filter for development
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// Build the application
var app = builder.Build();

// Configure the HTTP request pipeline. Enhance error handling and security based on environment
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error"); // use custom error page
    app.UseHsts(); // use HTTP Strict Transport Security
}
else
{
    app.UseDeveloperExceptionPage(); // use developer exception page
    app.UseMigrationsEndPoint(); // use migrations endpoint
}

// Seed the database with initial data using EnsureCreated
using (var scope = app.Services.CreateScope()) 
{
    var services = scope.ServiceProvider; // get service provider

    var context = services.GetRequiredService<SchoolContext>(); // get the SchoolContext
    context.Database.EnsureCreated(); // ensure the database is created
    DbInitializer.Initialize(context);
}

// Middleware configuration
app.UseHttpsRedirection(); // redirect HTTP to HTTPS
app.UseStaticFiles(); // serve static files

app.UseRouting(); // use routing

app.UseAuthorization(); // use authorization

app.MapRazorPages(); // map Razor Pages

app.Run(); // run the application