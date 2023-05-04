namespace PetShopApp
{
    public abstract class VenomousArachnid : Arachne
    {
        public VenomousArachnid(string pNom):base(pNom)
        {
        }

        public override TypeMorsure Mordre=>TypeMorsure.Morsure_venimeuse;
    }
}