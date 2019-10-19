namespace FluentValidationExample.Dtos
{
    using FluentValidation;
    
    public class AddOrEditCategoryDto
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }

    public class AddOrEditCategoryDtoValidator : AbstractValidator<AddOrEditCategoryDto>
    {
        public AddOrEditCategoryDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty();

            RuleFor(x => x.Name).NotEmpty().MaximumLength(2);
        }
    }
}
