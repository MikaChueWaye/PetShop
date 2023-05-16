using UnityEngine;
using static Venom;

namespace PetShopApp

{
    public abstract class VenomousInsect<T> : Insecte<T>, IVenomous where T : VenomousAnimalData
    {
        public VenomousInsect(T pData) : base(pData)
        {
        }
        public VenomousInsect() { }



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

    public class Scorpion : VenomousInsect<ScorpionData>
    {
        public Scorpion(ScorpionData pData) : base(pData)
        {
        }

        public Scorpion() { }

    }
}