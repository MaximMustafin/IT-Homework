using Microsoft.AspNetCore.Builder;
public static class TokenExtensions
{
    /// <summary>
    /// Передача параметров
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="pattern"></param>
    /// <returns></returns>
    public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern)
    {
        return builder.UseMiddleware<TokenMiddleware>(pattern);
    }
    
    // public static IApplicationBuilder UseToken(this IApplicationBuilder builder)
    // {
    //     return builder.UseMiddleware<TokenMiddleware>();
    // }
}