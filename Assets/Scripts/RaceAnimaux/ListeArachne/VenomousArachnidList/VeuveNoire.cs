using static Venom;

namespace PetShopApp
{
    public class VeuveNoire : VenomousArachnid
    {
        public VeuveNoire(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Criquet | FoodType.Papillon;

        public override VenomDangerosity Dangerosity => VenomDangerosity.mortelle;

        public override AntiVenom EffectiveAntiVenom => AntiVenom.Venoxil | AntiVenom.ArachnoShield | AntiVenom.Spidrox;

        public override Aggressivity SpeciesAggressivity => Aggressivity.Agressif;

        

    }
}