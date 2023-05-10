using System;
using UnityEngine;
using static Venom;

namespace PetShopApp
{
    public class Vipere : VenomousReptile
    {
        public Vipere(string pNom) : base(pNom)
        {
        }

        public override FoodType RegimeAlimentaire => FoodType.Criquet | FoodType.Papillon | FoodType.Rongeur ;

        public override string Talk => "Kssssssss";

        public override VenomDangerosity Dangerosity => VenomDangerosity.moyenne;

        public override AntiVenom EffectiveAntiVenom => AntiVenom.CobraShield | AntiVenom.SerpentineX | AntiVenom.Vipertox | AntiVenom.Venoxil;

        public override Aggressivity SpeciesAggressivity => Aggressivity.Agressif;
    }
}