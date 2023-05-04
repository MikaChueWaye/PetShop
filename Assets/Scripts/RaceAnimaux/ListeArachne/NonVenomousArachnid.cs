namespace PetShopApp
{
    public abstract class NonVenomousArachnid : Arachne
    {
        public NonVenomousArachnid(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_inoffensive;
    }
}