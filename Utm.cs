using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm(Url url, Campaign campaign)
{
    public Url Url { get; } = url;
    public Campaign Campaign { get;} = campaign;

    public override string ToString()
    {
        var segments = new List<string>();
        segments.AddIfNotNull("utm_source", Campaign.Source);
        segments.AddIfNotNull("utm_medium", Campaign.Medium);
        segments.AddIfNotNull("utm_campaign", Campaign.Name);
        segments.AddIfNotNull("utm_id",Campaign.Id);
        segments.AddIfNotNull("utm_term",Campaign.Term);
        segments.AddIfNotNull("utm_content",Campaign.Content);
        return $"{Url.Address}?{string.Join("&", segments)}";
    }
}