namespace PetShopApp
{
    public class NonVenomousArachnid<T> : Arachne<T> where T : NonVenomousAnimalData
    {
        public NonVenomousArachnid(T pData) : base(pData)
        {
        }

    }
}