using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryStrategy
{

    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal unitPrice, int quantity);
    }
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage = 0.2m;

        public decimal ApplyDiscount(decimal unitPrice, int quantity)
        {
            var total = unitPrice * quantity;
            return total - (total * _percentage);
        }
    }

    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly decimal _amount = 10m;

        public decimal ApplyDiscount(decimal unitPrice, int quantity)
        {
            var total = unitPrice * quantity;
            return total - _amount;
        }
    }

    public class BuyOneGetOneDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal unitPrice, int quantity)
        {
            var payableQuantity = (quantity / 2) + (quantity % 2);
            return unitPrice * payableQuantity;
        }
    }

    /// <summary>
    /// //////
    /// </summary>


    public interface IDiscountFactory
    {
        IDiscountStrategy GetStrategy(DiscountType type);
    }
    public class DiscountFactory : IDiscountFactory
    {
        private readonly IReadOnlyDictionary<DiscountType, Func<IDiscountStrategy>> _strategyResolvers;

        public DiscountFactory(IReadOnlyDictionary<DiscountType, Func<IDiscountStrategy>> strategyResolvers)
        {
            _strategyResolvers = strategyResolvers;
        }

        public IDiscountStrategy GetStrategy(DiscountType type)
        {
            if (_strategyResolvers.TryGetValue(type, out var resolver))
            {
                return resolver();
            }

            throw new ArgumentOutOfRangeException(nameof(type), $"Unsupported discount type: {type}");
        }
    }

    public interface IPurchaseService
    {
        decimal CalculateFinalPrice(decimal unitPrice, int quantity, DiscountType discountType);
    }

    public class PurchaseService : IPurchaseService
    {
        private readonly IDiscountFactory _discountFactory;

        public PurchaseService(IDiscountFactory discountFactory)
        {
            _discountFactory = discountFactory;
        }

        public decimal CalculateFinalPrice(decimal unitPrice, int quantity, DiscountType discountType)
        {
            var strategy = _discountFactory.GetStrategy(discountType);
            return strategy.ApplyDiscount(unitPrice, quantity);
        }
    }


    internal class FactoryStrategy
    {
    
    
    }

   public enum DiscountType
    {
        Percentage, 
        FixedAmount, 
        BuyOneGetOne
    }
}

