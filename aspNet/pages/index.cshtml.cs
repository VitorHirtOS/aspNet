/*
 Essas linhas importam os namespaces necessários para usar classes e recursos relacionados a ASP.NET Core MVC e Razor Pages.
*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace aspNet.pages
{
    public class indexModel : PageModel
    {
        public void OnGet()
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