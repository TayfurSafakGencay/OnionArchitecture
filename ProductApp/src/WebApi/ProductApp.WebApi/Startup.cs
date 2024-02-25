using ProductApp.Persistence;

namespace ProductApp.WebApi;

public class Startup
{
  public Startup(IConfiguration configuration)
  {
    Configration = configuration;
  }
  
  public IConfiguration Configration { get; }


  public void ConfigureServices(IServiceCollection services)
  {
    services.AddPersistenceService();
    
    services.AddControllers();
  }

  public void Configure(ApplicationBuilder app, IWebHostEnvironment env)
  {
    if (!env.IsDevelopment())
    {
      app.UseDeveloperExceptionPage();
    }

    app.UseHttpsRedirection();
    
    app.UseRouting();
    
    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
      endpoints.MapControllers();
    });
  }
}