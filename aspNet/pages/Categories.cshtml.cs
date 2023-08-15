using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspNet.pages
{
    public class CategoriesModel : PageModel
    {
        // Renderizado no lado do servidor
        public List<Category> CategoriesList { get; set; } = new();
        public void OnGet(int skip=0, int take=25) // Manipulador de requisição HTTP GET
        {
            //await Task.Delay(5000); // Delay para simular renderização
            var temp = new List<Category>();

            for (var i = 0; i <= 100; i++)
            {
                temp.Add(
                    item: new Category(i,
                        Title: $"Categoria {i}",
                        Price: i * 18.95M)
                );
            }

            CategoriesList = temp
                            .Skip(skip)
                            .Take(take)
                            .ToList();

        }


        public void OnPost() // Manipulador de requisição HTTP POST
        {

        }
    }
}

public record Category(int Id,
    string Title,
    decimal Price)
{

}
