using System;
using UnityEngine;
using Random = System.Random;

namespace PetShopApp
{
    public abstract class Animal
    {
        public static Random RAND = new Random();

        public enum AnimalRace
        {
            Arachne, Canin, Felin, Poisson, Reptile
        };

        [Flags]
        public enum FoodType
        {
            Poulet = 0,
            Boeuf = 1,
            Porc = 2,
            Larve = 4,
            Criquet = 8,
            Papillon = 16,
            Salade = 32,
            Tomate = 64,
            Oignon = 128,
            Algue = 256,
            Rongeur = 512
        };

        public enum TypeMorsure
        {
            Morsure_venimeuse, Morsure_grave, Morsure_Fatale, Morsure_inoffensive
        }

        protected string _nom;
        protected float _poids;
        protected int _age;
        protected float _qtteNourriture;

        public string Nom { get => _nom; }
        public float Poids { get => _poids; }
        public abstract AnimalRace Race { get; }
        public int Age { get => _age; }
        public float QtteNourriture { get => _qtteNourriture; }
        public abstract FoodType RegimeAlimentaire { get; }
        public abstract float QtteMaxNourriture { get; }
        public abstract float PoidsMax { get; }
        public abstract int AgeMax { get; }
        public abstract string Talk { get; }
        public abstract TypeMorsure Mordre { get; }

        public Animal(string pNom)
        {
            _nom = pNom;
            _poids = Mathf.Floor((float)RAND.NextDouble() * PoidsMax * 100) / 100;
            _age = RAND.Next(AgeMax);
            _qtteNourriture = Mathf.Floor((float)RAND.NextDouble() * QtteMaxNourriture * 10) / 10;

        }

        public bool Nourrir(FoodType pFoodType)
        {
            if (pFoodType == RegimeAlimentaire)
            {
                Debug.Log("NomNomNom");
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return $"{GetType().Name}\n- nom : {_nom}\n- poids : {_poids}\n- race : {Race}\n- age : {_age}\n- qtte nourriture : {_qtteNourriture}\n- regime alimentaire : {RegimeAlimentaire}\n- type de morsure: {Mordre}";
        }
    }
}