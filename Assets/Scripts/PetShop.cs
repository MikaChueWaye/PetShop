using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PetShopApp;
using Random = System.Random;

using static PetShopApp.Animal;

public class PetShop : MonoBehaviour
{
    [SerializeField] private int _nbMygales = 5;
    [SerializeField] private int _nbChiens = 5;
    [SerializeField] private int _nbChats = 5;
    [SerializeField] private int _nbTigres = 5;
    [SerializeField] private int _nbPoissonRouges = 5;
    [SerializeField] private int _nbLezards = 5;
    [SerializeField] private int _nbSerpents = 5;
    [SerializeField] private int _nbTortue = 5;

    private string _nomMagasin;
    private string _adresse;
    private float _longueur;
    private float _largeur;

    private List<Animal> _listeAnimaux;

    private Dictionary<FoodType, float> _stockNourriture = new()
    {
        { FoodType.Insectes, 0 },
        { FoodType.Larves, 0 },
        { FoodType.Salade, 0 },
        { FoodType.Viande, 0 }
    };

    private Dictionary<FoodType, float> _listeACommander;

    private Random _rand = new Random();

    public string NomMagasin => _nomMagasin;
    public string Adresse => _adresse;
    public float Longueur => _longueur;
    public float Largeur => _largeur;

    // Start is called before the first frame update
    void Start()
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

        //Création aléatoire de:
        //Arachnes
        for (int i = 0; i < _rand.Next(_nbMygales); i++)
        {
            lMygale = new Mygale(Names.RandomArachnidName());
            _listeAnimaux.Add(lMygale);
        }

        //Canins
        for (int i = 0; i < _rand.Next(_nbChiens); i++)
        {
            lChien = new Chien(Names.RandomCanineName());
            _listeAnimaux.Add(lChien);
        }

        //Felins
        for (int i = 0; i < _rand.Next(_nbChats); i++)
        {
            lChat = new Chat(Names.RandomFelineName());
            _listeAnimaux.Add(lChat);
        }
        for (int i = 0; i < _rand.Next(_nbTigres); i++)
        {
            lTigre = new Tigre(Names.RandomFelineName());
            _listeAnimaux.Add(lTigre);
        }

        //Poissons
        for (int i = 0; i < _rand.Next(_nbPoissonRouges); i++)
        {
            lPoissonRouge = new PoissonRouge(Names.RandomFishName());
            _listeAnimaux.Add(lPoissonRouge);
        }

        //Reptiles
        for (int i = 0; i < _rand.Next(_nbLezards); i++)
        {
            lLezard = new Lezard(Names.RandomReptileName());
            _listeAnimaux.Add(lLezard);
        }
        for (int i = 0; i < _rand.Next(_nbSerpents); i++)
        {
            lSerpent = new Serpent(Names.RandomReptileName());
            _listeAnimaux.Add(lSerpent);
        }
        for (int i = 0; i < _rand.Next(_nbTortue); i++)
        {
            lTortue = new Tortue(Names.RandomReptileName());
            _listeAnimaux.Add(lTortue);
        }


    }

    public void Inventory()
    {
        foreach(Animal lAnimal in _listeAnimaux)
        {
            
        }
    }

    public void OrderFood(Dictionary<Animal.FoodType, float> pListe)
    {

    }

    public void OrderFood(FoodType pType, float pQtte)
    {

    }

    public void FeedAll()
    {

    }

    public void TalkAll()
    {

    }

    public void NourrirAnimal(Animal pAnimal, FoodType pNourriture)
    {
        if (_stockNourriture[pNourriture] - pAnimal.QtteNourriture <= 0)
        {
            float lQtteCommande = NbNourritureACommander(pNourriture);
            if (_listeACommander[pNourriture] > lQtteCommande)
            {
                _listeACommander.Add(pNourriture, lQtteCommande);
            }
        }
        else
        {
            if (pAnimal.Nourrir(pNourriture))
            {
                _stockNourriture[pNourriture] -= pAnimal.QtteNourriture;
            }
            else
            {
                Debug.Log("Cet animal ne mange pas de " + pNourriture.ToString());
            }
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
