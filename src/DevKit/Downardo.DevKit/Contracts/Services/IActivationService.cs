namespace Downardo.DevKit.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
