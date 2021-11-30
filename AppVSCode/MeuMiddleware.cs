using Microsoft.AspNetCore.Http;

public class MeuMiddleware
{
    private readonly RequestDelegate _next;

    public MeuMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvoKeAsync(HttpContext context)
    {
        Console.WriteLine("\n\r ------ Antes ------\n\r");

        await _next(context);

        Console.WriteLine("\n\r ------ Depois ------\n\r");
    }
    
}

public static class MeuMiddlewareExttencion
{
    public static IApplicationBuilder UseMeuMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMeuMiddleware<MeuMiddleware>();
        
    }
}
