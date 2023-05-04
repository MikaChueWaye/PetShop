namespace PetShopApp
{
    public abstract class Arachne : Animal
    {
        static private float POIDS_MAX_ARACHNE = 0.5f;
        static private int AGE_MAX_ARACHNE = 5;
        static private float QTTE_MAX_NOURRITURE_ARACHNE = 20;

        public Arachne(string pNom, float pPoids, int pAge, float pQtteNourriture):base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _race = AnimalRace.Arachne;
        }

        public Arachne(string pNom) : base(pNom)
        {
            _poids = (float)(RAND.NextDouble() * POIDS_MAX_ARACHNE);
            _age = RAND.Next(AGE_MAX_ARACHNE);
            _qtteNourriture = (float)(RAND.NextDouble() * QTTE_MAX_NOURRITURE_ARACHNE);
        }
    }
}