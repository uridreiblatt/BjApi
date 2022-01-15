using Microsoft.EntityFrameworkCore;
using BjApi.Models;
using System;
using System.Collections.Generic;

namespace BjApi.Data {
    public class CardRepo : ICardRepo
    {
          public CardRepo(AppDbContext context)
        {
            _context = context;
            
        }

        public AppDbContext _context { get; }


        public IEnumerable<Card> GetAllCards()
        {
            return _context.Cards;
        }

        public Card GetCard()
        {
            return  GenerateCard();

        }

        public void AddCard(Card card)
        {
            _context.Cards.Add(card);
        }
        

        public Card GenerateCard()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 14);
            int randomcardType = random.Next(1, 4); 
            CardType e = (CardType ) randomcardType;
            return  new Card(){ CardNmber = randomNumber , cardType = e  };
        }


        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0 );
        }

        
    }
}