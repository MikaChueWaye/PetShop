using System.Collections.Generic;
using static Venom;

public class PoisonedException : AnimalException
{
    private AntiVenom _antiVenom;

    private VenomDangerosity _specieVenomDangerosity;

    public AntiVenom AntiVenom { get=>_antiVenom; }

    public VenomDangerosity SpecieVenomDangerosity { get => _specieVenomDangerosity; }

    public PoisonedException(string pAnimalName, AntiVenom pAntiVenom, VenomDangerosity pVenomDangerosity) : base(pAnimalName, $"{pAnimalName} a mordu")
    {
        _antiVenom = pAntiVenom;
        _specieVenomDangerosity = pVenomDangerosity;
    }

    


}