using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm(Url url, Campaign campaing)
{
    public Url Url { get; } = url;
    public Campaign Campaing { get;} = campaing;

    public override string ToString()
    {
        var segments = new List<string>();
        segments.AddIfNotNull("utm_source", Campaing.Source);
        segments.AddIfNotNull("utm_medium", Campaing.Medium);
        segments.AddIfNotNull("utm_campaign", Campaing.Name);
        segments.AddIfNotNull("utm_id",Campaing.Id);
        segments.AddIfNotNull("utm_term",Campaing.Term);
        segments.AddIfNotNull("utm_content",Campaing.Id);

        return $"{Url.Address}?{string.Join("&", segments)}";
    }
}