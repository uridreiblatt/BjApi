using System.ComponentModel.DataAnnotations;

namespace BjApi.Models
{ 
    public enum CardType
    {
        spades =1, 
        hearts=2 , 
        diamonds=3, 
        clubs=4 ,
    }

    public class Card

    {
        [Key]
        public int  Id {get;set;}
        [Required]
        public CardType cardType {get;set;}
        public int CardNmber {get;set;}
        
    }


}