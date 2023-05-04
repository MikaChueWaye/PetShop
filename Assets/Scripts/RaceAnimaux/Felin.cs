namespace PetShopApp
{
    public abstract class Felin : Animal
    {
        static private float POIDS_MAX_FELIN = 10;
        static private int AGE_MAX_FELIN = 15;
        static private float QTTE_MAX_NOURRITURE_FELIN = 1000;

        public Felin(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _race = AnimalRace.Felin;
        }

        public Felin(string pNom) : base(pNom)
        {
            _poids = (float)(RAND.NextDouble() * POIDS_MAX_FELIN);
            _age = RAND.Next(AGE_MAX_FELIN);
            _qtteNourriture = (float)(RAND.NextDouble() * QTTE_MAX_NOURRITURE_FELIN);
        }
    }
}