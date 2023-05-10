using static Venom;
public interface IVenomous
{
    public VenomDangerosity Dangerosity { get; }
    public bool Bite();
    public AntiVenom EffectiveAntiVenom { get; } 
    public Aggressivity SpeciesAggressivity { get; }

    
}
