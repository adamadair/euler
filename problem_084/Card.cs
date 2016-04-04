using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public interface ICard
    {
        string Text { get; }
    }

    public class CardDeck
    {
        private static MTRandom rng = new MTRandom();
        Queue<ICard> cards;
        public CardDeck()
        {
            cards = new Queue<ICard>();
        }

        public CardDeck( IEnumerable<ICard> c)
        {
            cards = new Queue<ICard>(c);
        }

        public void Shuffle()
        {
            ICard[] list = cards.ToArray();

            int n = list.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            cards.Clear();
            cards = null;
            cards = new Queue<ICard>(list);
        }

        public ICard Next()
        {
            if (cards.Count == 0) return null;
            var c = cards.Dequeue();
            cards.Enqueue(c);
            return c;
        }
    }

    public enum CommunityChestActions
    {
        Nothing,
        AdvanceToGo,
        GoToJail
    }

    public class CommunityChestCard : ICard
    {
        
        public CommunityChestCard(CommunityChestActions a) { action = a; }
        public string Text
        {
            
            get
            {
                string retVal = "Nothing";
                switch (Action)
                {
                    case CommunityChestActions.AdvanceToGo:
                        retVal = "Advance to GO";
                        break;
                    case CommunityChestActions.GoToJail:
                        retVal = "Go to Jail";
                        break;
                }
                return retVal;
            }
        }

        private CommunityChestActions action;
        public CommunityChestActions Action { get { return action; } }

        public static CardDeck GetCommunityChestDeck()
        {
            List<CommunityChestCard> cards = new List<CommunityChestCard>();
            cards.Add(new CommunityChestCard(CommunityChestActions.AdvanceToGo));
            cards.Add(new CommunityChestCard(CommunityChestActions.GoToJail));
            for(int i = 0; i < 14; ++i)
            {
                cards.Add(new CommunityChestCard(CommunityChestActions.Nothing));
            }
            CardDeck cd = new CardDeck(cards);
            cd.Shuffle();
            return cd;               
        }
    }

    public enum ChanceActions
    {
        Nothing,
        AdvanceToGo,
        GoToJAIL,
        GoToC1,
        GoToE3,
        GoToH2,
        GoToR1,
        GoToNextR,
        GoToNextU,
        GoBack3
    }

    public class ChanceCard : ICard
    {
        private ChanceActions action;
        public ChanceCard(ChanceActions a) { action = a; }
        public ChanceActions Action { get { return action; } }

        public string Text
        {
            get
            {
                string retVal = "Nothing";
                switch (Action)
                {
                    case ChanceActions.AdvanceToGo:
                        retVal = "Advance to GO";
                        break;
                    case ChanceActions.GoToJAIL:
                        retVal = "Go to Jail";
                        break;
                    case ChanceActions.GoToC1:
                        retVal = "Go to C1";
                        break;
                    case ChanceActions.GoToE3:
                        retVal = "Go to E3";
                        break;
                    case ChanceActions.GoToH2:
                        retVal = "Go to H2";
                        break;
                    case ChanceActions.GoToR1:
                        retVal = "Go to R1";
                        break;
                    case ChanceActions.GoToNextR:
                        retVal = "Go to next R";
                        break;
                    case ChanceActions.GoToNextU:
                        retVal = "Go to next U";
                        break;
                    case ChanceActions.GoBack3:
                        retVal = "Go back 3";
                        break;
                }
                return retVal;
            }
        }

        public static CardDeck GetChanceCardDeck()
        {
            List<ChanceCard> list = new List<ChanceCard>();
            list.Add(new ChanceCard(ChanceActions.AdvanceToGo));
            list.Add(new ChanceCard(ChanceActions.GoToJAIL));
            list.Add(new ChanceCard(ChanceActions.GoToC1));
            list.Add(new ChanceCard(ChanceActions.GoToE3));
            list.Add(new ChanceCard(ChanceActions.GoToH2));
            list.Add(new ChanceCard(ChanceActions.GoToR1));
            list.Add(new ChanceCard(ChanceActions.GoToNextR));
            list.Add(new ChanceCard(ChanceActions.GoToNextR));
            list.Add(new ChanceCard(ChanceActions.GoToNextU));
            list.Add(new ChanceCard(ChanceActions.GoBack3));
            list.Add(new ChanceCard(ChanceActions.Nothing));
            list.Add(new ChanceCard(ChanceActions.Nothing));
            list.Add(new ChanceCard(ChanceActions.Nothing));
            list.Add(new ChanceCard(ChanceActions.Nothing));
            list.Add(new ChanceCard(ChanceActions.Nothing));
            list.Add(new ChanceCard(ChanceActions.Nothing));
            CardDeck cd = new CardDeck(list);
            cd.Shuffle();
            return cd;
        }
    }


}
