
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "CobraRoyalData", menuName = "Data/CobraRoyalData")]
    public class CobraRoyalData : VenomousAnimalData
    {
        public CobraRoyalData() : base()
        {
            _name = Names.RandomReptileName();
            _poids = 6;
            _age =6;
            _regimeAlimentaire = FoodType.Criquet | FoodType.Papillon | FoodType.Rongeur;
            _race = AnimalRace.Reptile;
            _talk = "Ksssss";
            _dangerosity = VenomDangerosity.mortelle;
            _effectiveAntiVenom = AntiVenom.Venoxil | AntiVenom.SerpentineX;
            _speciesAggressivity = Aggressivity.TresAgressif;
        }
    }
}

