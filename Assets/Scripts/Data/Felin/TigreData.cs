
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "TigreData", menuName = "Data/TigreData")]
    public class TigreData : NonVenomousAnimalData
    {
        public TigreData() : base()
        {
            _name = Names.RandomFelineName();
            _poids = 30;
            _age = 10;
            _regimeAlimentaire = FoodType.Boeuf | FoodType.Porc |FoodType.Poulet | FoodType.Rongeur;
            _race = AnimalRace.Felin;
            _talk = "Roar";
        }
    }
}

