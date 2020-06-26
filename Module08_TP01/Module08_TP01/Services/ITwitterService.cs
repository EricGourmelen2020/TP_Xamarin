using Module08_TP01.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module08_TP01.Services
{
    interface ITwitterService
    {
        bool authenticate(String user, String psw); 
        List<Tweet> getTweets();
    }
}
