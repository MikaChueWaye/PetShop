namespace PetShopApp
{
    public abstract class Felin : Animal
    {
        public override float QtteMaxNourriture => 20;
        public override int AgeMax => 5;
        public override float PoidsMax => 0.5f;
        public override AnimalRace Race => AnimalRace.Felin;

        public Felin(string pNom) : base(pNom)
        {
        }
    }
}