using System;
using System.Collections.Generic;

namespace Chess.Casting
{
    /// <summary>
    /// A PieceCreator creates the pieces and sets their locations at the 
    /// beginning of the game.
    /// </summary>
    public class PieceCreator
    {
        Piece blackRookA = new Piece();
        Piece blackKnightB = new Piece();
        Piece blackBishopC = new Piece();
        Piece blackQueen = new Piece();
        Piece blackKing = new Piece();
        Piece blackBishopF = new Piece();
        Piece blackKnightG = new Piece();
        Piece blackRookH = new Piece();
        Piece blackPawnA = new Piece();
        Piece blackPawnB = new Piece();
        Piece blackPawnC = new Piece();
        Piece blackPawnD = new Piece();
        Piece blackPawnE = new Piece();
        Piece blackPawnF = new Piece();
        Piece blackPawnG = new Piece();
        Piece blackPawnH = new Piece();

        
        Piece whiteRookA = new Piece();
        Piece whiteKnightB = new Piece();
        Piece whiteBishopC = new Piece();
        Piece whiteQueen = new Piece();
        Piece whiteKing = new Piece();
        Piece whiteBishopF = new Piece();
        Piece whiteKnightG = new Piece();
        Piece whiteRookH = new Piece();
        Piece whitePawnA = new Piece();
        Piece whitePawnB = new Piece();
        Piece whitePawnC = new Piece();
        Piece whitePawnD = new Piece();
        Piece whitePawnE = new Piece();
        Piece whitePawnF = new Piece();
        Piece whitePawnG = new Piece();
        Piece whitePawnH = new Piece();
        
        public PieceCreator() { }

        public List<Piece> GetPieces()
        {
            List<Piece> pieces = new List<Piece>();

            blackRookA.SizeTo(100, 100);
            blackRookA.MoveTo(0, 0);
            blackRookA.Display("./Assets/BlackRook.png");
            blackRookA.SetName("blackRookA");
            pieces.Add(blackRookA);

            blackKnightB.SizeTo(100, 100);
            blackKnightB.MoveTo(100, 0);
            blackKnightB.Display("./Assets/BlackKnight.png");
            blackKnightB.SetName("blackKnightB");
            pieces.Add(blackKnightB);

            blackBishopC.SizeTo(100, 100);
            blackBishopC.MoveTo(200, 0);
            blackBishopC.Display("./Assets/BlackBishop.png");
            blackBishopC.SetName("blackBishopC");
            pieces.Add(blackBishopC);

            blackQueen.SizeTo(100, 100);
            blackQueen.MoveTo(300, 0);
            blackQueen.Display("./Assets/BlackQueen.png");
            blackQueen.SetName("blackQueen");
            pieces.Add(blackQueen);

            blackKing.SizeTo(100, 100);
            blackKing.MoveTo(400, 0);
            blackKing.Display("./Assets/BlackKing.png");
            blackKing.SetName("blackKing");
            pieces.Add(blackKing);

            blackBishopF.SizeTo(100, 100);
            blackBishopF.MoveTo(500, 0);
            blackBishopF.Display("./Assets/BlackBishop.png");
            blackBishopF.SetName("blackBishopF");
            pieces.Add(blackBishopF);

            blackKnightG.SizeTo(100, 100);
            blackKnightG.MoveTo(600, 0);
            blackKnightG.Display("./Assets/BlackKnight.png");
            blackKnightG.SetName("blackKnightG");
            pieces.Add(blackKnightG);

            blackRookH.SizeTo(100, 100);
            blackRookH.MoveTo(700, 0);
            blackRookH.Display("./Assets/BlackRook.png");
            blackRookH.SetName("blackRookH");
            pieces.Add(blackRookH);

            blackPawnA.SizeTo(100, 100);
            blackPawnA.MoveTo(0, 100);
            blackPawnA.Display("./Assets/BlackPawn.png");
            blackPawnA.SetName("blackPawnA");
            pieces.Add(blackPawnA);

            blackPawnB.SizeTo(100, 100);
            blackPawnB.MoveTo(100, 100);
            blackPawnB.Display("./Assets/BlackPawn.png");
            blackPawnB.SetName("blackPawnB");
            pieces.Add(blackPawnB);

            blackPawnC.SizeTo(100, 100);
            blackPawnC.MoveTo(200, 100);
            blackPawnC.Display("./Assets/BlackPawn.png");
            blackPawnC.SetName("blackPawnC");
            pieces.Add(blackPawnC);

            blackPawnD.SizeTo(100, 100);
            blackPawnD.MoveTo(300, 100);
            blackPawnD.Display("./Assets/BlackPawn.png");
            blackPawnD.SetName("blackPawnD");
            pieces.Add(blackPawnD);

            blackPawnE.SizeTo(100, 100);
            blackPawnE.MoveTo(400, 100);
            blackPawnE.Display("./Assets/BlackPawn.png");
            blackPawnE.SetName("blackPawnE");
            pieces.Add(blackPawnE);

            blackPawnF.SizeTo(100, 100);
            blackPawnF.MoveTo(500, 100);
            blackPawnF.Display("./Assets/BlackPawn.png");
            blackPawnF.SetName("blackPawnF");
            pieces.Add(blackPawnF);

            blackPawnG.SizeTo(100, 100);
            blackPawnG.MoveTo(600, 100);
            blackPawnG.Display("./Assets/BlackPawn.png");
            blackPawnG.SetName("blackPawnG");
            pieces.Add(blackPawnG);

            blackPawnH.SizeTo(100, 100);
            blackPawnH.MoveTo(700, 100);
            blackPawnH.Display("./Assets/BlackPawn.png");
            blackPawnH.SetName("blackPawnH");
            pieces.Add(blackPawnH);

            

            whiteRookA.SizeTo(100, 100);
            whiteRookA.MoveTo(0, 700);
            whiteRookA.Display("./Assets/WhiteRook.png");
            whiteRookA.SetName("whiteRookA");
            pieces.Add(whiteRookA);

            whiteKnightB.SizeTo(100, 100);
            whiteKnightB.MoveTo(100, 700);
            whiteKnightB.Display("./Assets/WhiteKnight.png");
            whiteKnightB.SetName("whiteKnightB");
            pieces.Add(whiteKnightB);

            whiteBishopC.SizeTo(100, 100);
            whiteBishopC.MoveTo(200, 700);
            whiteBishopC.Display("./Assets/WhiteBishop.png");
            whiteBishopC.SetName("whiteBishopC");
            pieces.Add(whiteBishopC);

            whiteQueen.SizeTo(100, 100);
            whiteQueen.MoveTo(300, 700);
            whiteQueen.Display("./Assets/WhiteQueen.png");
            whiteQueen.SetName("whiteQueen");
            pieces.Add(whiteQueen);

            whiteKing.SizeTo(100, 100);
            whiteKing.MoveTo(400, 700);
            whiteKing.Display("./Assets/WhiteKing.png");
            whiteKing.SetName("whiteKing");
            pieces.Add(whiteKing);

            whiteBishopF.SizeTo(100, 100);
            whiteBishopF.MoveTo(500, 700);
            whiteBishopF.Display("./Assets/WhiteBishop.png");
            whiteBishopF.SetName("whiteBishopF");
            pieces.Add(whiteBishopF);

            whiteKnightG.SizeTo(100, 100);
            whiteKnightG.MoveTo(600, 700);
            whiteKnightG.Display("./Assets/WhiteKnight.png");
            whiteKnightG.SetName("whiteKnightG");
            pieces.Add(whiteKnightG);

            whiteRookH.SizeTo(100, 100);
            whiteRookH.MoveTo(700, 700);
            whiteRookH.Display("./Assets/WhiteRook.png");
            whiteRookH.SetName("whiteRookH");
            pieces.Add(whiteRookH);

            whitePawnA.SizeTo(100, 100);
            whitePawnA.MoveTo(0, 600);
            whitePawnA.Display("./Assets/WhitePawn.png");
            whitePawnA.SetName("whitePawnA");
            pieces.Add(whitePawnA);

            whitePawnB.SizeTo(100, 100);
            whitePawnB.MoveTo(100, 600);
            whitePawnB.Display("./Assets/WhitePawn.png");
            whitePawnB.SetName("whitePawnB");
            pieces.Add(whitePawnB);

            whitePawnC.SizeTo(100, 100);
            whitePawnC.MoveTo(200, 600);
            whitePawnC.Display("./Assets/WhitePawn.png");
            whitePawnC.SetName("whitePawnC");
            pieces.Add(whitePawnC);

            whitePawnD.SizeTo(100, 100);
            whitePawnD.MoveTo(300, 600);
            whitePawnD.Display("./Assets/WhitePawn.png");
            whitePawnD.SetName("whitePawnD");
            pieces.Add(whitePawnD);

            whitePawnE.SizeTo(100, 100);
            whitePawnE.MoveTo(400, 600);
            whitePawnE.Display("./Assets/WhitePawn.png");
            whitePawnE.SetName("whitePawnE");
            pieces.Add(whitePawnE);

            whitePawnF.SizeTo(100, 100);
            whitePawnF.MoveTo(500, 600);
            whitePawnF.Display("./Assets/WhitePawn.png");
            whitePawnF.SetName("whitePawnF");
            pieces.Add(whitePawnF);

            whitePawnG.SizeTo(100, 100);
            whitePawnG.MoveTo(600, 600);
            whitePawnG.Display("./Assets/WhitePawn.png");
            whitePawnG.SetName("whitePawnG");
            pieces.Add(whitePawnG);

            whitePawnH.SizeTo(100, 100);
            whitePawnH.MoveTo(700, 600);
            whitePawnH.Display("./Assets/WhitePawn.png");
            whitePawnH.SetName("whitePawnH");
            pieces.Add(whitePawnH);



            return pieces;
        }
    }
}