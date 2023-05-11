
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "VipereData", menuName = "Data/VipereData")]
    public class VipereData : VenomousAnimalData
    {
        public VipereData() : base()
        {
            _name = Names.RandomReptileName();
            _poids = 5;
            _age = 5;
            _regimeAlimentaire = FoodType.Criquet | FoodType.Papillon | FoodType.Rongeur;
            _race = AnimalRace.Reptile;
            _talk = "Ksssss";
            _dangerosity = VenomDangerosity.mortelle;
            _effectiveAntiVenom = AntiVenom.Venoxil | AntiVenom.SerpentineX | AntiVenom.Vipertox;
            _speciesAggressivity = Aggressivity.Agressif;
        }
    }
}

