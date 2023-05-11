namespace PetShopApp
{
    public abstract class Poisson<T> : Animal<T> where T : AnimalData
    {
        public Poisson(T pData) : base(pData)
        {
        }
    }
}