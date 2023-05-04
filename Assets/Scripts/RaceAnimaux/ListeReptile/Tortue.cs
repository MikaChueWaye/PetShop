namespace PetShopApp
{
    public class Tortue : Reptile
    {
        public Tortue(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_inoffensive;

        public override FoodType RegimeAlimentaire => FoodType.Salade | FoodType.Tomate | FoodType.Oignon | FoodType.Algue;

        public override string Talk => ". . .";
    }
}