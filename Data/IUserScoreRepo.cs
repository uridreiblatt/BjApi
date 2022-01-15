using BjApi.Models;
using System.Collections.Generic;

namespace BjApi.Data {
   

    public interface IUserScoreRepo {
        IEnumerable<UserScore> GetAllUserScore();
        UserScore GetUserScore(int Id );
       void UpdateUserScore(UserScore userScore);

       bool SaveChanges();


}


}