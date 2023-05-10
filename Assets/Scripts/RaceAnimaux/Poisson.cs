namespace PetShopApp
{
    public abstract class Poisson : Animal
    {
        public override float QtteMaxNourriturePredefini => 200;
        public override int AgeMax => 5;
        public override float PoidsMax => 5;
        public override AnimalRace Race => AnimalRace.Poisson;
        public Poisson(string pNom) : base(pNom)
        {
        }
        public override TypeMorsure Mordre => TypeMorsure.Morsure_inoffensive;

        public override string Talk => "Bloup Bloup Bloup";
    }
}