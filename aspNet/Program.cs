using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); // Suporte para p�ginas razor

var app = builder.Build();

app.UseHttpsRedirection(); // Redirecionamento HTTPS
app.UseStaticFiles(); // Para servir arquivos est�ticos como imagens, CSS, etc.

app.UseRouting(); // Configurar o roteamento
app.UseEndpoints(endpoints => // Configurar as endpoints (rotas)
{
    endpoints.MapRazorPages(); // Mapeamento de p�ginas Razor
});

app.Run(); // Rodar a app
