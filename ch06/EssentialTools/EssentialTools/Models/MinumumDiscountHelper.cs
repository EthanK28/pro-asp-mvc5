using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTools.Models
{
    public class MinumumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount (decimal totalParam)
        {
            if(totalParam < 0)
            {
                throw new ArgumentOutOfRangeException();
            } else if (totalParam > 100)
            {
                return totalParam * 0.9M;
            } else if(totalParam >= 10 && totalParam <= 100)
            {
                return totalParam - 5;
            } else
            {
                return totalParam;
            }
            
        }
    }
}
