using MediatR;
using Microsoft.AspNetCore.Mvc;
using S1.SabaSports.OddsDirectAPI.Attributes;
using S1.SabaSports.OddsDirectAPI.Extensions;
using S1.SabaSports.OddsDirectAPI.Queries;
using S1.SabaSports.OddsDirectAPI.Requests;

namespace S1.SabaSports.OddsDirectAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[S1ResponseWrapper]
public class SabaController(IMediator mediator) : ControllerBase
{

    [HttpGet("event")]
    public async Task<IActionResult> Get([FromQuery] GetEventQuery query)
    {
        var brandId = HttpContext.Items.GetBrandId();
        var request = new GetHighLightMatchRequest
        {
            SportType = query.SportType,
            BrandId = brandId,
            Bettype = query.BetType,
            IsLive = query.IsLive,
            Top = query.Top,
            From = query.From,
            To = query.To,
            VendorId = query.VendorId,
            VendorMemberId = query.VendorMemberId
        };
        return Ok(await mediator.Send(request).ConfigureAwait(false));
    }
}
