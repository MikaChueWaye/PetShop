using UnityEngine;
using static Venom;

namespace PetShopApp

{
    public abstract class VenomousArachnid<T> : Arachne<T>, IVenomous where T: VenomousArachneData
    {
        public VenomousArachnid(T pData) : base(pData)
        {

        }

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

    public class Mygale : VenomousArachnid<MygaleData>
    {
        public Mygale(MygaleData pData) : base(pData)
        {

        }

    }

    public class VeuveNoire : VenomousArachnid<VeuveNoireData>
    {
        public VeuveNoire(VeuveNoireData pData) : base(pData)
        {

        }

    }
}