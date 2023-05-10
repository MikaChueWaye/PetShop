using System;
using UnityEngine;
using static Venom;

namespace PetShopApp
{
    public class CobraRoyal : VenomousReptile
    {
        public CobraRoyal(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Criquet | FoodType.Papillon | FoodType.Rongeur ;

        public override string Talk => "Kssssssss";

        public override VenomDangerosity Dangerosity => VenomDangerosity.mortelle;

        public override AntiVenom EffectiveAntiVenom => AntiVenom.CobraShield | AntiVenom.SerpentineX | AntiVenom.Venoxil;

        public override Aggressivity SpeciesAggressivity => Aggressivity.TresAgressif;
    }
}