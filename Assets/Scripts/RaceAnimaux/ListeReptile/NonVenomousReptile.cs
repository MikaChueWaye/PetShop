namespace PetShopApp
{
    public abstract class NonVenomousReptile<T> : Reptile<T> where T : NonVenomousAnimalData
    {
        public NonVenomousReptile(T pData) : base(pData)
        {
        }
    }

    public class Lezard : NonVenomousReptile<LezardData>
    {
        public Lezard(LezardData pData) : base(pData)
        {
        }
    }

    public class Tortue : NonVenomousReptile<TortueData>
    {
        public Tortue(TortueData pData) : base(pData)
        {
        }
    }
}