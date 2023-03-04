using Tweetinvi.Models.V2;

namespace Assignment_3V2.Models
{
    public class ActorMoviesVM
    {
        public Actor Actor { get; set; }
        public List<Movie> Movies { get; set; }

       public TweetWrapper TweetWrapper { get; set; }
    }
}
