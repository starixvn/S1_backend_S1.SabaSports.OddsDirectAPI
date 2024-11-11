using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using S1.SabaSports.OddsDirectAPI.Models;

namespace S1.SabaSports.OddsDirectAPI.Attributes;

public class S1ResponseWrapperAttribute : ActionFilterAttribute
{
    public override void OnResultExecuting(ResultExecutingContext context)
    {
        if (!context.ModelState.IsValid)
            return;

        switch (context.Result)
        {
            case EmptyResult:
                context.Result = new ObjectResult(new S1Response());
                break;

            case ObjectResult { Value: not S1Response and IEnumerable<object> ae } result:
                {
                    var adjustResult = new ObjectResult(new SuccessResponse<object>
                    {
                        Data = ae
                    })
                    {
                        StatusCode = result.StatusCode,
                        Formatters = result.Formatters
                    };

                    context.Result = adjustResult;
                }

                break;

            case ObjectResult result when result.Value is not S1Response:
                {
                    var adjustResult = new ObjectResult(new SuccessResponse<object>
                    {
                        Data = result.Value
                    })
                    {
                        StatusCode = result.StatusCode,
                        Formatters = result.Formatters
                    };

                    context.Result = adjustResult;
                }

                break;
        }
    }
}