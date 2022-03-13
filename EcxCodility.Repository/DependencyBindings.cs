using EcxCodility.Repository.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcxCodility.Repository
{
    public static class DependencyBindings
    {
        public static void ConfigureService(IServiceCollection services)
        {
            services.AddTransient<IBookRepository, BookRepository>();
        }
    }
}
