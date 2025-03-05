using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PaytureTestTask.Api.Models;
using PaytureTestTask.Application.PaytureApiProvider.Commands.Pay;
using PaytureTestTask.Application.PaytureApiProvider.Queries.GetState;

namespace PaytureTestTask.Api.Controllers.v1
{
    [ApiVersion(1, Deprecated = false)]
    [Produces("application/json")]
    [Route("api/v{version::apiVersion}/[controller]")]
    public class PaytureController : BaseController
    {
        private readonly IMapper _mapper;

        public PaytureController(IMapper mapper) =>
            _mapper = mapper;

        [HttpPost("Pay")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<PayDetailsVm>> Pay([FromBody] PayDto payDto)
        {
            var payCommand = _mapper.Map<PayCommand>(payDto);

            var vm = await Mediator.Send(payCommand);

            return Ok(vm);
        }

        [HttpPost("GetState")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<GetStateDetailsVm>> GetState([FromBody] GetStateDto getStateDto)
        {
            var getStateQuery = _mapper.Map<GetStateQuery>(getStateDto);

            var vm = await Mediator.Send(getStateQuery);

            return Ok(vm);
        }
    }
}
