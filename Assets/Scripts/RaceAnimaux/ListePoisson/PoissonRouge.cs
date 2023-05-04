namespace PetShopApp
{
    public class PoissonRouge : Poisson
    {
        public PoissonRouge(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _regimeAlimentaire = Animal.FoodType.Larves;
        }

        public PoissonRouge(string pNom) : base(pNom)
        {
            _nom = pNom;
        }

        public override TypeMorsure Mordre() => Animal.TypeMorsure.Morsure_inoffensive;

        public override string Talk => "Bloup Bloup Bloup";
    }
}