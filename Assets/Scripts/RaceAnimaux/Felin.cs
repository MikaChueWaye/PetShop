namespace PetShopApp
{
    public abstract class Felin : Animal<NonVenomousAnimalData>
    {
        public Felin(NonVenomousAnimalData pData) : base(pData)
        {
        }
    }
}