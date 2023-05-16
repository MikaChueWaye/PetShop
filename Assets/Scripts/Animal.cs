namespace PetShopApp
{
    public abstract class Animal<T> : BaseAnimal where T : AnimalData
    {

        protected T _data;

        public override string Nom => _data.Name;
        public override float Poids => _data.Poids;
        public override AnimalRace Race => _data.Race;
        public override int Age => _data.Age;
        public override float QtteMaxNourriture => _data.QtteMaxNourriture;
        public override FoodType RegimeAlimentaire => _data.RegimeAlimentaire;
        public override string Talk => _data.Talk;
        public override TypeMorsure Mordre => _data.Morsure;

        public Animal(T pData)
        {
            Init(pData);
        }

        public Animal()
        {
            
        }

        public void Init(T pData)
        {
            _data = pData;
            NiveauFaim = _data.NiveauFaimInitial;
        }
    }
}