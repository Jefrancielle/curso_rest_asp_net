using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace Rest_API_With_ASP_NET.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
