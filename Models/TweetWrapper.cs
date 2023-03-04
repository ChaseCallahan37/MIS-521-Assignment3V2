using Assignment_3V2.Interface;
using Tweetinvi;
using Tweetinvi.Models.V2;
using Tweetinvi.Parameters;

namespace Assignment_3V2.Models
{
    public class TweetWrapper : ITweetWrapper
    {
        public TwitterClient UserClient { get; set; }
        public List<InternalTweet> InternalTweets = new List<InternalTweet>();
        public string TotalSentiment { get { 
            double totalSentiment = 0;
                int count = 0;

                foreach (var tweet in InternalTweets)
                {
                    if(tweet.Sentiment != 0)
                    {
                        totalSentiment += tweet.Sentiment;
                        count++;
                    }
                }
                System.Console.WriteLine("H");
                return string.Format("{0:0.###}",(totalSentiment/count));
            } }
        private ITweetable Item { get; set; }

        public TweetWrapper() {
            UserClient = new TwitterClient(@"AAx9UfdCemph0Pg0t8Moq5c6L", 
                "LbhoERpFGjBESYSNjTHuRvE0R80cGxZBx5lJWanM5lFpO2Hs63", 
                "1455230009153503238-WTxQgoYUAQ3D9PTSsUu8stHkmJvuVe", 
                "2ZVnM9tWbCSNAhyJcyC4WPIgiIbUWZ77MTLSx2Qb8TkW3");
        }

        public async Task<List<InternalTweet>> GetTweetsAsync(ITweetable item)
        {
            Item = item;
            var response = await UserClient.SearchV2.SearchTweetsAsync(item.SearchTerm());
            foreach (var tweet in response.Tweets)
            {
                InternalTweets.Add(new InternalTweet(tweet));
            }
            return InternalTweets;
        }

      

        public List<InternalTweet> GetAllTweetsInternal()
        {
            return InternalTweets;
        }
    }
}
