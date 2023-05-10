using UnityEngine;
using static Venom;

namespace PetShopApp

{
    public abstract class VenomousInsect : Insecte, IVenomous
    {

        public VenomousInsect(string pNom):base(pNom)
        {
        }

        public override TypeMorsure Mordre=>TypeMorsure.Morsure_venimeuse;
        public abstract VenomDangerosity Dangerosity { get; }
        public abstract AntiVenom EffectiveAntiVenom { get; }
        public abstract Aggressivity SpeciesAggressivity { get; }
        public bool Bite()
        {
            int lProbability = RAND.Next(100);
            if (lProbability <= (int)SpeciesAggressivity)
            {
                Debug.Log($"{_nom} a mordu le soigneur");
                return true;
            }
            else return false;
        }
        public override void Nourrir(FoodType pFoodType, float pQtteNourriture)
        {
            if (Bite())
            {
                throw new PoisonedException(_nom, EffectiveAntiVenom, Dangerosity);
            }
            base.Nourrir(pFoodType, pQtteNourriture);
        }
    }
}