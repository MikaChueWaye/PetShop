namespace PetShopApp
{
    public abstract class Canin : Animal
    {
        static private float POIDS_MAX_CANIN = 20;
        static private int AGE_MAX_CANIN = 15;
        static private float QTTE_MAX_NOURRITURE_CANIN = 1000;

        public Canin(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _race = AnimalRace.Canin;
        }

        public Canin(string pNom) : base(pNom)
        {
            _poids = (float)(RAND.NextDouble() * POIDS_MAX_CANIN);
            _age = RAND.Next(AGE_MAX_CANIN);
            _qtteNourriture = (float)(RAND.NextDouble() * QTTE_MAX_NOURRITURE_CANIN);
        }
    }
}