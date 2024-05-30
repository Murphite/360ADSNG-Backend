using Microsoft.AspNetCore.Mvc.ModelBinding;
using _360AdsNG.Application.Dtos;

namespace _360AdsNG.API.Extensions;

public static class ModelStateExtensions
{
    public static IEnumerable<Error> GetErrors(this ModelStateDictionary modelState)
    {
        var errors =  modelState
            .Where(e => e.Value?.ValidationState == ModelValidationState.Invalid)
            .SelectMany(e => e.Value?.Errors, (key, error) => new Error(key.Key, error.ErrorMessage));

        return errors;
    }
}
