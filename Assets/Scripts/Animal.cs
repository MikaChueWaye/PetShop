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

        [Flags] public enum FoodType
        {
            Viande, Insectes, Salade, Larves
        };

        public enum TypeMorsure
        {
            Morsure_venimeuse, Morsure_grave, Morsure_Fatale, Morsure_inoffensive 
        }

        protected string _nom;
        protected float _poids;
        protected AnimalRace _race;
        protected int _age;
        protected float _qtteNourriture;
        protected FoodType _regimeAlimentaire;

        protected string Nom { get=>_nom; }
        protected float Poids { get=>_poids; }
        protected AnimalRace Race { get =>_race; }
        protected int Age { get=>_age; }
        public float QtteNourriture { get=>_qtteNourriture; }
        public FoodType RegimeAlimentaire { get=>_regimeAlimentaire; }

        public Animal(string pNom, float pPoids, int pAge, float pQtteNourriture )
        {
            _nom = pNom;
            _poids = pPoids;
            _age = pAge;
            _qtteNourriture = pQtteNourriture;
        }
        
        public Animal(string pNom)
        {
            _nom = pNom;
        }

        public abstract string Talk { get; }
        public abstract TypeMorsure Mordre();
        public bool Nourrir(FoodType pFoodType)
        {
            if (pFoodType == _regimeAlimentaire)
            {
                Debug.Log("NomNomNom");
                return true;
            }
            else return false;
        }
    }
}