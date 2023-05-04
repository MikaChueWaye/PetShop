namespace PetShopApp
{
    public class Chien : Canin
    {
        public Chien(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Poulet | FoodType.Boeuf | FoodType.Porc | FoodType.Criquet | FoodType.Salade | FoodType.Tomate;
    }
}