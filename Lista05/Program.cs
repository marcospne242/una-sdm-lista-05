using System;
using Lista05.Models;


Todo todoEx = new Todo
{
    UserId = 1,
    Id = 1,
    Title = "delectus aut autem",
    Completed = false
};

Console.WriteLine($"To-do: {todoEx.Title} | Completo: {todoEx.Completed}");

Post postEx = new Post
{
    UserId = 1,
    Id = 101,
    Title = "Introdução ao C#",
    Body = "Este post explica os conceitos básicos de C# e .NET."
};

Console.WriteLine($"Post: {postEx.Title} | Conteúdo: {postEx.Body}");

Usuario usuarioEx = new Usuario
{
    Id = 1,
    Name = "Maria Silva",
    Username = "maria.s",
    Email = "maria.silva@email.com",
    Phone = "31-99999-8888"
};

Console.WriteLine($"Usuário: {usuarioEx.Name} | Email: {usuarioEx.Email}");
