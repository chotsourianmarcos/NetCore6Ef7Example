using Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class BaseContextLogic
    {
        protected ServiceContext _serviceContext;
        protected BaseContextLogic(IServiceProvider serviceProvider)
        {
            _serviceContext = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ServiceContext>();
        }
    }
}
