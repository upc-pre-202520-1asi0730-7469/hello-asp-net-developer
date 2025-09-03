namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Developer entity in the Generic bounded context.
/// </summary>
/// <param name="firstName">The first name of the developer.</param>
/// <param name="lastName">The last name of the developer.</param>
public class Developer(string? firstName, string? lastName)
{
    public Guid Id { get;  } = Guid.NewGuid();
    
    public string FirstName { get;  } = string.IsNullOrWhiteSpace(firstName) 
        ? string.Empty 
        : firstName.Trim();

    public string LastName { get;  } = string.IsNullOrWhiteSpace(lastName) 
        ? string.Empty 
        : lastName.Trim();

    /// <summary>
    /// Gets the full name of the developer by concatenating the first and last names.
    /// </summary>
    /// <returns>A string with the format "FirstName LastName".</returns>
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    
    /// <summary>
    /// Checks if either the first name or last name is empty.
    /// </summary>
    /// <returns>True if either name is empty; otherwise, false.</returns>
    public bool HasAnyNameEmpty() => string.IsNullOrEmpty(FirstName) 
                                    || string.IsNullOrEmpty(LastName);
}

