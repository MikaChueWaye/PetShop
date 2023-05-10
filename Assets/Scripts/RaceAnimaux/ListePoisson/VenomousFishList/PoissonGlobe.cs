using static Venom;

namespace PetShopApp
{
    public class PoissonGlobe : VenomousFish
    {
        public PoissonGlobe(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Algue;

        public override VenomDangerosity Dangerosity => VenomDangerosity.mortelle;

        public override AntiVenom EffectiveAntiVenom => AntiVenom.Venoxil | AntiVenom.Coraliase;

        public override Aggressivity SpeciesAggressivity => Aggressivity.Pacifique;
    }
}