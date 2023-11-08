using System.ComponentModel.DataAnnotations;

namespace GraphqlSQLServer.Entity
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int Country { get; set; }
    }
}
