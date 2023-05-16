using UnityEngine;
using static Venom;

namespace PetShopApp

{
    public abstract class VenomousReptile<T> : Reptile<T>, IVenomous where T : VenomousAnimalData
    {
        public VenomousReptile(T pData) : base(pData)
        {
        }
        public VenomousReptile() { }

        public VenomDangerosity Dangerosity => _data.Dangerosity;
        public AntiVenom EffectiveAntiVenom => _data.EffectiveAntiVenom;
        public Aggressivity SpeciesAggressivity => _data.SpeciesAggressivity;

        public bool Bite() => Venom.Bite(RAND, _data.SpeciesAggressivity);

        public override void Nourrir(FoodType pFoodType, float pQtteNourriture)
        {
            if (Bite())
            {
                throw new PoisonedException(Nom, EffectiveAntiVenom, Dangerosity);
            }
            base.Nourrir(pFoodType, pQtteNourriture);
        }
    }

    public class Vipere : VenomousReptile<VipereData>
    {
        public Vipere(VipereData pData) : base(pData)
        {
        }

        public Vipere() { }

    }

    public class CobraRoyal : VenomousReptile<CobraRoyalData>
    {
        public CobraRoyal(CobraRoyalData pData) : base(pData)
        {
        }

        public CobraRoyal() { }

    }
}