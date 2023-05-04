namespace PetShopApp
{
    public class Chien : Canin
    {
        public Chien(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _regimeAlimentaire = Animal.FoodType.Viande;
        }

        public Chien(string pNom) : base(pNom)
        {
            _nom = pNom;
        }

        public override TypeMorsure Mordre() => Animal.TypeMorsure.Morsure_grave;

        public override string Talk => "Ouaf";
    }
}