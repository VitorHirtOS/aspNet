/*
 Essas linhas importam os namespaces necess�rios para usar classes e recursos relacionados a ASP.NET Core MVC e Razor Pages.
*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace aspNet.pages
{
    public class indexModel : PageModel
    {
        // Renderizado no lado do servidor
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet() // Manipulador de requisi��o HTTP GET
        {
            await Task.Delay(5000); // Delay para simular renderiza��o
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

        public void OnPost() // Manipulador de requisi��o HTTP POST
        {

        }
    }
}

/*
 
public List<Category> Categories { get; set; } = new();: Isso declara uma propriedade chamada Categories, 
que � uma lista de objetos do tipo Category. A lista � inicializada como uma nova lista vazia.

public async Task OnGet(): Este � um m�todo que � executado quando uma solicita��o HTTP GET � feita para a 
p�gina. O c�digo dentro deste m�todo simula uma espera de 5 segundos (usando Task.Delay) e, em seguida, 
cria 100 objetos Category e os adiciona � lista Categories.

public record Category(int Id, string Title, decimal Price): Isso declara um record chamado Category com tr�s 
propriedades: Id, Title e Price.

public void OnPost(): Este � um m�todo que � executado quando uma solicita��o HTTP POST � feita para a p�gina. 
No entanto, neste exemplo, o m�todo est� vazio e n�o faz nada.
 
 */