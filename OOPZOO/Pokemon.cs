using Microsoft.Win32;
using System;


namespace OopZoo
{ 

	public class Class1
	{
		public abstract class Pokemon
		{
			//properties
			public abstract string Type { get; }
			public abstract string Evolution { get; }
			public abstract int LvlEvolve { get; }

			//methods

			public abstract string StrongAgainst();
			public abstract string WeakAgainst();
			public abstract string Roar();

		}
	}
}