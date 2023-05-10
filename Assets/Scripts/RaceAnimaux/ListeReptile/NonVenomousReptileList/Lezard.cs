using UnityEngine;

namespace PetShopApp
{
    public class Lezard : NonVenomousReptile
    {
        public Lezard(string pNom) : base(pNom)
        {
            
        }

        public override TypeMorsure Mordre => TypeMorsure.Morsure_inoffensive;

        public override FoodType RegimeAlimentaire => FoodType.Larve | FoodType.Criquet | FoodType.Papillon;

        public override string Talk => "Psst psst psst";

    }
}