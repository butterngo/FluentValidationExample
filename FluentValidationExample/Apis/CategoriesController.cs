using FluentValidationExample.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FluentValidationExample.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ApiBase
    {

        [HttpPost]
        public IActionResult Create([FromBody]AddOrEditCategoryDto dto)
        {
            var result = CheckValidation(dto);

            if (!result.IsValid) return BadRequest(result.Errors);

            ////TODO Your logic

            return Success();

        }
    }
}
