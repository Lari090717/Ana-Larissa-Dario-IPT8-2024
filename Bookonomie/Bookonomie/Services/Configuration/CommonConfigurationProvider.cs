namespace Bookonomie.Services.Configuration;

public class CommonConfigurationProvider(IConfiguration configuration) : ICommonConfigurationProvider
{
    public T GetSettings<T>() where T : class, ICommonSettings
    {
        var settings = configuration.GetSection(typeof(T).Name).Get<T>();

        return settings ?? throw new InvalidOperationException($"Unable to get {typeof(T).Name} settings section.");
    }
}
