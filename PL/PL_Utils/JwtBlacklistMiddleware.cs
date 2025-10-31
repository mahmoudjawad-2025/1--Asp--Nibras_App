using B_L_L.Services.Classes;

public class JwtBlacklistMiddleware
{
    private readonly RequestDelegate _next;

    public JwtBlacklistMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        if (!string.IsNullOrEmpty(token) && AuthenticationService.IsTokenRevoked(token))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Token has been revoked");
            return;
        }

        await _next(context);
    }
}
