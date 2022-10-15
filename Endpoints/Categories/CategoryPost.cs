using IWANTAPP.Domain.Products;
using IWANTAPP.Infra.Data;

namespace IWANTAPP.Endpoints.Categories
{
    //Cadastrando categoria
    public class CategoryPost
    {
        public static string Template => "/categories";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(CategoryRequest categoryRequest, ApplicatioDbContext context)
        {
            var category = new Category
            {
                Name = categoryRequest.Name
            };
            context.Categories.Add(category);
            context.SaveChanges();

            return Results.Created($"/categories{category.Id}", category.Id);
        }
    }
}
