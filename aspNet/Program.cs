/*

Essas duas linhas de c�digo est�o importando os namespaces necess�rios 
para usar classes e m�todos relacionados � configura��o de um aplicativo ASP.NET Core.

*/

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


/*

Aqui, estamos usando o m�todo est�tico CreateBuilder(args) da classe WebApplication. 
Esse m�todo cria uma inst�ncia de WebApplicationBuilder, que � usada para construir e 
configurar um aplicativo web ASP.NET Core. O par�metro args 
� uma matriz de argumentos da linha de comando que pode ser usada para configurar o 
aplicativo durante a inicializa��o. 
 
*/

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); // Suporte para p�ginas razor

/*

Aqui, estamos usando o m�todo Build() da inst�ncia de WebApplicationBuilder para realmente 
construir o aplicativo. Isso cria e configura a inst�ncia do WebApplication que ser� usada 
para executar o aplicativo. 
 
*/

var app = builder.Build();

app.UseHttpsRedirection(); // Redirecionamento HTTPS
app.UseStaticFiles(); // Para servir arquivos est�ticos como imagens, CSS, etc.

app.UseRouting(); // Configurar o roteamento
app.UseEndpoints(endpoints => // Configurar as endpoints (rotas)
{
    endpoints.MapRazorPages(); // Mapeamento de p�ginas Razor
});

app.Run(); // Rodar o app
