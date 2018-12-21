// -----------------------------------------------------------------------
//   Copyright (C) 2018 Adam Hancock
//    
//   Program.cs Licensed under the MIT License. See LICENSE file in
//   the project root for full license information.  
// -----------------------------------------------------------------------

namespace CryptoWallet
{
    using ElectronNET.API;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseElectron(args);
    }
}