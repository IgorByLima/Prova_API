using PROVA.Context;
using PROVA.Domain;
using System.Runtime.InteropServices;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("Filme/Adicionar", (Filme filme) =>
{
    using var context = new AcervoContext();
    context.FilmeSet.Add(filme);
    context.SaveChanges();
    return Results.Ok(filme);
});

app.MapGet("Filme/Litar/{id:int}", (int id)  =>
{
    using var context = new AcervoContext();
    var filme = context.FilmeSet.Find(id);
    return Results.Ok(filme);

});

app.MapPut("Filme/Atualizar", (Filme filme) =>
{
    using var context = new AcervoContext();
    context.FilmeSet.Update(filme);
    context.SaveChanges();
    return Results.Ok("Filme atualizado com sucesso!");
});

app.MapDelete("Filme/Remover/{id:int}", (int id) =>
{
    using var context = new AcervoContext(); 
    var filme = context.FilmeSet.Find(id);
    context.FilmeSet.Remove(filme);
    context.SaveChanges();
    return Results.Ok("Filme removido com Sucesso");
});

app.Run();

