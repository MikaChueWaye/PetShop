namespace PetShopApp
{
    public abstract class Felin<T> : Animal<T> where T : NonVenomousAnimalData
    {
        public Felin(T pData) : base(pData)
        {
        }

        public Felin() { }

    }
}