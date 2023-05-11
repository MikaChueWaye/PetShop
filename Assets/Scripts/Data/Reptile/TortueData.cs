
using UnityEngine;
using static PetShopApp.BaseAnimal;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "TortueData", menuName = "Data/TortueData")]
    public class TortueData : NonVenomousAnimalData
    {
        public TortueData() : base()
        {
            _name = Names.RandomReptileName();
            _poids = 10;
            _age = 30;
            _regimeAlimentaire = FoodType.Salade | FoodType.Tomate | FoodType.Oignon;
            _race = AnimalRace.Reptile;
            _talk = ". . .";
        }
    }
}

