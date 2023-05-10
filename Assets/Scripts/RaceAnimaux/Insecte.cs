namespace PetShopApp
{
    public abstract class Insecte : Animal
    {
        public override float QtteMaxNourriturePredefini => 200;
        public override int AgeMax => 5;
        public override float PoidsMax => 0.5f;
        public override AnimalRace Race => AnimalRace.Insecte;

        public Insecte(string pNom) : base(pNom)
        {
        }

        public override string Talk => ". . .";
    }
}