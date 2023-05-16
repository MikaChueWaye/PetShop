namespace PetShopApp
{
    public abstract class NonVenomousFish<T> : Poisson<T> where T : NonVenomousAnimalData
    {
        public NonVenomousFish(T pData) : base(pData)
        {
        }

        public NonVenomousFish() { }

    }

    public class PoissonRouge : NonVenomousFish<PoissonRougeData>
    {
        public PoissonRouge(PoissonRougeData pData) : base(pData)
        {
        }
        public PoissonRouge() { }

    }
}