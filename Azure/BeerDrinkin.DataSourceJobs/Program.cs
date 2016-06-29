﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using BeerDrinkin.DataObjects;
using System.IO;

namespace BeerDrinkin.DataSourceJobs
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            var host = new JobHost();
            // The following code ensures that the WebJob will be running continuously
            host.RunAndBlock();
        }

        public static Task<Beer> ConvertBeer([QueueTrigger("queue")] BreweryDB.Models.Beer beer, TextWriter log)
        {
            log.WriteLine($"Converting {beer.Name}");

            return null;
        }
    }
}