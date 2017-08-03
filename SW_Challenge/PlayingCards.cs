using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.String;


//
//  -----------------------------------------------------------------------------------------------------
//

namespace SW_Challenge
	{

	/*
*  
*  Class : PlayingCard
*  Author: Rita Beigh
*  Date:   30 July 2017
*  
*  Declaration of class PlayingCard and will be used within 
*  the class Deck
*  
*/

	public class PlayingCard
		{
		private string suit;
		private string rank;

		//  Constructor uses two parameters
		//  to initialize both suit and rank

		public PlayingCard(string strRank, string strSuit)
			{
			suit = strSuit;
			rank = strRank;
			}

		// ToString() returns the card's identity
		public override string ToString()
			{
			return rank + " of " + suit;
			}
		}

	//------------------------------------------------------------------------------

	/*
	 *  
	 *  Class : Deck
	 *  Author: Rita Beigh
	 *  Date:   30 July 2017
	 *  
	 *  Declaration of class Deck 
	 *  
	*/

	public class Deck
		{
		public const int CARD_COUNT = 52;					// constant - number of cards in the myDeck
		private PlayingCard[] myDeck;             // myDeck = array of playing cards
		private Random numRandom;									// generated random number
		public int intBuiltCount;
		public List<string> myBuiltCards = new List<string>(CARD_COUNT);
		public List<string> myShffldCards = new List<string>(CARD_COUNT);

		public IEnumerator<string> GetEnumerator()
			{
			return myBuiltCards.GetEnumerator();
			}

		//System.Collections.IEnumerator<string>
		//	{
		//	return myBuiltCards.GetEnumerator();
		//	}


		//  declare and define the function creating a myDeck of PlayingCard
		static void Main(string[] args)
			{
#if DEBUG
			Deck deck = new Deck();
			deck.blnShuffleTheCards();
#endif			
			Console.WriteLine("\nPress 'Return' to Exit");
			System.Console.ReadLine();
			}

		public bool blnShuffleTheCards()
			{
			numRandom = new Random((int)(DateTime.Now.Ticks % System.Int32.MaxValue));
			int intA = 0;
			int intB = 0;
			bool blnRtn = false;
#if DEBUG
			Console.WriteLine("Shuffle the Deck\n");
#endif

			for (intA = 0; intA < CARD_COUNT; intA++)
				{
				intB = numRandom.Next(CARD_COUNT);

				PlayingCard TempCard = myDeck[intA];
				myDeck[intA] = myDeck[intB];
				myDeck[intB] = TempCard;

				myShffldCards.Add(myDeck[intA].ToString());
#if DEBUG
				Console.WriteLine(myDeck[intA].ToString() + "\t\t" + " Count: " + intA);
#endif
				}
			blnRtn = true;
			return true;
			}


		//  declare 2 arrays of type string and initialize them  
		//  The array strRanks represents the ranking of the 
		//  cards 2 thru ace NOTE: Assumes Ace is highest rules
		//  The array strSuits represents the card suits and are declared 
		//  in order of seniority: Spades, Hearts, Diamonds, and Clubs

		public bool blnBuildDeck()
			{
			bool blnRetVal = false;	
			string[] strRanks = {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                           "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
			string[] strSuits = {"Spades", "Hearts", "Diamonds", "Clubs"};			// Dscending Order
													//{ "Clubs", "Diamonds", "Hearts", "Spades" };			// Descending Order
			myDeck = new PlayingCard[CARD_COUNT];
#if DEBUG
			Console.WriteLine("Build the Deck\n");
#endif
			int x = 0;
			for (int i = 0; i < strSuits.Count(); i++)
				{
				for (int j = 0; j < strRanks.Count(); j++)
					{
					myDeck[x] = new PlayingCard(strRanks[j], strSuits[i]);
#if DEBUG
					Console.WriteLine(myDeck[x].ToString());
#endif

					myBuiltCards.Add(myDeck[x].ToString());
					x++;
					}
				blnRetVal = true;
				}
			intBuiltCount = myDeck.GetLength(0);
			return blnRetVal;
			}


		public Deck()
			{

			bool blnRtn = blnBuildDeck();

			Console.WriteLine("\n");
			}
		}
	}
