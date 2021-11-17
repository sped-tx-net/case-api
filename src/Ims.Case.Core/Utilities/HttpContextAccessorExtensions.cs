using Microsoft.AspNetCore.Http;

namespace Ims.Case.Utilities
{
    internal static class HttpContextAccessorExtensions
    {
        public static string RequestUrl(this IHttpContextAccessor source)
        {
            var request = source.HttpContext.Request;
            var scheme = request.Scheme;
            var host = request.Host.ToUriComponent();
            var path = request.Path.ToUriComponent();
            return $"{scheme}://{host}{path}";
        }

        public static string BaseUrl(this IHttpContextAccessor source)
        {
            var request = source.HttpContext.Request;
            var scheme = request.Scheme;
            var host = request.Host.ToUriComponent();
            var path = request.PathBase.ToUriComponent();
            return $"{scheme}://{host}{path}";
        }
    }
}
