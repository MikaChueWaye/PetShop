﻿using System;
using UnityEngine;
using Random = System.Random;

public static class Venom
{
    public enum VenomDangerosity
    {
        negligeable, faible, moyenne, mortelle
    };

    [Flags] public enum AntiVenom
    {
        Venoxil = 1,
        SerpentineX = 2,
        Vipertox = 4,
        ArachnoShield = 8,
        Coraliase = 16,
        Spidrox = 32,
        CobraShield = 64,
        Addertox = 128,
        Rattlerex = 256,
        Scorpitox = 512
    };

    public enum Aggressivity
    {
        Pacifique = 0,
        Normal = 1,
        Agressif = 5,
        TresAgressif = 10
    };

    public static bool Bite(Random pRandom, Aggressivity pSpeciesAggressivity)
    {
        int lProbability = pRandom.Next(100);
        return lProbability <= (int)pSpeciesAggressivity;
    }

}
