using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace WaProject_API.Infra.Repository
{
    public static class BaseAdo
    {
        public static string ConennectionString()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            return root.GetSection("ConnectionStrings").GetSection("DefaultMysql").Value;
        }

        public static string ConvertByte(this Guid x)
        {
            var bytes = x.ToByteArray();

            var bytesresult = "";

            foreach (var byt in bytes)
                bytesresult += $"{byt:X2}";

            return bytesresult;
        }

    }
}