namespace PetShopApp
{
    public class Mygale : Arachne
    {
        public Mygale(string pNom, float pPoids, int pAge, float pQtteNourriture): base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _regimeAlimentaire = Animal.FoodType.Insectes;
        }

        public Mygale(string pNom):base(pNom)
        {
            _nom = pNom;
        }

        public override TypeMorsure Mordre() => Animal.TypeMorsure.Morsure_venimeuse;

        public override string Talk => ". . .";
    }
}