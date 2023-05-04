using System;
using UnityEngine;

namespace PetShopApp
{
    public class Serpent : Reptile
    {
        public Serpent(string pNom) : base(pNom)
        {
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_inoffensive;

        public override FoodType RegimeAlimentaire => FoodType.Criquet | FoodType.Papillon | FoodType.Rongeur ;

        public override string Talk => "Kssssssss";
    }
}