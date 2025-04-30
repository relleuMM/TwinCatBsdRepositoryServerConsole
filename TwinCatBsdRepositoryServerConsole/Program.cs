// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tc3_TcBsd_CopyLocalRepository;
/**********************************************************/
/**********************************************************/
#region Decleration
Console.Title = "TwinCat/Bsd Repositoryserver Console";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Init");

string rootDirectory = @"C:\tcbsd\repository\packages";

string PathDirectroy = AppContext.BaseDirectory;
Console.WriteLine("Path Directory: " +PathDirectroy);

rootDirectory = PathDirectroy+ @"LocalRepository\";

Console.WriteLine("Path Local Repository: " + rootDirectory);

string webServerUrl = "http://*:";
WebServer webServerData = new WebServer(0);
#endregion
/**********************************************************/
/**********************************************************/
#region Application

InitConfigurationManager();

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    WebRootPath = rootDirectory
});

builder.Services.AddDirectoryBrowser();

var app = builder.Build();

app.UseFileServer(new FileServerOptions()
{
    EnableDirectoryBrowsing = true,
    StaticFileOptions =
            {
                ServeUnknownFileTypes = true,
                DefaultContentType = "application/octet-stream"
            }
});
webServerUrl = webServerUrl + webServerData.Port;

_ = app.RunAsync(webServerUrl);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Application Started");
Console.ReadLine();
#endregion
/**********************************************************/
/**********************************************************/
#region Methoden
void InitConfigurationManager()
{
    Console.WriteLine("Application Settings: Init"); 
    var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .Build();
    webServerData.Port = configuration.GetValue<uint>("Webserver:Port");

    Console.WriteLine("Application Settings: Applikation Settings. Webserver Port: " + webServerData.Port.ToString());
    Console.WriteLine("Application Settings: Load File Complete (config.json)");
}
#endregion