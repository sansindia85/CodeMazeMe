using GlobalErrorHandling.CustomExceptionMiddleware;
using LoggerService;
using Microsoft.AspNetCore.Builder;

namespace GlobalErrorHandling.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
