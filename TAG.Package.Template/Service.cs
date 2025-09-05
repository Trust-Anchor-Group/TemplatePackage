using System.Threading.Tasks;
using Waher.IoTGateway;

namespace TAG.Package.Template
{
    public class Service : IConfigurableModule
    {
        public Task<IConfigurablePage[]> GetConfigurablePages()
        {
            return Task.FromResult(new IConfigurablePage[]
            {
                new ConfigurablePage("TemplatePackage", "/TemplatePackage/Settings.md", "TemplatePackage")
            });
        }

        public Task Start()
        {
            return Task.CompletedTask;
        }

        public Task Stop()
        {
            return Task.CompletedTask;
        }
    }
}
