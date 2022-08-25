using System.ComponentModel.DataAnnotations.Schema;

namespace Rest_API_With_ASP_NET.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
