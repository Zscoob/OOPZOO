using Microsoft.Win32;
using System;


namespace OopZoo
{

    public class Beedrill

    {
        //properties
        public override string Type => "Type: Bug/Flying";

        public override string Evolution => "Evolution: Final";


        //methods
        //methods
        public abstract string StrongAgainst()
        {
            return "Strong against: Grass, Poison, Ground, Rock.";
        }

        public abstract string WeakAgainst()
        {
            return "Weak against: Fire, Flying, Psychic, Electric.";
        }

        public abstract string Description()
        {
            return "Description: In 2020 we call this the foreshadowing of the Murder Hornet.";
        }
    }

}

