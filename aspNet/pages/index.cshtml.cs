using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspNet.pages
{
    public class indexModel : PageModel
    {
        // Renderizado no lado do servidor
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet() // Requisição Get
        {
            await Task.Delay(5000); // Delay para a renderização das informações
            for(var i =  0; i <= 100; i++)
            {
                Categories.Add(
                    item: new Category(i, 
                    Title: $"Categoria {i}", 
                    Price: i * 18.95M)
                    );
            }
        }

        public record Category(int Id,
                                string Title,
                                decimal Price)
        {

        }

        public void OnPost() // Requisição Post
        {

        }
    }
}