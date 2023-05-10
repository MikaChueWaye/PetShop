namespace PetShopApp
{
    public abstract class NonVenomousReptile : Reptile
    {
        public NonVenomousReptile(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_inoffensive;
    }
}