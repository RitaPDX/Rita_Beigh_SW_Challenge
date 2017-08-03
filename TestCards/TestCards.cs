using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SW_Challenge;

namespace TestCards
	{

	//
	//***********************************************************************
	//
	public partial class frmTestCases : Form
		{
		private List<string> lstRslts = new List<string>();
		private bool blnBuildClicked = false;
		private bool blnShfflClicked = false;
		public Deck myDeckBuilt = new Deck();
		public Deck myShuffledDeck = new Deck();
		public frmHlp myHlp = new frmHlp();

		[STAThread]
		static void Main()
			{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmTestCases());
			}

		public frmTestCases()
			{
			InitializeComponent();
			//myHlp.Show();
			//myHlp.Activate();
			//btnOK.Enabled = false;
			}

		private void btnOK_Click(object sender, EventArgs e)
			{
			bool blnRtn = false;
			if ((blnBuildClicked == true) && (blnShfflClicked == true))
				{
				blnRtn = blnRunTestCases();
				rtbSummary.SelectionAlignment = HorizontalAlignment.Center;
				if (blnRtn == true)
					{
					rtbSummary.BackColor = Color.Green;
					rtbSummary.ForeColor = Color.Yellow;
					rtbSummary.Text = "Test Cases PASS";
					}
				else if (blnRtn == false)
					{
					rtbSummary.BackColor = Color.Red;
					rtbSummary.ForeColor = Color.Yellow;
					rtbSummary.Text = "Test Cases FAIL";
					}

				}
			}
		
		private void btnCanx_Click(object sender, EventArgs e)
			{
			this.Visible = false;
			this.Dispose();
			}

		/*
		 *	Function:				blnRunTestCases
		 *	Author:					Rita Beigh
		 *	Date:						1st August 2017
		 * ------------------------------------------
		 *	Returns a set of boolean values from 
		 *	multiple Test Functions
		 *	Pass or Fail is ascertained
		 *	through  AND'ing all of the 
		 *	returned booleans from the 
		 *	Test Functions
		 *	
		 */
		public bool blnRunTestCases()
			{
			bool blnPF = false;			// true = Test Pass, false = Test Fail

			if ((blnBuildClicked == true) && (blnShfflClicked == true))
				{
				clsCardsTestCases myTC = new clsCardsTestCases();
				Deck myDeckBuilt = new Deck();
				blnPF = false;
				//
				//	
				//
				bool blnRtn00 = myTC.blnDeckCount();
				if (blnRtn00 == true)
					{
					rtbPF00.BackColor = Color.Green;
					rtbPF00.ForeColor = Color.Yellow;
					rtbPF00.Text = "PASS";
					}
				else if (blnRtn00 == false)
					{
					rtbPF00.BackColor = Color.Red;
					rtbPF00.ForeColor = Color.Yellow;
					rtbPF00.Text = "FAIL";
					}

				bool blnRtn01 = myTC.blnDeckNoNULL();
				if (blnRtn01 == true)
					{
					rtbPF01.BackColor = Color.Green;
					rtbPF01.ForeColor = Color.Yellow;
					rtbPF01.Text = "PASS";
					}
				else if (blnRtn00 == false)
					{
					rtbPF01.BackColor = Color.Red;
					rtbPF01.ForeColor = Color.Yellow;
					rtbPF01.Text = "FAIL";
					}

				bool blnRtn02 = myTC.blnDeckNoDupe();
				if (blnRtn01 == true)
					{
					rtbPF02.BackColor = Color.Green;
					rtbPF02.ForeColor = Color.Yellow;
					rtbPF02.Text = "PASS";
					}
				else if (blnRtn02 == false)
					{
					rtbPF02.BackColor = Color.Red;
					rtbPF02.ForeColor = Color.Yellow;
					rtbPF02.Text = "FAIL";
					}

				bool blnRtn03 = myTC.blnDeckOrderSuits();
				if (blnRtn03 == true)
					{
					rtbPF03.BackColor = Color.Green;
					rtbPF03.ForeColor = Color.Yellow;
					rtbPF03.Text = "PASS";
					}
				else if (blnRtn03 == false)
					{
					rtbPF03.BackColor = Color.Red;
					rtbPF03.ForeColor = Color.Yellow;
					rtbPF03.Text = "FAIL";
					}

				bool blnRtn04 = myTC.blnDeckOrderRank();
				if (blnRtn04 == true)
					{
					rtbPF04.BackColor = Color.Green;
					rtbPF04.ForeColor = Color.Yellow;
					rtbPF04.Text = "PASS";
					}
				else if (blnRtn04 == false)
					{
					rtbPF04.BackColor = Color.Red;
					rtbPF04.ForeColor = Color.Yellow;
					rtbPF04.Text = "FAIL";
					}

				bool blnRtn05 = myTC.blnShfflCount();
				if (blnRtn01 == true)
					{
					rtbPF05.BackColor = Color.Green;
					rtbPF05.ForeColor = Color.Yellow;
					rtbPF05.Text = "PASS";
					}
				else if (blnRtn05 == false)
					{
					rtbPF05.BackColor = Color.Red;
					rtbPF05.ForeColor = Color.Yellow;
					rtbPF05.Text = "FAIL";
					}

				bool blnRtn06 = myTC.blnShfflNoNULL();
				if (blnRtn06 == true)
					{
					rtbPF06.BackColor = Color.Green;
					rtbPF06.ForeColor = Color.Yellow;
					rtbPF06.Text = "PASS";
					}
				else if (blnRtn06 == false)
					{
					rtbPF06.BackColor = Color.Red;
					rtbPF06.ForeColor = Color.Yellow;
					rtbPF06.Text = "FAIL";
					}

				bool blnRtn07 = myTC.blnShfflNoDupe();
				if (blnRtn07 == true)
					{
					rtbPF07.BackColor = Color.Green;
					rtbPF07.ForeColor = Color.Yellow;
					rtbPF07.Text = "PASS";
					}
				else if (blnRtn07 == false)
					{
					rtbPF07.BackColor = Color.Red;
					rtbPF07.ForeColor = Color.Yellow;
					rtbPF07.Text = "FAIL";
					}

				bool blnRtn08 = myTC.blnShfflRand();
				if (blnRtn08 == true)
					{
					rtbPF08.BackColor = Color.Green;
					rtbPF08.ForeColor = Color.Yellow;
					rtbPF08.Text = "PASS";
					}
				else if (blnRtn08 == false)
					{
					rtbPF08.BackColor = Color.Red;
					rtbPF08.ForeColor = Color.Yellow;
					rtbPF08.Text = "FAIL";
					}
				blnPF = (blnRtn00 && blnRtn01 && blnRtn02 && blnRtn03 && blnRtn04
								&& blnRtn05 && blnRtn06 && blnRtn07 && blnRtn08);
				}
			return blnPF;
			}

		private void btnBuild_Click(object sender, EventArgs e)
			{
			bool blnWasBuilt = false;
			blnWasBuilt = myDeckBuilt.blnBuildDeck();
			if (blnWasBuilt == true)
				{
				blnBuildClicked = true;
				}
			}

		private void btnShuffle_Click(object sender, EventArgs e)
			{
			myShuffledDeck.blnShuffleTheCards();
			blnShfflClicked = true;
			}

		private void frmHlp(object sender, System.ComponentModel.CancelEventArgs e)
			{
			myHlp.ShowDialog();
			}



		}

	//
	//***********************************************************************
	//

	public class clsCardsTestCases
		{

		frmTestCases frmTC = new frmTestCases();
		Deck cards = new Deck();


		// ADD Test Functions here

		public bool blnDeckCount()
			{
			bool blnRtn = false;

			// Simple test to check that the card count in the deck is 52
			int intCount = frmTC.myDeckBuilt.intBuiltCount;

			if (intCount == Deck.CARD_COUNT)
				{
					blnRtn = true;
				}
			else
				{
				blnRtn = false;
				}
			return blnRtn;
			}

		public bool blnDeckNoNULL()
			{
			bool blnRtn = false;

			// test each element in the deck to test that 
			// there are no NULLs
			// if a NULL Is found the test is over and has failed

			for (int i = 0; i < Deck.CARD_COUNT; i++)
				{
					if (cards.myBuiltCards[i].ToString() != null)
						{
						blnRtn = true;
						}
					else
						{
						blnRtn = false;
						break;
						}
				}
			return blnRtn;
			}


		public bool blnDeckNoDupe()
			{
			bool blnRtn = false;
			
			// Test evaluates that there are no
			// duplicate values in the Deck

			List<string> lstDupes = new List<string>();
			HashSet<string> uniq = new HashSet<string>();
			
			//foreach (string strCard in frmTC.myDeckBuilt)
			foreach (string strCard in frmTC.myDeckBuilt)
				{
					if (uniq.Contains(strCard))
						{
						lstDupes.Add(strCard);
						}
					else
						{
						uniq.Add(strCard);
						}
				}
			
			if (lstDupes.Count == 0)
				{
				blnRtn = true;
				}
			else
				{
				blnRtn = false;
				}
			return blnRtn;
			}

		public bool blnDeckOrderSuits()
			{
			bool blnRtn = false;
			Deck myDeck = new Deck();
			myDeck = frmTC.myDeckBuilt;
			int intPosnSpade = -1;
			int intPosnHeart = -1;
			int intPosnDiamond = -1;
			int intPosnClub = -1;

			intPosnSpade = myDeck.myBuiltCards.IndexOf("Two of Spades");
			intPosnHeart = myDeck.myBuiltCards.IndexOf("Two of Hearts");
			intPosnDiamond = myDeck.myBuiltCards.IndexOf("Two of Diamonds");
			intPosnClub = myDeck.myBuiltCards.IndexOf("Two of Clubs");

			if ((intPosnSpade < intPosnHeart) && (intPosnHeart < intPosnDiamond) 
					&& (intPosnDiamond < intPosnClub))
				{
				blnRtn = true;
				}
			else
				{
				blnRtn = false;
				}
			return blnRtn;
			}

		public bool blnDeckOrderRank()
			{
			bool blnRtn = false;
			Deck myDeck = new Deck();
			myDeck = frmTC.myDeckBuilt;

			int int2, int3, int4, int5, int6, int7, int8, int9,
					int10, intJ, intQ, intK, intA;
			// TODO - Create Arrays for Rank Names and indeces
			//        and use a for loop instead
			int2 = myDeck.myBuiltCards.IndexOf("Two of Spades");
			int3 = myDeck.myBuiltCards.IndexOf("Three of Spades");
			int4 = myDeck.myBuiltCards.IndexOf("Four of Spades");
			int5 = myDeck.myBuiltCards.IndexOf("Five of Spades");
			int6 = myDeck.myBuiltCards.IndexOf("Six of Spades");
			int7 = myDeck.myBuiltCards.IndexOf("Seven of Spades");
			int8 = myDeck.myBuiltCards.IndexOf("Eight of Spades");
			int9 = myDeck.myBuiltCards.IndexOf("Nine of Spades");
			int10 = myDeck.myBuiltCards.IndexOf("Ten of Spades");
			intJ = myDeck.myBuiltCards.IndexOf("Jack of Spades");
			intQ = myDeck.myBuiltCards.IndexOf("Queen of Spades");
			intK = myDeck.myBuiltCards.IndexOf("King of Spades");
			intA = myDeck.myBuiltCards.IndexOf("Ace of Spades");

			if (int2 == 0 && int3 == 1 && int4 == 2 && int5 == 3
					&& int6 == 4 && int7 == 5 && int8 == 6 && int9 == 7 &&
					int10 == 8 && intJ == 9 && intQ == 10 && intK == 11 && intA == 12)
				{
				blnRtn = true;
				}
			else
				{
				blnRtn = false;
				}
			return blnRtn;
			}

		public bool blnShfflCount()
			{
			bool blnRtn = false;

			// TODO Add Test Code here
			blnRtn = true;
			return blnRtn;
			}

		public bool blnShfflNoNULL()
			{
			bool blnRtn = false;

			// TODO Add Test Code here
			blnRtn = true;
			return blnRtn;
			}

		public bool blnShfflNoDupe()
			{
			bool blnRtn = false;

			// TODO Add Test Code here
			blnRtn = true;
			return blnRtn;
			}

		public bool blnShfflRand()
			{
			bool blnRtn = false;

			// TODO Add Test Code here
			blnRtn = true;
			return blnRtn;
			}
		}
	}