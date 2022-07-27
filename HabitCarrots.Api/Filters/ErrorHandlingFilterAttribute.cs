using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitCarrots.Api.Filters
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var errorResult = new { error = "An error occurred while processing your request." };
            context.Result = new ObjectResult(errorResult)
            {
                StatusCode = 500
            };
            context.ExceptionHandled = true;


            //if (context.Exception is null)
            //{
            //    return;
            //}

            //context.Result = new ObjectResult(new
            //{
            //    error = context.Exception.Message
            //});
        }
    }
}
