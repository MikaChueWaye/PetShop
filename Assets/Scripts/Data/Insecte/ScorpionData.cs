
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;

namespace PetShopApp
{
    [CreateAssetMenu(fileName = "ScorpionData", menuName = "Data/ScorpionData")]
    public class ScorpionData : VenomousAnimalData
    {
        public ScorpionData() : base()
        {
            _name = Names.RandomInsectName();
            _poids = 0.5f;
            _age = 2;
            _regimeAlimentaire = FoodType.Criquet | FoodType.Papillon | FoodType.Rongeur;
            _race = AnimalRace.Insecte;
            _talk = ". . .";
            _dangerosity = VenomDangerosity.mortelle;
            _effectiveAntiVenom = AntiVenom.Scorpitox;
            _speciesAggressivity = Aggressivity.Agressif;
        }
    }
}

