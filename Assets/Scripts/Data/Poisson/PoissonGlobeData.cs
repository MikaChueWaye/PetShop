
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "PoissonGlobeData", menuName = "Data/PoissonGlobeData")]
    public class PoissonGlobeData : VenomousAnimalData
    {
        public PoissonGlobeData() : base()
        {
            _name = Names.RandomFishName();
            _poids = 1;
            _age = 1;
            _regimeAlimentaire = FoodType.Larve | FoodType.Algue;
            _race = AnimalRace.Poisson;
            _talk = "Bloup Bloup Bloup";
            _dangerosity = VenomDangerosity.mortelle;
            _effectiveAntiVenom = AntiVenom.Venoxil | AntiVenom.Coraliase;
            _speciesAggressivity = Aggressivity.Pacifique;
        }
    }
}

