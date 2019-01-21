using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LogDashboard
{
    public static class LogDashboardApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseLogDashboard(
            this IApplicationBuilder builder, string pathMatch = "/LogDashboard")
        {
            var options = builder.ApplicationServices.GetService<LogDashboardOptions>();

            options.PathMatch = pathMatch;

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            return builder.Map(pathMatch, app => { app.UseMiddleware<LogDashboardMiddleware>(); });
        }
    }
}
