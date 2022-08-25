using Rest_API_With_ASP_NET.Hypermedia.Abstract;
using System.Collections.Generic;

namespace Rest_API_With_ASP_NET.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
