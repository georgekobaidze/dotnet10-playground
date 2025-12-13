using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddValidation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/register", (UserModel user) =>
{
    return Results.Ok($"User {user.Username} registered successfully!");
});

app.Run();

public record UserModel(
    [Required]
    string Username,

    [Required, EmailAddress]
    string Email,

    [Required, MinLength(8)]
    string Password,
    
    [property: Compare(nameof(UserModel.Password))]
    string ConfirmPassword
    );