namespace PetShopApp
{
    public abstract class NonVenomousInsect : Insecte
    {
        public NonVenomousInsect(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_inoffensive;
    }
}