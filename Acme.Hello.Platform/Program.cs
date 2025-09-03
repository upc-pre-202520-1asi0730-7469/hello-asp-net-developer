using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.MapGet("/greetings", (string? firstName, string? lastName) =>
    {
        var developer = !string.IsNullOrWhiteSpace(firstName) 
                        || !string.IsNullOrWhiteSpace(lastName)
            ? new Developer(firstName, lastName)
            : null;
        var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
        return Results.Ok(response);
    })
    .WithName("GetGreeting")
    .WithOpenApi();

app.MapPost("/greetings", (GreetDeveloperRequest request) =>
{
    var developer = DeveloperAssembler.ToEntityFromRequest(request);
    var response = GreetDeveloperResponseAssembler.ToResponseFromEntity(developer);
    return Results.Created("/greetings",response);
})
.WithName("CreateGreeting")
.WithOpenApi();
app.Run();
