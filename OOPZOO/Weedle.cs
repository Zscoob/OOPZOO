using Microsoft.Win32;
using System;


namespace OopZoo
{

    public class Weedle

    {
        //properties
        public override string Type => "Type: Bug";

        public override string Evolution => "Evolution: Basic";

        public abstract int LvlEvolve = 7;

        //methods
        //methods
        public abstract string StrongAgainst()
        {
            return "Strong against: Grass, Poison, Ground";
        }

        public abstract string WeakAgainst()
        {
            return "Weak against: Fire, Flying, Psychic.";
        }

        public abstract string Description()
        {
            return "Description: This little bug has a toxic stinger on its head dubbing itself the \"Crawley Unicorn.\"";
        }
    }

}

