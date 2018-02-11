using Autofac;
using FurnitureManufacturer.ClientApp.InjectionConfig;
using FurnitureManufacturer.Engine.Contracts;

namespace FurnitureManufacturer.ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacConfig());
            var container = builder.Build();

            var engine = container.Resolve<IEngine>();
            engine.Start();
        }
    }
}
