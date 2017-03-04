using Autofac;
using Mediator.Net.SampleLib.RequestHandlers;


namespace Mediator.Net.SampleLib
{
    public class LibAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AboutTextService>().AsImplementedInterfaces();
        }
    }
}
