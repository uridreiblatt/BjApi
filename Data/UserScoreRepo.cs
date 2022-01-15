using Microsoft.EntityFrameworkCore;
using BjApi.Models;
using System.Collections.Generic;

namespace BjApi.Data {
    public class UserScoreRepo : IUserScoreRepo
    {

        public AppDbContext _context { get; }

        public UserScoreRepo(AppDbContext context)
        {
            _context = context;            
        }
        public IEnumerable<UserScore> GetAllUserScore()
        {
            return _context.UserScores;
        }

        public UserScore GetUserScore(int Id)
        {           
           var res = _context.UserScores.FirstOrDefaultAsync( score => score.Id == Id);
            if (res.Result == null)
            {
                UserScore score = new UserScore() {  Id = 1 , UserId  =1 , UserLoses = 0 , UserProfit = 0 , Userwins = 0};
                CreateUserScore(score);
                SaveChanges();
                return score;
            }
           return res.Result;            
        }

        
        public void CreateUserScore(UserScore userScore)
        {
            _context.UserScores.Add(userScore);            
        }
        public void UpdateUserScore(UserScore userScore)
        {
            _context.UserScores.Update(userScore);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

    }
}