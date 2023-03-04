﻿using Assignment_3V2.Interface;
using Tweetinvi.Models.V2;

namespace Assignment_3V2.Models
{
    public class MovieActorsVM
    {
        public Movie Movie { get; set; }
        public List<Actor> Actors { get; set; }
        public TweetWrapper TweetWrapper { get; set; }
    }
}
