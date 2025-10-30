using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Patient.WebApi.Controllers
{
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
        private IMediator? mediator;

        protected IMediator Mediator => mediator ??= HttpContext.RequestServices.GetService<IMediator>()
            ?? throw new InvalidOperationException("IMediator service is not registered");
    }
}
