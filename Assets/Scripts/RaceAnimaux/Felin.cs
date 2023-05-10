namespace PetShopApp
{
    public abstract class Felin : Animal
    {
        public override float QtteMaxNourriturePredefini => 1000;
        public override int AgeMax => 20;
        public override float PoidsMax => 10;
        public override AnimalRace Race => AnimalRace.Felin;

        public Felin(string pNom) : base(pNom)
        {
        }
    }
}