namespace PetShopApp
{
    public abstract class Reptile : Animal
    {
        public override float QtteMaxNourriturePredefini => 500;
        public override int AgeMax => 5;
        public override float PoidsMax => 8;
        public override AnimalRace Race => AnimalRace.Reptile;
        public Reptile(string pNom) : base(pNom)
        {
        }

    }
}