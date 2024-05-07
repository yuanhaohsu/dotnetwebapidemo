using System.Net;
using System.Text.Json;

namespace API.UseMiddleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;     //#76
    private readonly ILogger<ExceptionMiddleware> _logger;  //#76
    private readonly IHostEnvironment _env; //#76
    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger,
        IHostEnvironment env)   //#76
    {
        _env = env;
        _logger = logger;
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)  //#76 Method
    {
        try         //#76 handing the exceptions
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var response = _env.IsDevelopment() //check if running at development mode
                ? new ApiException(context.Response.StatusCode, ex.Message, ex.StackTrace?.ToString())  //if in development mode
                : new ApiException(context.Response.StatusCode, ex.Message, "Internal server error");   // if "not" in development mode

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

            var json = JsonSerializer.Serialize(response, options);

            await context.Response.WriteAsync(json);
        }
    }
}