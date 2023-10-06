using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace WebAPI.Middleware
{
    public static class Custom_Exception_Handler_Middleware_Extension
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this
            IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Custom_Exception_Handler_Middleware>();
        }
    }
}
