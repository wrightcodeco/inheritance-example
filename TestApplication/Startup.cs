using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestApplication.Services.Math;
using TestApplication.Services.Webhooks;
using TestApplication.Services.Webhooks.ProductInStock;
using TestApplication.Services.Webhooks.ProductOnSale;
using TestApplication.Services.Webhooks.ShippingUpdate;

namespace TestApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSingleton<IGeometryService, GeometryService>();
            services.AddSingleton<IMathService, MathService>();

            services.AddSingleton<IWebhookHandlerFactory, WebhookHandlerFactory>();
            services.AddSingleton<IProductInStockWebhookHandler, ProductInStockWebhookHandler>();
            services.AddSingleton<IProductOnSaleWebhookHandler, ProductOnSaleWebhookHandler>();
            services.AddSingleton<IShippingUpdateWebhookHandler, ShippingUpdateWebhookHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
