namespace PetShopApp
{
    public class Chat : Felin
    {
        public Chat(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_grave;

        public override FoodType RegimeAlimentaire => FoodType.Poulet | FoodType.Boeuf | FoodType.Porc | FoodType.Rongeur;

        public override string Talk => "Meow";

    }
}