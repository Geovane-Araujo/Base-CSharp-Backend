using Base_Backend.Repository;

namespace Base_Backend.Config.Scoped
{
    public class ConfigScoped
    {

        public static void AddScoped(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
