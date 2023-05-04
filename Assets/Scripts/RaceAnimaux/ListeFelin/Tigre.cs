namespace PetShopApp
{
    public class Tigre : Felin
    {
        public Tigre(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_Fatale;

        public override FoodType RegimeAlimentaire => FoodType.Poulet | FoodType.Boeuf | FoodType.Porc;

        public override string Talk => "Roaar";

    }
}