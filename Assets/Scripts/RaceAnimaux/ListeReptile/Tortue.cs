namespace PetShopApp
{
    public class Tortue : Reptile
    {
        public Tortue(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _regimeAlimentaire = Animal.FoodType.Salade;
        }

        public Tortue(string pNom) : base(pNom)
        {
            _nom = pNom;
        }


        public override TypeMorsure Mordre() => Animal.TypeMorsure.Morsure_inoffensive;

        public override string Talk => ". . .";
    }
}