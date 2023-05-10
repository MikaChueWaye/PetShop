namespace PetShopApp
{
    public class PoissonRouge : NonVenomousFish
    {
        public PoissonRouge(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Algue | FoodType.Larve ;

    }
}