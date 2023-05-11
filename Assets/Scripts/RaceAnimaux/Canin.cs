namespace PetShopApp
{
    public abstract class Canin : Animal<NonVenomousAnimalData>
    {
        public Canin(NonVenomousAnimalData pData) : base(pData)
        {
        }
    }
}