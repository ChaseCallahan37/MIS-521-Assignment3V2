using Assignment_3V2.Models;
using Tweetinvi.Models.V2;

namespace Assignment_3V2.Interface
{
    public interface ITweetWrapper
    {
        public Task<List<InternalTweet>> GetTweetsAsync(ITweetable item);
        public List<InternalTweet> GetAllTweetsInternal();

    }
}
