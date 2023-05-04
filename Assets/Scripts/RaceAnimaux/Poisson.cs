namespace PetShopApp
{
    public abstract class Poisson : Animal
    {
        static private float POIDS_MAX_POISSON = 1;
        static private int AGE_MAX_POISSON = 10;
        static private float QTTE_MAX_NOURRITURE_POISSON = 20;

        public Poisson(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _race = AnimalRace.Poisson;
        }

        public Poisson(string pNom) : base(pNom)
        {
            _poids = (float)(RAND.NextDouble() * POIDS_MAX_POISSON);
            _age = RAND.Next(AGE_MAX_POISSON);
            _qtteNourriture = (float)(RAND.NextDouble() * QTTE_MAX_NOURRITURE_POISSON);
        }
    }
}