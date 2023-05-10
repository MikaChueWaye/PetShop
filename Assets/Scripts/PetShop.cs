using PetShopApp;
using System;
using System.Collections.Generic;
using UnityEngine;
using static PetShopApp.Animal;
using static Venom;
using Random = System.Random;

public class PetShop : MonoBehaviour
{
    [SerializeField] private int _nbMygales = 10;
    [SerializeField] private int _nbVeuveNoires = 10;
    [SerializeField] private int _nbChiens = 10;
    [SerializeField] private int _nbChats = 10;
    [SerializeField] private int _nbTigres = 10;
    [SerializeField] private int _nbScorpions = 10;
    [SerializeField] private int _nbPoissonRouges = 10;
    [SerializeField] private int _nbPoissonGlobes = 10;
    [SerializeField] private int _nbLezards = 10;
    [SerializeField] private int _nbViperes = 10;
    [SerializeField] private int _nbCobraRoyal = 10;
    [SerializeField] private int _nbTortues = 10;

    private string _nomMagasin;
    private string _adresse;
    private float _longueur;
    private float _largeur;

    private List<Animal> _listeAnimaux = new();

    private List<Animal> _listeAnimauxNonNourris = new();

    private List<FoodType> _foodTypeList = new();

    private Dictionary<FoodType, float> _stockNourriture = new();

    private Dictionary<FoodType, float> _listeNourritureACommander = new();

    private Random _rand = new();

    private Dictionary<AntiVenom, int> _stockAntiVenin = new();

    private Dictionary<AntiVenom, int> _listeAntiVeninACommander = new();

    private int _nbAntiVeninMinimal = 0;

    public string NomMagasin => _nomMagasin;
    public string Adresse => _adresse;
    public float Longueur => _longueur;
    public float Largeur => _largeur;

    

    // Start is called before the first frame update
    private void Start()
    {
        CreateRandomAnimalery();

        InitializeHungryAnimals();

        InitializeAntiVenomStock();

        _foodTypeList = FoodTypeList();

        Debug.Log($"nb antivenin minimal: {_nbAntiVeninMinimal}");

        //FeedAll();

        //OrderFood();

        //Inventory();

        //Debug.Log($"-----Stock avant manger-----\n{StockNourritureToString()}");

        //FeedAll();

        //Debug.Log($"-----Stock après manger-----\n{StockNourritureToString()}");


    }

    public void CreateRandomAnimalery()
    {
        //Arachne
        Mygale lMygale;
        VeuveNoire lVeuveNoire;

        //Canin
        Chien lChien;

        //Felin
        Chat lChat;
        Tigre lTigre;

        //Insecte
        Scorpion lScorpion;

        //Poisson
        PoissonRouge lPoissonRouge;
        PoissonGlobe lPoissonGlobe;

        //Reptile
        Lezard lLezard;
        CobraRoyal lCobraRoyal;
        Vipere lVipere;
        Tortue lTortue;

        int lNbMygales = _rand.Next(_nbMygales);
        int lNbVeuveNoires = _rand.Next(_nbVeuveNoires);
        int lNbChiens = _rand.Next(_nbChiens);
        int lNbChats = _rand.Next(_nbChats);
        int lNbTigres = _rand.Next(_nbTigres);
        int lNbScorpions = _rand.Next(_nbScorpions);
        int lNbPoissonRouges = _rand.Next(_nbPoissonRouges);
        int lNbPoissonGlobes = _rand.Next(_nbPoissonGlobes);
        int lNbLezards = _rand.Next(_nbLezards);
        int lNbViperes = _rand.Next(_nbViperes);
        int lNbCobraRoyals = _rand.Next(_nbCobraRoyal);
        int lNbTortues = _rand.Next(_nbTortues);

        //Création aléatoire de:
        //Arachnes
        for (int i = 0; i < lNbMygales; i++)
        {
            lMygale = new Mygale(Names.RandomArachnidName());
            _listeAnimaux.Add(lMygale);
        }
        for (int i = 0; i < lNbVeuveNoires; i++)
        {
            lVeuveNoire = new VeuveNoire(Names.RandomArachnidName());
            _listeAnimaux.Add(lVeuveNoire);
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

        //Insectes
        for (int i = 0; i < lNbScorpions; i++)
        {
            lScorpion = new Scorpion(Names.RandomInsectName());
            _listeAnimaux.Add(lScorpion);
        }

        //Poissons
        for (int i = 0; i < lNbPoissonRouges; i++)
        {
            lPoissonRouge = new PoissonRouge(Names.RandomFishName());
            _listeAnimaux.Add(lPoissonRouge);
        }
        for (int i = 0; i < lNbPoissonGlobes; i++)
        {
            lPoissonGlobe = new PoissonGlobe(Names.RandomFishName());
            _listeAnimaux.Add(lPoissonGlobe);
        }

        //Reptiles
        for (int i = 0; i < lNbLezards; i++)
        {
            lLezard = new Lezard(Names.RandomReptileName());
            _listeAnimaux.Add(lLezard);
        }
        for (int i = 0; i < lNbViperes; i++)
        {
            lVipere = new Vipere(Names.RandomReptileName());
            _listeAnimaux.Add(lVipere);
        }
        for (int i = 0; i < lNbCobraRoyals; i++)
        {
            lCobraRoyal = new CobraRoyal(Names.RandomReptileName());
            _listeAnimaux.Add(lCobraRoyal);
        }
        for (int i = 0; i < lNbTortues; i++)
        {
            lTortue = new Tortue(Names.RandomReptileName());
            _listeAnimaux.Add(lTortue);
        }
    }

    public void Inventory()
    {
        string lListe = $"-----PET SHOP-----\nListe d'animaux :\n{_listeAnimaux.Count} animaux dans l'animalerie :\n";
        foreach (Animal lAnimal in _listeAnimaux)
        {
            lListe += $"{lAnimal}\n\n";
        }
        Debug.Log(lListe);
    }

    public void OrderFood()
    {
        if (_listeNourritureACommander.Count == 0)
        {
            Debug.Log("La liste a commander est vide");
        }
        else
        {
            foreach (KeyValuePair<FoodType, float> lFood in _listeNourritureACommander)
            {
                OrderFood(lFood.Key, lFood.Value);
            }
            _listeNourritureACommander = new();
            Debug.Log("La commande est passée");
        }
        
    }

    public void OrderFood(FoodType pType, float pQtte)
    {
        if (!_stockNourriture.ContainsKey(pType))
        {
            _stockNourriture.Add(pType, pQtte);
        }
        else
        {
            _stockNourriture[pType] += pQtte;
        }
    }

    public List<FoodType> FoodTypeList()
    {
        List<FoodType> lFoodTypeList = new();
        foreach (Animal lAnimal in _listeAnimaux)
        {
            foreach (FoodType lFoodType in lAnimal.RegimeAlimentaire.GetFlags())
            {
                if (!lFoodTypeList.Contains(lFoodType))
                {
                    lFoodTypeList.Add(lFoodType);
                }
            }
        }
        return lFoodTypeList;
    }

    public void RefillStock()
    {
        foreach (FoodType lFoodType in _foodTypeList)
        {
            RefillFoodType(lFoodType);
        }
        Debug.Log(ListeCommandeToString());
    }

    public void RefillFoodType(FoodType pFoodType)
    {
        float lQtteCommande = NbNourritureACommander(pFoodType);
        if (_listeNourritureACommander.ContainsKey(pFoodType))
        {
            if (_listeNourritureACommander[pFoodType] < lQtteCommande)
            {
                _listeNourritureACommander[pFoodType] += lQtteCommande;
            }
            //else
            //{
            //    Debug.Log($"la nourriture {lFoodType} figure déjà sur la liste de commande");
            //}
        }
        else
        {
            _listeNourritureACommander.Add(pFoodType, lQtteCommande);
        }
        
    }

    public void FeedAll()
    {
        int lNbRegimes = 0;
        float lQtteNourritureRegime = 0;
        foreach (Animal lAnimal in _listeAnimauxNonNourris)
        {
            lNbRegimes = lAnimal.RegimeAlimentaire.GetSetBitCount();
            lQtteNourritureRegime = lAnimal.QtteMaxNourriture / lNbRegimes;
            Feed(lAnimal, lAnimal.QtteMaxNourriture);
        }
        InitializeHungryAnimals();
    }

    public void TalkAll()
    {
        foreach (Animal lAnimal in _listeAnimaux)
        {
            Debug.Log(lAnimal.Talk);
        }
    }

    public void Feed(Animal pAnimal, float pQtteNourriture)
    {
        foreach(FoodType lFoodType in pAnimal.RegimeAlimentaire.GetFlags())
        {
            if (!_stockNourriture.ContainsKey(lFoodType))
            {
                _stockNourriture.Add(lFoodType, 0);
            }
            if (_stockNourriture[lFoodType] >= pQtteNourriture)
            {
                try
                {
                    pAnimal.Nourrir(lFoodType, pQtteNourriture);
                    _stockNourriture[lFoodType] -= pQtteNourriture;
                    if (!pAnimal.Faim) break;
                }
                catch (Exception lException)
                {
                    switch (lException)
                    {
                        case NotHungryException lHungryEx:
                            Debug.Log(lHungryEx.Message);
                            break;
                        case NotValidFoodTypeException lValidFoodEx:
                            Debug.LogError(lValidFoodEx.Message);
                            break;
                        case PoisonedException lPoisonedException:
                            Debug.LogError(lPoisonedException);
                            VenomDangerosity lDangerosity = lPoisonedException.SpecieVenomDangerosity;
                            if (!lDangerosity.Equals(VenomDangerosity.faible)||!lDangerosity.Equals(VenomDangerosity.negligeable))
                            {
                                Debug.Log("Le poison est dangeureux, administration de l'anti venin correspondant:");
                                UseAntiVenom(lPoisonedException.AntiVenom, 1);
                            }
                            break;
                        default:
                            Debug.LogError(lException);
                            break;
                    }

                }
            }
            else
            {
                RefillFoodType(lFoodType);
                //_listeAnimauxNonNourris.Add(pAnimal);
                //Debug.LogError($"attention l'animal {pAnimal.Nom} n'a pas été nourri");
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
            if ((lAnimal.RegimeAlimentaire & pNourriture) > 0)
            {
                lQtteACommander += lAnimal.QtteMaxNourriture;
            }
        }
        return lQtteACommander * 7;
    }

    public void Test()
    {
        Chien lChien = new Chien("toutou");
        _listeAnimaux.Add(lChien);
        //Debug.Log($"Régime de toutou : {lChien.RegimeAlimentaire}");
        Debug.Log($"-----Stock avant manger-----\n{StockNourritureToString()}");

        int lNbRegimes = lChien.RegimeAlimentaire.GetSetBitCount();
        float lQtteNourritureRegime = lChien.QtteMaxNourriture / lNbRegimes;

        Feed(lChien, lQtteNourritureRegime);

        OrderFood();

        Feed(lChien, lQtteNourritureRegime);

        Debug.Log($"-----Stock après manger-----\n{StockNourritureToString()}");
    }

    public string StockNourritureToString()
    {
        string lListeNourriture = $"Stock de nourriture :\n";
        foreach (KeyValuePair<FoodType, float> lNourriture in _stockNourriture)
        {
            lListeNourriture += $"- {lNourriture.Key} : {lNourriture.Value}\n";
        }
        return lListeNourriture;
    }

    public string ListeCommandeToString()
    {
        string lListeCommande = $"Liste de commande :\n";
        foreach (KeyValuePair<FoodType, float> lCommande in _listeNourritureACommander)
        {
            lListeCommande += $"- {lCommande.Key} : {lCommande.Value}\n";
        }
        return lListeCommande;
    }

    public string ListeAntiVeninToString()
    {
        string lListeAntivenin = $"Stock d'anti venin :\n";
        foreach (KeyValuePair<AntiVenom, int> lListe in _stockAntiVenin)
        {
            lListeAntivenin += $"- {lListe.Key} : {lListe.Value}\n";
        }
        return lListeAntivenin;
    }

    public string ListeCommandeAntiVeninToString()
    {
        string lListeCommandeAntivenin = $"Liste de commande d'anti venin :\n";
        foreach (KeyValuePair<AntiVenom, int> lListe in _listeAntiVeninACommander)
        {
            lListeCommandeAntivenin += $"- {lListe.Key} : {lListe.Value}\n";
        }
        return lListeCommandeAntivenin;
    }

    public void ConsulterStock()
    {
        Debug.Log(StockNourritureToString());
    }

    public void PassDay()
    {
        _listeAnimauxNonNourris.Clear();
        foreach (Animal lAnimal in _listeAnimaux)
        {
            lAnimal.Starve();
            if (lAnimal.Faim)
            {
                _listeAnimauxNonNourris.Add(lAnimal);
            }
        }
        Debug.Log("une journée passe");
    }

    public void InitializeHungryAnimals()
    {
        _listeAnimauxNonNourris.Clear();
        foreach (Animal lAnimal in _listeAnimaux)
        {
            if (lAnimal.Faim)
            {
                _listeAnimauxNonNourris.Add(lAnimal); 
            }
        }
    }

    private void UseAntiVenom(AntiVenom pType, int pQtty)
    {
        foreach (AntiVenom lAntiVenom in pType.GetFlags())
        {
            if (!_stockAntiVenin.ContainsKey(lAntiVenom))
            {
                _stockAntiVenin.Add(lAntiVenom, 0);
            }
            if (_stockAntiVenin[lAntiVenom] >= pQtty)
            {
                _stockAntiVenin[lAntiVenom] = _stockAntiVenin[lAntiVenom] - 1;
                Debug.Log($"L'anti venin {lAntiVenom} a bien été administré");
                OrderAntiVenom(lAntiVenom, 1);
                if (_nbAntiVeninMinimal < _stockAntiVenin[lAntiVenom])
                {
                    BuyAntiVenom(lAntiVenom, _nbAntiVeninMinimal - _stockAntiVenin[lAntiVenom]);
                }
                break;
            }
            else
            {
                Debug.Log($"Vous ne possédez pas assez d'anti venin {lAntiVenom} !\n Achat urgent de l'anti-venin correspondant (vous êtes taxé le double du prix initial pour la livraison express)");
                BuyAntiVenom(lAntiVenom, _nbAntiVeninMinimal + pQtty - _stockAntiVenin[lAntiVenom]);
                _stockAntiVenin[lAntiVenom] = _stockAntiVenin[lAntiVenom] - 1;
                Debug.Log($"L'anti venin {lAntiVenom} a bien été administré");
                OrderAntiVenom(lAntiVenom, 1);
                break;
            }
        }
    }

    public void OrderAntiVenom(AntiVenom pAntiVenom, int pQtty)
    {

        if (_listeAntiVeninACommander.ContainsKey(pAntiVenom))
        {
            _listeAntiVeninACommander[pAntiVenom] +=pQtty;
        }
        else
        {
            _listeAntiVeninACommander.Add(pAntiVenom, pQtty);
        }
    }

    public void OrderAntiVenom()
    {
        if (_listeAntiVeninACommander.Count!=0)
        {
            foreach (AntiVenom lAntiVenin in _listeAntiVeninACommander.Keys)
            {
                BuyAntiVenom(lAntiVenin, _listeAntiVeninACommander[lAntiVenin]);
            }
            _listeAntiVeninACommander.Clear();
        }
        else
        {
            Debug.LogError("La liste d'anti venin à commander est vide!");
        }
    }

    public void BuyAntiVenom(AntiVenom pAntiVenom, int pQtty)
    {
        if (_stockAntiVenin.ContainsKey(pAntiVenom))
        {
            _stockAntiVenin[pAntiVenom] = _stockAntiVenin[pAntiVenom] + pQtty;
        }
        else
        {
            _stockAntiVenin.Add(pAntiVenom, pQtty);
        }
    }

    public void InitializeAntiVenomStock()
    {
        foreach(Animal lAnimal in _listeAnimaux)
        {
            if (lAnimal is IVenomous)
            {
                _nbAntiVeninMinimal += 1;
                IVenomous lVenomous = lAnimal as IVenomous;
                foreach (AntiVenom lAntiVenom in lVenomous.EffectiveAntiVenom.GetFlags())
                {
                    OrderAntiVenom(lAntiVenom, 1);
                }
            }
        }
        if (_listeAntiVeninACommander.Count != 0)
        {
            OrderAntiVenom();
        }
        else
        {
            Debug.Log("Vous n'avez pas d'animaux venimeux dans votre animalerie");
        }
    }


    //TODO
    /*
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */

    //DONE
    /*
     * consulter les animaux (nom, poids, age, type animal et s'il a faim)
     * Initialisation dans le start (generation aleatoire)
     * consulter le stock
     * nourrir tous le monde à l'appui d'un boutton
     * faire parler tous le monde à l'appui d'un boutton
     * commander toutes les nourritures
     * fonction pour augmenter leurs niveau de faim (faire passer un jour)
     * fonction qui nourrit tous les animaux qui n'ont pas mangé (qui ont faim)
     */



    // Update is called once per frame
    private void Update()
    {
        var input = Input.inputString;

        if (!string.IsNullOrEmpty(input))
        {
            switch(input)
            {
                //case "a":
                //    CreateRandomAnimalery();
                //    break;
                case "z":
                    Inventory();
                    break;
                case "e":
                    ConsulterStock();
                    break;
                case "r":
                    Debug.Log(ListeCommandeToString());
                    break;
                case "t":
                    RefillStock();
                    break;
                case "y":
                    OrderFood();
                    break;
                case "u":
                    PassDay();
                    break;

                case "q":
                    TalkAll();
                    break;
                case "s":
                    FeedAll();
                    break;

                case "w":
                    string lListeAnimauxNonNourris = $"Liste des animaux non nourris:\n\n";
                    foreach (Animal lAnimal in _listeAnimauxNonNourris)
                    {
                        lListeAnimauxNonNourris += $"{lAnimal}\n";
                    }
                    Debug.Log(lListeAnimauxNonNourris);
                    break;

                case "o":
                    Debug.Log(ListeAntiVeninToString());
                    break;
                case "p":
                    Debug.Log(ListeCommandeAntiVeninToString());
                    break;
                case "m":
                    OrderAntiVenom();
                    break;
            }
        }
    }
}