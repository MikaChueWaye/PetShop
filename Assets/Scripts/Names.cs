using System;

namespace PetShopApp
{
    public static class Names
    {
        private static Random RAND = new Random();

        public static string[] RANDOM_NAMES =
        {
            "Simba", "Nemo", "Baloo", "Bambi", "Dumbo", "Félix", "Gaston", "Mickey", "Donald", "Minnie", "Pluto", "Scooby", "Garfield", "Stuart", "Winnie", "Tigrou", "Kaa", "Bagheera", "Shere Khan", "Rafiki", "Zazu", "Pumbaa", "Timon", "Mufasa", "Sebastian", "Flounder", "Ursula", "Ariel", "Belle", "Gaston", "Jasmine", "Aladdin", "Abu", "Iago", "Simba", "Nala", "Kiara", "Kovu", "Zira", "Scar", "Rafiki", "Sarabi", "Sarafina", "Shenzi", "Banzai", "Ed", "Roo", "Tigger", "Eeyore", "Piglet", "Rabbit", "Kanga", "Dusty", "Skipper", "Baloo", "Bagheera", "Louie", "Shere Khan", "Kaa", "King Louie", "Pongo", "Perdita", "Cruella", "Patch", "Lucky", "Rolly", "Thunderbolt", "Penny", "Cody", "Nestor", "Chanticleer", "Rocko", "Heffer", "Filburt", "Spunky", "Leon", "Lola", "Ren", "Stimpy", "Powdered Toast Man", "Mighty Mouse"
        };

        public static string[] CANINE_NAMES =
        {
            "Max", "Buddy", "Charlie", "Jack", "Cooper", "Rocky", "Bear", "Tucker", "Oliver", "Duke", "Teddy", "Bailey", "Zeus", "Louie", "Winston", "Zeke", "Sammy", "Riley", "Oscar", "Harley", "Gus", "Jake", "Milo", "Murphy", "Lucky", "Rufus", "Henry", "Rusty", "Shadow", "Blue", "Ace", "George", "Marley", "Toby", "Simba", "Finn", "Chase", "Koda", "Leo", "Bandit", "Rosie", "Bella", "Lucy", "Luna", "Daisy", "Molly", "Sadie", "Maggie", "Bailey", "Sophie", "Chloe", "Zoe", "Roxy", "Coco", "Stella", "Penny", "Ruby", "Gracie", "Abby", "Mia", "Nala", "Lola", "Annie", "Pepper", "Hazel", "Mabel", "Piper", "Poppy", "Willow", "Daphne", "Ginger", "Sasha", "Scout", "Skye", "Tilly", "Zelda", "Ava", "Belle", "Cali", "Harper", "Jasmine", "Juno", "Layla", "Lexi", "Maya", "Nova", "Remy", "Riley", "Sandy", "Sunny"
        };

        public static string[] FELINE_NAMES =
        {
            "Simba", "Luna", "Smokey", "Tiger", "Oliver", "Salem", "Felix", "Shadow", "Whiskers", "Sooty", "Misty", "Marmalade", "Cleo", "Ginger", "Midnight", "Boots", "Garfield", "Jasper", "Leo", "Cali", "Loki", "Marble", "Milo", "Mittens", "Nala", "Oscar", "Patches", "Pepper", "Pumpkin", "Rascal", "Sabrina", "Sam", "Sasha", "Socks", "Tuxedo", "Willow", "Ziggy", "Zorro", "Chloe", "Kitty", "Buddy", "Muffin", "Angel", "Callie", "Charlie", "Izzy", "Fluffy", "Snickers", "Sunny", "Cinnamon", "Cosmo", "Dusty", "Echo", "Gatsby", "Kiki", "Mango", "Merlin", "Sage", "Suki", "Tigger", "Toulouse", "Truffle", "Violet", "Winnie", "Zelda", "Zoe", "Cupcake", "Peaches", "Roo", "Simone", "Tootsie", "Vixen", "Xena", "Yara", "Zara", "Apollo", "Archie", "Benny", "Binx", "Boo", "Caspian", "Chase", "Cooper", "Dante", "Dexter", "Finn", "Gizmo", "Hank", "Jinx", "Koda", "Lenny", "Loki", "Louie", "Max", "Milo", "Monty", "Nacho", "Odin", "Oreo", "Poe", "Romeo", "Salem", "Scout", "Sebastian", "Stella", "Toby", "Yoda", "Ziggy"
        };

        public static string[] FISH_NAMES =
        {
            "Nemo", "Dory", "Marlin", "Bubbles", "Gill", "Peach", "Jacques", "Flounder", "Sebastian", "Scuttle", "Ursula", "Ariel", "Bloat", "Bubbles", "Chum", "Deb", "Flo", "Gurgle", "Nigel", "Bruce", "Anchor", "Hank", "Bailey", "Destiny", "Charlie", "Jenny", "Becky", "Hank", "Gerald", "Kathy", "Barbara", "Gilly", "Lenny", "Carl", "Frank", "Sheldon", "Pearl", "Tad", "Sheldon Jr.", "Mr. Ray", "Crush", "Squirt", "Pearl", "Finley", "Fishlegs", "Dagur", "Barf", "Belch", "Meatlug", "Stormfly", "Hookfang", "Toothless", "Terrible Terror", "Scauldron", "Seashocker", "Thunderdrum", "Smolder", "Rumblehorn", "Gronckle", "Night Fury", "Light Fury", "Wavewalker", "Piranha", "Barracuda", "Swordfish", "Tuna", "Shark", "Clownfish", "Angelfish", "Goldfish", "Catfish", "Jellyfish", "Octopus", "Squid", "Starfish", "Crab", "Lobster", "Oyster", "Shrimp", "Sea Urchin", "Seahorse", "Whale Shark", "Manta Ray", "Stingray", "Electric Eel", "Lionfish", "Pufferfish", "Clam", "Nautilus", "Anemone", "Coral", "Sponge"
        };

        public static string[] REPTILE_NAMES =
        {
            "Lizzy", "Izzy", "Igor", "Kaa", "Slinky", "Gator", "Reptar", "Rango", "Godzilla", "Komodo", "Draco", "Smaug", "Nagini", "Gila", "Basil", "Lenny", "Spike", "Jabba", "Croc", "Bearded", "Annie", "Morty", "Ziggy", "Sunny", "Spike", "Slytherin", "Scales", "Rex", "Puff", "Leonardo", "Michelangelo", "Raphael", "Donatello", "Bowser", "Koopa", "Charizard", "Squirtle", "Bulbasaur", "Gyarados", "Snorlax", "Pikachu", "Magikarp", "Mewtwo", "Gecko", "Chameleon", "Iguana", "Lizard", "Python", "Cobra", "Rattlesnake", "Turtle", "Tortoise", "Alligator", "Crocodile", "Dragon", "Salamander", "Newt", "Toad"
        };

        public static string[] ARACHNID_NAMES =
        {
            "Arachne", "Anansi", "Ariadne", "Charlotte", "Dolores", "Goliath", "Harry", "Hermione", "Hagrid", "Luna", "Matilda", "Matilde", "Minerva", "Molly", "Neville", "Ron", "Tarantula", "Spinneret", "Venom", "Silk", "Weaver", "Zilla", "Zorro", "Ava", "Bella", "Cora", "Daisy", "Ella", "Flora", "Greta", "Hazel", "Ivy", "Jade", "Kiki", "Lola", "Maggie", "Nina", "Olive", "Poppy", "Quinn", "Rose", "Sally", "Tess", "Uma", "Vera", "Willow", "Xena", "Yara", "Zelda"
        };

        public static string RandomName() => RANDOM_NAMES[RAND.Next(RANDOM_NAMES.Length)];

        public static string RandomArachnidName() => ARACHNID_NAMES[RAND.Next(ARACHNID_NAMES.Length)];

        public static string RandomCanineName() => CANINE_NAMES[RAND.Next(CANINE_NAMES.Length)];

        public static string RandomFelineName() => FELINE_NAMES[RAND.Next(FELINE_NAMES.Length)];

        public static string RandomFishName() => FISH_NAMES[RAND.Next(FISH_NAMES.Length)];

        public static string RandomReptileName() => REPTILE_NAMES[RAND.Next(REPTILE_NAMES.Length)];
    }
}