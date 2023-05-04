namespace PetShopApp
{
    public class Tigre : Felin
    {
        public Tigre(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _regimeAlimentaire = Animal.FoodType.Viande;
        }

        public Tigre(string pNom) : base(pNom)
        {
            _nom = pNom;
        }

        public override TypeMorsure Mordre() => Animal.TypeMorsure.Morsure_Fatale;

        public override string Talk => "Roaar";
    }
}