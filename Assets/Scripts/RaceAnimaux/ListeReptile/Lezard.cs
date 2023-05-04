namespace PetShopApp
{
    public class Lezard : Reptile
    {
        public Lezard(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _regimeAlimentaire = Animal.FoodType.Insectes;
        }

        public Lezard(string pNom) : base(pNom)
        {
            _nom = pNom;
        }

        public override TypeMorsure Mordre() => Animal.TypeMorsure.Morsure_inoffensive;

        public override string Talk => "Psst psst psst";
    }
}