namespace Generics
{
    // example of contraint to class.   T must of given Class type or any of its subclasses
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount (TProduct product)
        {
            return product.Price;
        }
    }
}
