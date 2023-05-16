namespace PetShopApp
{
    public abstract class Canin<T> : Animal<T> where T : NonVenomousAnimalData
    {
        public Canin(T pData) : base(pData)
        {
        }

        public Canin() { }

    }
}