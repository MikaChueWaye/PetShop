using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "VenomousArachneData", menuName = "Data/VenomousArachneData")]

    public class VenomousArachneData : ArachneData
    {
        [SerializeField] protected VenomDangerosity _dangerosity;
        [SerializeField] protected AntiVenom _effectiveAntiVenom;
        [SerializeField] protected Aggressivity _speciesAggressivity;

        public VenomDangerosity Dangerosity => _dangerosity;
        public AntiVenom EffectiveAntiVenom => _effectiveAntiVenom;
        public Aggressivity SpeciesAggressivity => _speciesAggressivity;


        public VenomousArachneData()
        {
            _morsure = TypeMorsure.Morsure_venimeuse;
        }


    }
}



