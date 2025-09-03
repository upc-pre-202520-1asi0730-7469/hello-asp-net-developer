namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Response returned when greeting a developer.
/// </summary>
/// <remarks>
/// This record encapsulates the response details when a developer is greeted.
/// It includes the developer's ID, full name, and a message.
/// </remarks>
/// <param name="Id">The unique identifier of the developer.</param>
/// <param name="FullName">The full name of the developer.</param>
/// <param name="Message">A message associated with the greeting.</param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GreetDeveloperResponse"/> record with only a message.
    /// </summary>
    /// <remarks>
    /// This constructor allows creating a response with just a message, leaving the ID and full name as null.
    /// </remarks>
    /// <param name="message">The message associated with the greeting.</param>
    public GreetDeveloperResponse(string message) : this(null, null, message) { }
}