using System;
using UnityEngine;
using Random = System.Random;

namespace PetShopApp
{
    public abstract class BaseAnimal
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

        protected bool _faim;
        protected float _niveauFaim;

        public abstract string Nom { get; }
        public abstract float Poids { get; }
        public abstract AnimalRace Race { get; }
        public abstract int Age { get; }
        public abstract float QtteMaxNourriture { get; }
        public abstract FoodType RegimeAlimentaire { get; }
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


        public BaseAnimal()
        {

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
                    throw new NotValidFoodTypeException(Nom, pFoodType);
                }
            }
            throw new NotHungryException(Nom);
        }

        public void Starve()
        {
            NiveauFaim = _niveauFaim + QtteMaxNourriture/2;
        }

        public override string ToString()
        {
            return $"{GetType().Name.ToUpper()}\n- nom : {Nom}\n- poids : {Poids}\n- race : {Race}\n- age : {Age}\n- qtte nourriture : {QtteMaxNourriture}\n" +
                $"- regime alimentaire : {RegimeAlimentaire}\n- type de morsure: {Mordre}\n- niveau de faim: {NiveauFaim}\n- Cet annimal{(_faim ? " a " : " n'a pas ")}faim";
        }
    }
}