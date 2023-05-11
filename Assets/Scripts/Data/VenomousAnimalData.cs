
using UnityEngine;
using static PetShopApp.BaseAnimal;
using static Venom;
using Random = System.Random;

[CreateAssetMenu(fileName = "VenomousAnimalData", menuName = "Data/VenomousAnimalData")]
public class VenomousAnimalData : AnimalData
{
    [SerializeField] protected VenomDangerosity _dangerosity;
    [SerializeField] protected AntiVenom _effectiveAntiVenom;
    [SerializeField] protected Aggressivity _speciesAggressivity;

    public VenomDangerosity Dangerosity => _dangerosity;
    public AntiVenom EffectiveAntiVenom => _effectiveAntiVenom;
    public Aggressivity SpeciesAggressivity => _speciesAggressivity;


    public VenomousAnimalData()
    {
        _morsure = TypeMorsure.Morsure_venimeuse;
    }

    
}

