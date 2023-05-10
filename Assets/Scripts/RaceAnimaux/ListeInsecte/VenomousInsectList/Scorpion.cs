using static Venom;

namespace PetShopApp
{
    public class Scorpion : VenomousInsect
    {
        public Scorpion(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Criquet | FoodType.Papillon | FoodType.Rongeur;

        public override VenomDangerosity Dangerosity => VenomDangerosity.mortelle;

        public override AntiVenom EffectiveAntiVenom => AntiVenom.Venoxil | AntiVenom.Scorpitox;

        public override Aggressivity SpeciesAggressivity => Aggressivity.TresAgressif;

        

    }
}