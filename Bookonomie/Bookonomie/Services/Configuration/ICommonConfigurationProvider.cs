namespace Bookonomie.Services.Configuration;

public interface ICommonConfigurationProvider
{
    public T GetSettings<T>() where T : class, ICommonSettings;
}
