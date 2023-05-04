namespace PetShopApp
{
    public abstract class Reptile : Animal
    {
        static private float POIDS_MAX_REPTILE = 5;
        static private int AGE_MAX_REPTILE = 15;
        static private float QTTE_NOURRITURE_MAX_RETILE = 300;

        public Reptile(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _race = AnimalRace.Reptile;
            
        }

        public Reptile(string pNom) : base(pNom)
        {
            _poids = (float)(RAND.NextDouble() * POIDS_MAX_REPTILE);
            _age = RAND.Next(AGE_MAX_REPTILE);
            _qtteNourriture = (float)(RAND.NextDouble() * QTTE_NOURRITURE_MAX_RETILE);
        }
    }
}