using System;
using System.Collections.Generic;

namespace Monopoly
{
    public class Monopoly
    {
        CardDeck chanceDeck;
        CardDeck communityChestDeck;
        Square[] board;
        Player player;
        int diceSides;

        public Monopoly(int sides)
        {
            InitGame();
            diceSides = sides;
        }

        private void InitGame()
        {
            chanceDeck = ChanceCard.GetChanceCardDeck();
            communityChestDeck = CommunityChestCard.GetCommunityChestDeck();
            setupBoard();
            player = new Player();
        }

        private void setupBoard()
        {
            List<Square> b = new List<Square>();
            b.Add(new Square("GO", SquareType.Normal, "00"));
            b.Add(new Square("A1", SquareType.Normal, "01"));
            b.Add(new Square("CC1", SquareType.CommunityChest, "02"));
            b.Add(new Square("A2", SquareType.Normal, "03"));
            b.Add(new Square("T1", SquareType.Normal, "04"));
            b.Add(new Square("R1", SquareType.Railway, "05"));
            b.Add(new Square("B1", SquareType.Normal, "06"));
            b.Add(new Square("CH1", SquareType.Chance, "07"));
            b.Add(new Square("B2", SquareType.Normal, "08"));
            b.Add(new Square("B3", SquareType.Normal, "09"));
            b.Add(new Square("JAIL", SquareType.Jail, "10"));
            b.Add(new Square("C1", SquareType.Normal, "11"));
            b.Add(new Square("U1", SquareType.Utility, "12"));
            b.Add(new Square("C2", SquareType.Normal, "13"));
            b.Add(new Square("C3", SquareType.Normal, "14"));
            b.Add(new Square("R2", SquareType.Railway, "15"));
            b.Add(new Square("D1", SquareType.Normal, "16"));
            b.Add(new Square("CC2", SquareType.CommunityChest, "17"));
            b.Add(new Square("D2", SquareType.Normal, "18"));
            b.Add(new Square("D3", SquareType.Normal, "19"));
            b.Add(new Square("FP", SquareType.Normal, "20"));
            b.Add(new Square("E1", SquareType.Normal, "21"));
            b.Add(new Square("CH2", SquareType.Chance, "22"));
            b.Add(new Square("E2", SquareType.Normal, "23"));
            b.Add(new Square("E3", SquareType.Normal, "24"));
            b.Add(new Square("R3", SquareType.Railway, "25"));
            b.Add(new Square("F1", SquareType.Normal, "26"));
            b.Add(new Square("F1", SquareType.Normal, "27"));
            b.Add(new Square("U2", SquareType.Utility, "28"));
            b.Add(new Square("E1", SquareType.Normal, "29"));
            b.Add(new Square("G2J", SquareType.GoToJail, "30"));
            b.Add(new Square("G1", SquareType.Normal, "31"));
            b.Add(new Square("G2", SquareType.Normal, "32"));
            b.Add(new Square("CC3", SquareType.CommunityChest, "33"));
            b.Add(new Square("G3", SquareType.Normal, "34"));
            b.Add(new Square("R4", SquareType.Railway, "35"));
            b.Add(new Square("CH3", SquareType.Chance, "36"));
            b.Add(new Square("H1", SquareType.Normal, "37"));
            b.Add(new Square("T2", SquareType.Normal, "38"));
            b.Add(new Square("H2", SquareType.Normal, "39"));
            board = b.ToArray();
        }
        /*
            GO  A1  CC1 A2  T1  R1  B1  CH1 B2  B3 JAIL
            H2                                      C1
            T2                                      U1
            H1                                      C2
            CH3                                     C3
            R4                                      R2
            G3                                      D1
            CC3                                    CC2
            G2                                      D2
            G1                                      D3
            G2J F3  U2  F2  F1  R3  E3  E2  CH2 E1  FP
        */

        public void Simulate(int moves)
        {
            for (int i = 0; i < moves; ++i)
            {
                var roll = player.RollDice(diceSides);
                if (player.DoubleCount == 3)
                {
                    // go to jail
                    MoveToNext(SquareType.Jail);
                    player.DoubleCount = 0;
                }
                else
                {
                    player.Index = (player.Index + roll) % board.Length;
                    switch (board[player.Index].Type)
                    {
                        case SquareType.Chance:
                            HandleChance();
                            break;
                        case SquareType.CommunityChest:
                            HandleCommunityChest();
                            break;
                        case SquareType.GoToJail:
                            MoveToNext(SquareType.Jail);
                            break;
                    }
                }
                board[player.Index].Visits += 1;
            }
        }

        void MoveTo(string name)
        {
            while (board[player.Index].Name != name)
            {
                player.Index = (player.Index + 1) % board.Length;
            }
        }

        void MoveToNext(SquareType type)
        {
            while (board[player.Index].Type != type)
            {
                player.Index = (player.Index + 1) % board.Length;
            }
        }

        void HandleChance()
        {
            switch (((ChanceCard)chanceDeck.Next()).Action)
            {
                case ChanceActions.AdvanceToGo:
                    MoveTo("GO");
                    break;
                case ChanceActions.GoBack3:
                    player.Index -= 3;
                    if (board[player.Index].Type == SquareType.CommunityChest)
                    {
                        HandleCommunityChest();
                    }
                    break;
                case ChanceActions.GoToC1:
                    MoveTo("C1");
                    break;
                case ChanceActions.GoToE3:
                    MoveTo("E3");
                    break;
                case ChanceActions.GoToH2:
                    MoveTo("H2");
                    break;
                case ChanceActions.GoToJAIL:
                    MoveToNext(SquareType.Jail);
                    break;
                case ChanceActions.GoToNextR:
                    MoveToNext(SquareType.Railway);
                    break;
                case ChanceActions.GoToNextU:
                    MoveToNext(SquareType.Utility);
                    break;
                case ChanceActions.GoToR1:
                    MoveTo("R1");
                    break;
            }
        }

        void HandleCommunityChest()
        {
            switch (((CommunityChestCard)communityChestDeck.Next()).Action)
            {
                case CommunityChestActions.AdvanceToGo:
                    MoveTo("GO");
                    break;
                case CommunityChestActions.GoToJail:
                    MoveTo("JAIL");
                    break;
            }
        }

        public Square[] GetBoard()
        {            
            return board;
        }

    }
}

