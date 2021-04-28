using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Http;
using BlazorStrap;

namespace familienfest
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
            builder.Services.AddHttpClient("ServerAPI", client => client.BaseAddress = new Uri("https://www.metaweather.com/"));
            builder.Services.AddBootstrapCss();
            //builder.Services.AddCors(options =>
            //{
            //    options.AddDefaultPolicy(builder =>
            //    builder.WithOrigins("https://localhost:44351")
            //    .AllowAnyHeader()
            //    .AllowAnyMethod());
            //});

            await builder.Build().RunAsync();
        }
    }
}
