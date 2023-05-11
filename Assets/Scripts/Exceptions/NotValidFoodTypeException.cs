using static PetShopApp.BaseAnimal;

public class NotValidFoodTypeException : AnimalException
{
    private FoodType _badFoodType;

    public FoodType BadFoodType => _badFoodType;

    public NotValidFoodTypeException(string pAnimalName, FoodType pBadFoodType) : base(pAnimalName, $"{pAnimalName} ne mange pas de {pBadFoodType}")
    {
        _badFoodType = pBadFoodType;
    }
}