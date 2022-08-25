using System.Collections.Generic;

namespace Rest_API_With_ASP_NET.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
