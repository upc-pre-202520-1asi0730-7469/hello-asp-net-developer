using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembler for Developer entity and related requests/responses.
/// </summary>
/// <remarks>
/// This class provides methods to convert from REST request objects to Developer entities.
/// </remarks>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a <see cref="GreetDeveloperRequest"/> object to a <see cref="Developer"/> entity.
    /// Returns null if the request is null or if required fields are missing.
    /// </summary>
    /// <param name="request">The <see cref="GreetDeveloperRequest"/> object to convert.</param>
    /// <returns>A <see cref="Developer"/> entity or null if conversion is not possible.</returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.FirstName) 
                            || string.IsNullOrWhiteSpace(request.LastName))
            return null;
        return new Developer(request.FirstName, request.LastName);
    }
}