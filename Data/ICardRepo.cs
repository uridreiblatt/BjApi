using BjApi.Models;
using System.Collections.Generic;

namespace BjApi.Data {
   

    public interface ICardRepo {
       Card GetCard( );
       void AddCard(Card card);

        IEnumerable<Card> GetAllCards();

        Card GenerateCard();
       bool SaveChanges();


}


}