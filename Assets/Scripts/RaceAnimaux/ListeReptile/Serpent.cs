using System;
using UnityEngine;

namespace PetShopApp
{
    public class Serpent : Reptile
    {
        public Serpent(string pNom, float pPoids, int pAge, float pQtteNourriture) : base(pNom, pPoids, pAge, pQtteNourriture)
        {
            _regimeAlimentaire = Animal.FoodType.Viande;
        }

        public Serpent(string pNom) : base(pNom)
        {
            _nom = pNom;
        }

        public override TypeMorsure Mordre() => Animal.TypeMorsure.Morsure_venimeuse;

        public override string Talk => "Kssssssssss";
    }
}