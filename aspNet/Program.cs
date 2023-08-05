/*

Essas duas linhas de código estão importando os namespaces necessários 
para usar classes e métodos relacionados à configuração de um aplicativo ASP.NET Core.

*/

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


/*

Aqui, estamos usando o método estático CreateBuilder(args) da classe WebApplication. 
Esse método cria uma instância de WebApplicationBuilder, que é usada para construir e 
configurar um aplicativo web ASP.NET Core. O parâmetro args 
é uma matriz de argumentos da linha de comando que pode ser usada para configurar o 
aplicativo durante a inicialização. 
 
*/

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); // Suporte para páginas razor

/*

Aqui, estamos usando o método Build() da instância de WebApplicationBuilder para realmente 
construir o aplicativo. Isso cria e configura a instância do WebApplication que será usada 
para executar o aplicativo. 
 
*/

var app = builder.Build();

app.UseHttpsRedirection(); // Redirecionamento HTTPS
app.UseStaticFiles(); // Para servir arquivos estáticos como imagens, CSS, etc.

app.UseRouting(); // Configurar o roteamento
app.UseEndpoints(endpoints => // Configurar as endpoints (rotas)
{
    endpoints.MapRazorPages(); // Mapeamento de páginas Razor
});

app.Run(); // Rodar o app
