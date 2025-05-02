using System.ComponentModel.DataAnnotations;

namespace BazodanowaAplikacjaWebowa.Data
{
    public enum CategoryType
    {
        NotSelected = 0,
        Book = 1,
        Game = 2,
        Movie = 3
    }

    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required.")]
        [EnumDataType(typeof(CategoryType), ErrorMessage = "Category must be Book, Game, or Movie.")]
        [CategoryValidation(ErrorMessage = "You must choose a valid category.")]
        public CategoryType Category { get; set; } = CategoryType.NotSelected;

        [Range(1800, 2025, ErrorMessage = "Release Year must be between 1800 and 2025.")]
        public int ReleaseYear { get; set; }

        public string RatingsSerialized { get; set; } = "";
        public string DescriptionsSerialized { get; set; } = "";

        [Url(ErrorMessage = "Image URL must be a valid link.")]
        public string? ImageUrl { get; set; }
    }

    public class CategoryValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is CategoryType category)
            {
                if (category == CategoryType.NotSelected)
                {
                    return new ValidationResult(ErrorMessage ?? "Category is required.");
                }
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid category.");
        }
    }
}
