namespace PetShopApp
{
    public abstract class NonVenomousReptile : Reptile<NonVenomousAnimalData>
    {
        public NonVenomousReptile(NonVenomousAnimalData pData) : base(pData)
        {
        }
    }

    public class Lezard : NonVenomousReptile
    {
        public Lezard(LezardData pData) : base(pData)
        {
        }
    }

    public class Tortue : NonVenomousReptile
    {
        public Tortue(TortueData pData) : base(pData)
        {
        }
    }
}