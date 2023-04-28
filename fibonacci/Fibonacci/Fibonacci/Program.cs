using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Fibonacci;

var maxBytes = 3L * 1024L * 1024L * 1024L; // 3GB in bytes
AppContext.SetSwitch("System.GC.AllowVeryLargeObjects", true);
AppContext.SetSwitch("System.GC.Concurrent", true);
AppContext.SetSwitch("System.GC.Server", true);
AppContext.SetSwitch("Switch.System.GC.RetainVM", true);
AppContext.SetSwitch("Switch.System.GC.RetainVMOnSuspendingPulse", true);


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();