/*
 Essas linhas importam os namespaces necess�rios para usar classes e recursos relacionados a ASP.NET Core MVC e Razor Pages.
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
que � uma lista de objetos do tipo Category. A lista � inicializada como uma nova lista vazia.

public async Task OnGet(): Este � um m�todo que � executado quando uma solicita��o HTTP GET � feita para a 
p�gina. O c�digo dentro deste m�todo simula uma espera de 5 segundos (usando Task.Delay) e, em seguida, 
cria 100 objetos Category e os adiciona � lista Categories.

public record Category(int Id, string Title, decimal Price): Isso declara um record chamado Category com tr�s 
propriedades: Id, Title e Price.

public void OnPost(): Este � um m�todo que � executado quando uma solicita��o HTTP POST � feita para a p�gina. 
No entanto, neste exemplo, o m�todo est� vazio e n�o faz nada.
 
 */