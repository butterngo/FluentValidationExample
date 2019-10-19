using FluentValidationExample.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBase : ControllerBase
    {
        protected virtual ValidationDto CheckValidation<TDto>(TDto model)
        {
            return ProcessedValidation.CheckValidation(model);
        }

        protected OkObjectResult Success()
        {
            return Ok(new { success = true });
        }
    }
}
