namespace PetShopApp
{
    public class Mygale : VenomousArachnid
    {
        public Mygale(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Criquet | FoodType.Papillon;
    }
}