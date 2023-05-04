namespace PetShopApp
{
    public abstract class Canin : Animal
    {
        public override float QtteMaxNourriture => 20;
        public override int AgeMax => 5;
        public override float PoidsMax => 0.5f;
        public override AnimalRace Race => AnimalRace.Canin;

        public Canin(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_grave;

        public override string Talk => "Woof";
    }
}