using Microsoft.AspNetCore.Mvc;

namespace ZR.CodeExample.Attributes
{
    // Custom versioning attribute
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ApiVersionAttribute : RouteAttribute
    {
        public ApiVersionAttribute(string version) : base($"api/{version}/[controller]")
        {
        }
    }
}
