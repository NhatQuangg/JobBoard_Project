using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ErrorHandles
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

                if (context.Response.StatusCode >= 400 && !context.Response.HasStarted)
                {
                    var status = context.Response.StatusCode;
                    var message = status switch
                    {
                        400 => "Bad request.",
                        401 => "Unauthorized.",
                        403 => "Forbidden.",
                        404 => "Resource not found.",
                        409 => "Conflict.",
                        500 => "Internal server error.",
                        _ => "An error occurred.",
                    };

                    context.Response.ContentType = "application/json";
                    var response = new { status, message };

                    // Ghi lại body response
                    var json = JsonSerializer.Serialize(response);
                    await context.Response.WriteAsync(json);
                }
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var response = new
                {
                    status = 500,
                    message = "An unexpected error occurred.",
                    error = ex.Message,
                };

                var json = JsonSerializer.Serialize(response);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
