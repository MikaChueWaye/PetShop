namespace PetShopApp
{
    public abstract class NonVenomousFish : Poisson
    {
        public NonVenomousFish(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_inoffensive;
    }
}