
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "LezardData", menuName = "Data/LezardData")]
    public class LezardData : NonVenomousAnimalData
    {
        public LezardData() : base()
        {
            _name = Names.RandomReptileName();
            _poids = 0.5f;
            _age = 5;
            _regimeAlimentaire = FoodType.Salade | FoodType.Tomate | FoodType.Larve;
            _race = AnimalRace.Reptile;
            _talk = ". . .";
        }
    }
}

