using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "VeuveNoireData", menuName = "Data/VeuveNoireData")]
    public class VeuveNoireData : VenomousArachneData
    {
        public VeuveNoireData() : base()
        {
            _poids = 0.35f;
            _age = 1;
            _regimeAlimentaire = FoodType.Criquet | FoodType.Papillon;
            _dangerosity = VenomDangerosity.mortelle;
            _effectiveAntiVenom = AntiVenom.Spidrox | AntiVenom.Venoxil;
            _speciesAggressivity = Aggressivity.Agressif;
            _tisseToile = true;
        }
    }
}

