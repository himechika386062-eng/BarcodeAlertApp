using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BarcodeAlertApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

string supabaseUrl = "https://irclgwzmfeinzbvhthak.supabase.co";
string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImlyY2xnd3ptZmVpbnpidmh0aGFrIiwicm9sZSI6ImFub24iLCJpYXQiOjE3ODE5MzAzMzAsImV4cCI6MjA5NzUwNjMzMH0.zumEBxnuC1ojlDpw8Xar5DZoeaY-u2SKKEEPhbpqTJ0";

// Supabaseクライアントを登録して、アプリ全体で使えるようにする
builder.Services.AddScoped(sp => new Supabase.Client(supabaseUrl, supabaseKey, new SupabaseOptions
{
    AutoRefreshToken = true
}));

await builder.Build().RunAsync();
