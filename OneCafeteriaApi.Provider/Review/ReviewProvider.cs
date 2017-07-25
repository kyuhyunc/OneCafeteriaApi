using System;
using System.Collections.Generic;
using System.Text;

namespace OneCafeteriaApi.Provider.Review
{
    public class ReviewProvider : IReviewProvider
    {
        public string[] Get()
        {
            return new string[] { "review controller1", "review controller1" };
        }
    }
}
