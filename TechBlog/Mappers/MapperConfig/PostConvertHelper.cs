using Domain_Models;
using Domain_Models.Enums;

namespace Mappers
{
    public static class PostConvertHelper
    {
        public static decimal GetPostRating(List<Star> stars)
        {
            if(stars.Count < 1) return 0;
            return stars.Sum(x => x.Rating) / stars.Count;
        }
        public static string GetPostTags(List<string> tags) => string.Join(",", tags);
        
    }
}
