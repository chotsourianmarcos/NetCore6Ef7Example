using Data;
using Microsoft.Extensions.DependencyInjection;

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
