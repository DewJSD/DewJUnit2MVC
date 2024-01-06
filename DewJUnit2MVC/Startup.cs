using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using DewJUnit2MVC.Models;

namespace DewJUnit2MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CustContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("CustContext")));
        }
    }
}