namespace PetShopApp
{
    public abstract class Reptile<T> : Animal<T> where T : AnimalData
    {
        public Reptile(T pData) : base(pData)
        {
        }

        public Reptile() { }

    }
}