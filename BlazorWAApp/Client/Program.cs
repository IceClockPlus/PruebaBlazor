using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWAApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            SyncfusionLicenseProvider.RegisterLicense("NDA0MzY5QDMxMzgyZTM0MmUzMEQzOHhNNUh4UGxBWHRreTVIbmVybGZ2cmlXQmQ5RDF3eUYyS25DMWhXMXM9");
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
