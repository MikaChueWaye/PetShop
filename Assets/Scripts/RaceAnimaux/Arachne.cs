namespace PetShopApp
{
    public abstract class Arachne : Animal
    {
        public override float QtteMaxNourriture => 20;
        public override int AgeMax => 5;
        public override float PoidsMax => 0.5f;
        public override AnimalRace Race => AnimalRace.Arachne;

        public Arachne(string pNom) : base(pNom)
        {
        }

        public override string Talk => ". . .";
    }
}