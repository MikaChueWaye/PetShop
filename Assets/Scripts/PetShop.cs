using PetShopApp;
using System;
using System.Collections.Generic;
using UnityEngine;
using static PetShopApp.Animal;
using Random = System.Random;

public class PetShop : MonoBehaviour
{
    [SerializeField] private int _nbMygales = 10;
    [SerializeField] private int _nbChiens = 10;
    [SerializeField] private int _nbChats = 10;
    [SerializeField] private int _nbTigres = 10;
    [SerializeField] private int _nbPoissonRouges = 10;
    [SerializeField] private int _nbLezards = 10;
    [SerializeField] private int _nbSerpents = 10;
    [SerializeField] private int _nbTortues = 10;

    private string _nomMagasin;
    private string _adresse;
    private float _longueur;
    private float _largeur;

    private List<Animal> _listeAnimaux = new();

    private Dictionary<FoodType, float> _stockNourriture = new()
    {
        { FoodType.Algue, 0 },
        { FoodType.Boeuf, 0 },
        { FoodType.Criquet, 0 },
        { FoodType.Larve, 0 },
        { FoodType.Oignon, 0 },
        { FoodType.Papillon, 0 },
        { FoodType.Porc, 0 },
        { FoodType.Poulet, 0 },
        { FoodType.Rongeur, 0 },
        { FoodType.Salade, 0 },
        { FoodType.Tomate, 0 }
    };

    private Dictionary<FoodType, float> _listeACommander;

    private Random _rand = new Random();

    public string NomMagasin => _nomMagasin;
    public string Adresse => _adresse;
    public float Longueur => _longueur;
    public float Largeur => _largeur;

    // Start is called before the first frame update
    private void Start()
    {
        //Arachne
        Mygale lMygale;

        //Canin
        Chien lChien;

        //Felin
        Chat lChat;
        Tigre lTigre;

        //Poisson
        PoissonRouge lPoissonRouge;

        //Reptile
        Lezard lLezard;
        Serpent lSerpent;
        Tortue lTortue;

        int lNbMygales = _rand.Next(_nbMygales);
        int lNbChiens = _rand.Next(_nbChiens);
        int lNbChats = _rand.Next(_nbChats);
        int lNbTigres = _rand.Next(_nbTigres);
        int lNbPoissonRouges = _rand.Next(_nbPoissonRouges);
        int lNbLezards = _rand.Next(_nbLezards);
        int lNbSerpents = _rand.Next(_nbSerpents);
        int lNbTortues = _rand.Next(_nbTortues);

        //Création aléatoire de:
        //Arachnes
        for (int i = 0; i < lNbMygales; i++)
        {
            lMygale = new Mygale(Names.RandomArachnidName());
            _listeAnimaux.Add(lMygale);
        }

        //Canins
        for (int i = 0; i < lNbChiens; i++)
        {
            lChien = new Chien(Names.RandomCanineName());
            _listeAnimaux.Add(lChien);
        }

        //Felins
        for (int i = 0; i < lNbChats; i++)
        {
            lChat = new Chat(Names.RandomFelineName());
            _listeAnimaux.Add(lChat);
        }
        for (int i = 0; i < lNbTigres; i++)
        {
            lTigre = new Tigre(Names.RandomFelineName());
            _listeAnimaux.Add(lTigre);
        }

        //Poissons
        for (int i = 0; i < lNbPoissonRouges; i++)
        {
            lPoissonRouge = new PoissonRouge(Names.RandomFishName());
            _listeAnimaux.Add(lPoissonRouge);
        }

        //Reptiles
        for (int i = 0; i < lNbLezards; i++)
        {
            lLezard = new Lezard(Names.RandomReptileName());
            _listeAnimaux.Add(lLezard);
        }
        for (int i = 0; i < lNbSerpents; i++)
        {
            lSerpent = new Serpent(Names.RandomReptileName());
            _listeAnimaux.Add(lSerpent);
        }
        for (int i = 0; i < lNbTortues; i++)
        {
            lTortue = new Tortue(Names.RandomReptileName());
            _listeAnimaux.Add(lTortue);
        }
        //Inventory();

        //Animal[] lAnimal = _listeAnimaux.Where(x => x.Age>5).ToArray();

        Test();
    }

    public void Inventory()
    {
        Debug.Log("-----PET SHOP-----");
        Debug.Log("Liste d'animaux :");
        Debug.Log(_listeAnimaux.Count + " animaux dans l'animalerie :");
        foreach (Animal lAnimal in _listeAnimaux)
        {
            Debug.Log(lAnimal.ToString());
        }
    }

    public void OrderFood()
    {
        foreach (KeyValuePair<FoodType, float> lFood in _listeACommander)
        {
            OrderFood(lFood.Key, lFood.Value);
        }
    }

    public void OrderFood(FoodType pType, float pQtte)
    {
        _stockNourriture[pType] += pQtte;
    }

    public void FeedAll()
    {
        foreach (Animal lAnimal in _listeAnimaux)
        {
            //Feed(lAnimal);
        }
    }

    public void TalkAll()
    {
        foreach (Animal lAnimal in _listeAnimaux)
        {
            Debug.Log(lAnimal.Talk);
        }
    }

    //public void Feed(Animal pAnimal)
    //{
    //    FoodType lNourriture = pAnimal.RegimeAlimentaire;

    //    //Debug.Log(((int)lNourriture).GetSetBitCount());



    //    if (_stockNourriture[lNourriture] - pAnimal.QtteNourriture <= 0)
    //    {
    //        Debug.Log("Il n'y a pas assez de nourriture pour nourrir cet animal, veuillez commander un nouveau stock de nourriture");
    //        float lQtteCommande = NbNourritureACommander(lNourriture);
    //        if (_listeACommander[lNourriture] > lQtteCommande)
    //        {

    //            _listeACommander.Add(lNourriture, lQtteCommande);
    //        }
    //    }

    //    else
    //    {
    //        if (pAnimal.Nourrir(lNourriture))
    //        {
    //            _stockNourriture[lNourriture] -= pAnimal.QtteNourriture;
    //        }
    //        else
    //        {
    //            Debug.Log("Cet animal ne mange pas de " + lNourriture.ToString());
    //        }
    //    }
    //}

    public void Feed(Animal pAnimal)
    {
        int lNbRegimes = ((int)pAnimal.RegimeAlimentaire).GetSetBitCount();
        foreach(FoodType lFoodType in pAnimal.RegimeAlimentaire.GetFlags())
        {
            //divise chaque foodType par le nbRegime et le donne à manger à l'animal
            //aussi vérifier si la qtté de nourriture est suffisante, sinon .... (commander, etc.... cf: code au dessus)
        }
    }

    /// <summary>
    /// Calcule la quantité de nourriture à commander selon le type de nourriture pour 7 jours
    /// </summary>
    /// <param name="pNourriture"></param>
    /// <returns></returns>
    public float NbNourritureACommander(FoodType pNourriture)
    {
        float lQtteACommander = 0;
        foreach (Animal lAnimal in _listeAnimaux)
        {
            if (lAnimal.RegimeAlimentaire == pNourriture)
            {
                lQtteACommander += lAnimal.QtteNourriture;
            }
        }
        return lQtteACommander * 7;
    }

    public void Test()
    {
        Chien lChien = new Chien("toutou");
        Debug.Log($"Régime de toutou : {lChien.RegimeAlimentaire}");
        Debug.Log($"-----Stock avant manger-----\n{StockNourritureToString()}");

        foreach(FoodType enumerable in lChien.RegimeAlimentaire.GetFlags())
        {
            Debug.Log(enumerable);

        }

        //Feed(lChien);
        Debug.Log($"-----Stock après manger-----\n{StockNourritureToString()}");


    }

    public string StockNourritureToString()
    {
        string listeNourriture = $"Stock de nourriture :\n";
        foreach (KeyValuePair<FoodType, float> lNourriture in _stockNourriture)
        {
            listeNourriture += $"- {lNourriture.Key} : {lNourriture.Value}\n";
        }
        return listeNourriture;
    }

    

    // Update is called once per frame
    private void Update()
    {

    }
}