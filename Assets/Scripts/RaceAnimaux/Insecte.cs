namespace PetShopApp
{
    public abstract class Insecte<T> : Animal<T> where T : AnimalData
    {
        public Insecte(T pData) : base(pData)
        {
        }

        public Insecte() { }

    }
}