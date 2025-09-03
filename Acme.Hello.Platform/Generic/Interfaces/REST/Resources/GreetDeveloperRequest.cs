namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Request to greet a developer.
/// </summary>
/// <remarks>
/// This record is used in the GreetDeveloper endpoint to capture the first and last name of the developer to be greeted.
/// Both fields are optional and can be null.
/// </remarks>
/// <param name="FirstName">The first name of the developer to be greeted. Optional.</param>
/// <param name="LastName">The last name of the developer to be greeted. Optional.</param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);