namespace PetShopApp
{
    public abstract class Reptile : Animal
    {
        public override float QtteMaxNourriture => 20;
        public override int AgeMax => 5;
        public override float PoidsMax => 0.5f;
        public override AnimalRace Race => AnimalRace.Reptile;
        public Reptile(string pNom) : base(pNom)
        {
        }

    }
}