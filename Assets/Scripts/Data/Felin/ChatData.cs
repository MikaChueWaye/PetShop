
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "ChatData", menuName = "Data/ChatData")]
    public class ChatData : NonVenomousAnimalData
    {
        public ChatData() : base()
        {
            _name = Names.RandomFelineName();
            _poids = 10;
            _age = 10;
            _regimeAlimentaire = FoodType.Boeuf | FoodType.Porc | FoodType.Salade | FoodType.Poulet | FoodType.Rongeur;
            _race = AnimalRace.Felin;
            _talk = "Meow";
        }
    }
}

