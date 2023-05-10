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
            Arachne, Canin, Felin, Poisson, Reptile, Insecte
        };

        [Flags]
        public enum FoodType
        {
            Boeuf = 1,
            Porc = 2,
            Larve = 4,
            Criquet = 8,
            Papillon = 16,
            Salade = 32,
            Tomate = 64,
            Oignon = 128,
            Algue = 256,
            Rongeur = 512,
            Poulet = 1024
        };

        public enum TypeMorsure
        {
            Morsure_venimeuse, Morsure_grave, Morsure_Fatale, Morsure_inoffensive
        }

        protected string _nom;
        protected float _poids;
        protected int _age;
        protected float _qtteMaxNourriture;
        protected bool _faim;
        protected float _niveauFaim;

        public string Nom { get => _nom; }
        public float Poids { get => _poids;
            set
            {
                if (value < PoidsMax/10)
                {
                    _poids = PoidsMax / 10;
                }
                else
                {
                    _poids = value;
                }
            }
        }
        public abstract AnimalRace Race { get; }
        public int Age { get => _age; }
        public float QtteMaxNourriture { get => _qtteMaxNourriture; }
        public abstract FoodType RegimeAlimentaire { get; }
        public abstract float QtteMaxNourriturePredefini { get; }
        public abstract float PoidsMax { get; }
        public abstract int AgeMax { get; }
        public abstract string Talk { get; }
        public abstract TypeMorsure Mordre { get; }
        public bool Faim { get=>_faim; }

        public float NiveauFaim { get => _niveauFaim; 
            protected set{
                if (value <= 0.001)
                {
                    _niveauFaim = 0;
                    _faim = false;
                }
                else 
                {
                    _niveauFaim = value;
                    _faim = true;
                }
            }
        }

        public Animal(string pNom)
        {
            _nom = pNom;
            Poids = Mathf.Floor((float)RAND.NextDouble() * PoidsMax * 100) / 100;
            _age = RAND.Next(AgeMax);
            _qtteMaxNourriture = _poids * 0.25f;
            NiveauFaim = _qtteMaxNourriture/2;
        }

        public virtual void Nourrir(FoodType pFoodType, float pQtteNourriture)
        {
            if (_faim)
            {
                if (RegimeAlimentaire.HasFlag(pFoodType))
                {
                    NiveauFaim = _niveauFaim - pQtteNourriture;
                    Debug.Log("NomNomNom");
                    return;
                }
                else
                {
                    throw new NotValidFoodTypeException(_nom, pFoodType);
                }
            }
            throw new NotHungryException(_nom);
        }

        public void Starve()
        {
            NiveauFaim = _niveauFaim + _qtteMaxNourriture/2;
        }

        public override string ToString()
        {
            return $"{GetType().Name.ToUpper()}\n- nom : {_nom}\n- poids : {_poids}\n- race : {Race}\n- age : {_age}\n- qtte nourriture : {_qtteMaxNourriture}\n" +
                $"- regime alimentaire : {RegimeAlimentaire}\n- type de morsure: {Mordre}\n- niveau de faim: {NiveauFaim}\n- Cet annimal{(_faim ? " a " : " n'a pas ")}faim";
        }
    }
}