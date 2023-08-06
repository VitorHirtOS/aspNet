/*
 Essas linhas importam os namespaces necessários para usar classes e recursos relacionados a ASP.NET Core MVC e Razor Pages.
*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace aspNet.pages
{
    public class indexModel : PageModel
    {
        // Renderizado no lado do servidor
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet() // Manipulador de requisição HTTP GET
        {
            await Task.Delay(5000); // Delay para simular renderização
            for (var i =  0; i <= 100; i++)
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

        public void OnPost() // Manipulador de requisição HTTP POST
        {

        }
    }
}

/*
 
public List<Category> Categories { get; set; } = new();: Isso declara uma propriedade chamada Categories, 
que é uma lista de objetos do tipo Category. A lista é inicializada como uma nova lista vazia.

public async Task OnGet(): Este é um método que é executado quando uma solicitação HTTP GET é feita para a 
página. O código dentro deste método simula uma espera de 5 segundos (usando Task.Delay) e, em seguida, 
cria 100 objetos Category e os adiciona à lista Categories.

public record Category(int Id, string Title, decimal Price): Isso declara um record chamado Category com três 
propriedades: Id, Title e Price.

public void OnPost(): Este é um método que é executado quando uma solicitação HTTP POST é feita para a página. 
No entanto, neste exemplo, o método está vazio e não faz nada.
 
 */