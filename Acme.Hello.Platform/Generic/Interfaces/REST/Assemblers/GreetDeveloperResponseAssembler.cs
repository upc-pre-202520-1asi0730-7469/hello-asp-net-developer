using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembler for converting Developer entities to GreetDeveloperResponse objects.
/// </summary>
/// <remarks>
/// This class provides methods to convert from Developer entities to REST response objects.
/// It handles null entities and entities with missing names by providing default responses.
/// </remarks>
public static class GreetDeveloperResponseAssembler
{
    /// <summary>
    /// Converts a <see cref="Developer"/> entity to a <see cref="GreetDeveloperResponse"/> object.
    /// If the entity is null or has any empty names, returns a default response for an anonymous developer.
    /// </summary>
    /// <param name="entity">The <see cref="Developer"/> entity to convert.</param>
    /// <returns>A <see cref="GreetDeveloperResponse"/> object.</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if (entity == null || entity.HasAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(), 
            $"Congrats {entity.GetFullName()}! You are an ASP.NET Core Developer!");
    }
}