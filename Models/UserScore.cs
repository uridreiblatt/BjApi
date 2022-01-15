using System.ComponentModel.DataAnnotations;

namespace BjApi.Models
{ 
    public class UserScore
    {
        [Key]
        public int  Id {get;set;}
        [Required]
        public int UserId {get;set;}
        public int Userwins {get;set;}
        public int UserLoses {get;set;}
        public int UserProfit {get;set;}

    }


}