using UnityEngine;
using static PetShopApp.BaseAnimal;

namespace PetShopApp
{
    public abstract class ArachneData : AnimalData
    {
        [SerializeField] protected bool _tisseToile;

        public bool TisseToile => _tisseToile;

        public ArachneData() : base()
        {
            _name = Names.RandomArachnidName();
            _talk = ". . .";
            _race = AnimalRace.Arachne;
        }
    }

}

