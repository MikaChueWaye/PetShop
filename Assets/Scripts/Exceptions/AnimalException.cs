using System;

public abstract class AnimalException : Exception
{
    private string _animalName;

    public string AnimalName => _animalName;

    public AnimalException(string pAnimalName, string pMessage) : base(pMessage)
    {
        _animalName = pAnimalName;
    }
}