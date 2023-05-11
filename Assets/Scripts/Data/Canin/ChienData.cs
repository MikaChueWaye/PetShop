
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "ChienData", menuName = "Data/ChienData")]
    public class ChienData : NonVenomousAnimalData
    {
        public ChienData() : base()
        {
            _name = Names.RandomCanineName();
            _poids = 10;
            _age = 10;
            _regimeAlimentaire = FoodType.Boeuf | FoodType.Porc | FoodType.Salade | FoodType.Poulet | FoodType.Rongeur;
            _race = AnimalRace.Canin;
            _talk = "Woof";
        }
    }
}

