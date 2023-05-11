using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "MygaleData", menuName = "Data/MygaleData")]
    public class MygaleData : VenomousArachneData
    {
        public MygaleData() : base()
        {
            _poids = 0.25f;
            _age = 1;
            _regimeAlimentaire = FoodType.Criquet | FoodType.Papillon;
            _dangerosity = VenomDangerosity.moyenne;
            _effectiveAntiVenom = AntiVenom.Addertox | AntiVenom.Spidrox | AntiVenom.Venoxil;
            _speciesAggressivity = Aggressivity.Normal;
            _tisseToile = true;
        }
    }
}

