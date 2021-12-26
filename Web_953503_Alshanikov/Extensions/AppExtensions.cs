using Microsoft.AspNetCore.Builder;
using Web_953503_Alshanikov.Middleware;


namespace Web_953503_Alshanikov.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app) => app.UseMiddleware<LogMiddleware>();
    }
}