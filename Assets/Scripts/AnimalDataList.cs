using System;
using System.Collections.Generic;

namespace PetShopApp
{

    [Serializable]
    public class AnimalToInstanciate
    {
        public AnimalData[] List;
        public int NbAnimaux;
    }

    [Serializable]
    public class AnimaleryData
    {
        public AnimalToInstanciate[] List;

    }
}
