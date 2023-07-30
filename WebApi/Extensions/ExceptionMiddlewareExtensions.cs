using Microsoft.Graph;

using Services.Contracts;
using System;
using System.Net;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Graph.Models;

namespace WebApi.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerService logger)
        {
            //app.HomePageUrl(apperror =>
            //{

            //});

        }
    }
}
