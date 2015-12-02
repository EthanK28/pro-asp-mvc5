using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    

    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal DiscountSize;

        public DefaultDiscountHelper(decimal discountParam)
        {
            DiscountSize = discountParam;
        }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (DiscountSize/ 100m * totalParam));
        }
    }
}
