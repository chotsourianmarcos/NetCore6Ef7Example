using Data;
using Microsoft.Extensions.DependencyInjection;

namespace Logic.Logic
{
    public abstract class BaseContextLogic
    {
        protected readonly ServiceContext _serviceContext;
        protected BaseContextLogic(ServiceProvider serviceProvider)
        {
            _serviceContext = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<ServiceContext>();
        }
        protected BaseContextLogic(ServiceContext serviceContext) {
        _serviceContext= serviceContext;
        }
    }
}
