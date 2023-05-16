namespace PetShopApp
{
    public abstract class NonVenomousInsect<T> : Insecte<T> where T : NonVenomousAnimalData
    {
        public NonVenomousInsect(T pData) : base(pData)
        {
        }

        public NonVenomousInsect() { }

    }
}