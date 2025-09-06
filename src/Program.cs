// See https://aka.ms/new-console-template for more information
using HelloApp;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional:true , reloadOnChange:true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

var redisConfigSection = configuration.GetSection("Redis");

var host = redisConfigSection.GetValue<string>("Host")!;
var port = redisConfigSection.GetValue<int>("Port");

var redisInfo = new RedisInfo()
{
    Host=host,
    Port=port
};

Console.WriteLine(redisInfo.ToString());

RedisUtility.InitializeConnection(redisInfo);
