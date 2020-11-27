using MicroHelper.CQRS.Command.Interfaces;
using MicroHelper.CQRS.Event.Interfaces;
using MicroHelper.Types;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MicroHelper.CQRS
{
    public static class Extensions
    {
        public static IServiceCollection AddCommandHandlers(this IServiceCollection serviceCollection)
        {
            serviceCollection.Scan(s =>
                s.FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
                    .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>))
                    .WithoutAttribute(typeof(DecoratorAttribute)))
                    .AsImplementedInterfaces()
                    .WithTransientLifetime());

            return serviceCollection;
        }
        public static IServiceCollection AddEventHandlers(this IServiceCollection serviceCollection)
        {
            serviceCollection.Scan(s =>
                s.FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
                    .AddClasses(c => c.AssignableTo(typeof(IEventHandler<>))
                    .WithoutAttribute(typeof(DecoratorAttribute)))
                    .AsImplementedInterfaces()
                    .WithTransientLifetime());

            return serviceCollection;
        }
    }
}
