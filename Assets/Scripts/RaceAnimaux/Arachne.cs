namespace PetShopApp
{
    public abstract class Arachne<T> : Animal<T> where T : AnimalData
    {
        public Arachne(T pData) : base(pData)
        {
        }

    }
}