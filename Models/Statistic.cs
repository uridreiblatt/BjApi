using System.ComponentModel.DataAnnotations;

namespace BjApi.Models
{
    public class Statistic
    {
        [Key]
        public int Id { get; set; } 
        public string Info { get; set; }
    }
}
