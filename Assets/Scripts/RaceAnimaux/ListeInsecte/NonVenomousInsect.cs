namespace PetShopApp
{
    public abstract class NonVenomousInsect : Insecte<NonVenomousAnimalData>
    {
        protected NonVenomousInsect(NonVenomousAnimalData pData) : base(pData)
        {
        }
    }
}