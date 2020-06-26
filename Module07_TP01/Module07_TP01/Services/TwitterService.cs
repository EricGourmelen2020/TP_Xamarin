using Module07_TP01.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module07_TP01.Services
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string user, string psw)
        {
            if (user == "eric" && psw == "123456") 
            { 
                return true; 
            }

            return false;
        }

        public List<Tweet> getTweets()
        {
            return new List<Tweet>(){
                new Tweet(){ identifier = "00000000", creationDate = DateTime.Now.ToString(), userIdentifier="00000000", userName = "test0", userPseudo = "testPseudo"},
                new Tweet(){ identifier = "00000001", creationDate = DateTime.Now.ToString(), userIdentifier="00000001", userName = "test1", userPseudo = "testPseudo1"}
            };
        }
    }
}
