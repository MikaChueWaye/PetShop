using UnityEngine;
using static Venom;

namespace PetShopApp

{
    public abstract class VenomousFish<T> : Poisson<T>, IVenomous where T : VenomousAnimalData
    {
        public VenomousFish(T pData) : base(pData)
        {
        }

        public VenomousFish() { }

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

    public class PoissonGlobe : VenomousFish<PoissonGlobeData>
    {
        public PoissonGlobe(PoissonGlobeData pData) : base(pData)
        {
        }

        public PoissonGlobe() { }

    }
}