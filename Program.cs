using System;
using System.Collections.Generic;
using Chess.Casting;
using Chess.Directing;
using Chess.Scripting;
using Chess.Services;

namespace Chess
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate a service factory for other objects to use.
            IServiceFactory serviceFactory = new RaylibServiceFactory();

            // Instantiate the actors that are the focus of this example.
            PieceCreator pieceCreator = new PieceCreator();
            List<Piece> pieces = pieceCreator.GetPieces();

            Image board = new Image();
            board.SizeTo(800, 800);
            board.MoveTo(0, 0);
            board.Display("./Assets/ChessBoard.png");
            
            // Instantiate the actions
            DrawImageAction drawImageAction = new DrawImageAction(serviceFactory);
            SwitchTurnsAction switchTurnsAction = new SwitchTurnsAction();
            MovePieceAction movePieceAction = new MovePieceAction(serviceFactory);

            // Instantiate a new scene and add the actors and actions.
            Scene scene = new Scene();
            scene.AddActor("board", board);
            foreach (Piece piece in pieces)
            {
                scene.AddActor("pieces", piece);
            }

            scene.AddAction(Phase.Output, drawImageAction);
            scene.AddAction(Phase.Update, switchTurnsAction);
            scene.AddAction(Phase.Update, movePieceAction);

            // Start the game.
            Director director = new Director(serviceFactory);
            director.Direct(scene);
        }
    }
}