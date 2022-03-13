using EcxCodility.Service.Common;
using Microsoft.Extensions.DependencyInjection;

namespace EcxCodility.Service
{
    public static class DependencyBindings
    {
        public static void ConfigureService(IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
        }
    }
}
