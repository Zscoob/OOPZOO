using Microsoft.Win32;
using System;


namespace OopZoo
{

    public class Kukuna

    {
        //properties
        public override string Type => "Type: Bug";

        public override string Evolution => "Evolution: Middle";

        public abstract int LvlEvolve = 10;

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
            return "Description: This is the next form of the Crawley Unicorn, \"Angry Shell Homie\"";
        }
    }

}

