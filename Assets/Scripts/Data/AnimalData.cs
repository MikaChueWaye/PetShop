using UnityEngine;
using static PetShopApp.BaseAnimal;

public abstract class AnimalData : ScriptableObject
{
    [SerializeField] protected string _name;
    [SerializeField] [Range(0, 5000)] protected float _poids;
    [SerializeField] [Range(0, 200)] protected int _age;
    [SerializeField] protected FoodType _regimeAlimentaire;
    [SerializeField] protected AnimalRace _race;
    [SerializeField] protected string _talk;
    [SerializeField] protected TypeMorsure _morsure;


    public string Name => _name;
    public float Poids => _poids;
    public int Age => _age;
    public float QtteMaxNourriture => 0.25f*_poids;
    /// <summary>
    /// Retourne le niveau de faim qui est égal à la moitié de la quantité maximum de nourriture
    /// </summary>
    public float NiveauFaimInitial => 0.125f * _poids;
    public FoodType RegimeAlimentaire => _regimeAlimentaire;
    public AnimalRace Race => _race;
    public string Talk => _talk;
    public TypeMorsure Morsure => _morsure;



}

