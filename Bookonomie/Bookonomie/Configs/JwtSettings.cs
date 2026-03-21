using Bookonomie.Services.Configuration;

namespace Bookonomie.Configs;

public class JwtSettings : ICommonSettings
{
    public string Key { get; set; } = default!;

    public string Audience { get; set; } = default!;

    public string Issuer { get; set; } = default!;

    public string Subject { get; set; } = default!;
}
