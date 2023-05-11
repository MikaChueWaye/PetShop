
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "PoissonRougeData", menuName = "Data/PoissonRougeData")]
    public class PoissonRougeData : NonVenomousAnimalData
    {
        public PoissonRougeData() : base()
        {
            _name = Names.RandomFishName();
            _poids = 0.35f;
            _age = 1;
            _regimeAlimentaire = FoodType.Algue;
            _race = AnimalRace.Poisson;
            _talk = "Bloup Bloup Bloup";
        }
    }
}

