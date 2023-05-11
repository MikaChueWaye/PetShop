namespace PetShopApp
{
    public abstract class NonVenomousFish : Poisson<NonVenomousAnimalData>
    {
        public NonVenomousFish(NonVenomousAnimalData pData) : base(pData)
        {
        }
    }

    public class PoissonRouge : NonVenomousFish
    {
        public PoissonRouge(PoissonRougeData pData) : base(pData)
        {
        }
    }
}