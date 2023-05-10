using static Venom;

namespace PetShopApp
{
    public class Mygale : VenomousArachnid
    {
        public Mygale(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Criquet | FoodType.Papillon;

        public override VenomDangerosity Dangerosity => VenomDangerosity.moyenne;

        public override AntiVenom EffectiveAntiVenom => AntiVenom.Venoxil | AntiVenom.ArachnoShield | AntiVenom.Spidrox;

        public override Aggressivity SpeciesAggressivity => Aggressivity.Normal;

        

    }
}