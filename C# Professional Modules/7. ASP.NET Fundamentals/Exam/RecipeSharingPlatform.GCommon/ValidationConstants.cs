namespace RecipeSharingPlatform.GCommon
{
    public class ValidationConstants
    {
        public static class Recipe
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 80;

            public const int InstructionsMinLength = 10;
            public const int InstructionsMaxLength = 250;

            public const int CreatedOnLength = 10;
            public const string CreatedOnFormat = "dd-MM-yyyy";

        }

        public static class Category
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 20;
        }
    }
}
