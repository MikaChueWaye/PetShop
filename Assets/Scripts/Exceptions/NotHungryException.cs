public class NotHungryException : AnimalException
{
    public NotHungryException(string pAnimalName) : base(pAnimalName, $"{pAnimalName} n'a pas faim")
    {
    }
}