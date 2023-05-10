namespace PetShopApp
{
    public abstract class Canin : Animal
    {
        public override float QtteMaxNourriturePredefini => 1000;
        public override int AgeMax => 20;
        public override float PoidsMax => 10;
        public override AnimalRace Race => AnimalRace.Canin;

        public Canin(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_grave;

        public override string Talk => "Woof";
    }
}