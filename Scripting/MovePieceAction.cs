using System;
using System.Numerics;
using System.Collections.Generic;
using Chess.Casting;
using Chess.Scripting;
using Chess.Services;


namespace Chess.Scripting
{
    /// <summary>
    /// Moves the actors and wraps them around the screen boundaries. Note, this is different from
    /// steering them which only changes their direction. The call to actor.Move() is what updates
    /// their position on the screen.
    /// </summary>
    public class MovePieceAction : Chess.Scripting.Action
    {
        private IMouseService _mouseService;

        public MovePieceAction(IServiceFactory serviceFactory)
        {
            _mouseService = serviceFactory.GetMouseService();
        }

        public override void Execute(Scene scene, float deltaTime, IActionCallback callback)
        {
            try
            {
                
                if (_mouseService.IsButtonPressed(MouseButton.Left))
                {
                    Vector2 mousePos = _mouseService.GetCoordinates();

                    float mouseX = (float)Math.Floor(mousePos.X / 100) * 100;
                    float mouseY = (float)Math.Floor(mousePos.Y / 100) * 100;

                    mousePos = new Vector2(mouseX, mouseY);
                    

                    // get the actors from the scene
                    List<Actor> cast = scene.GetAllActors("pieces");
                    Piece selectedActor;
                    bool pieceClicked = false;

                    foreach (Piece actor in cast)
                    {
                        if (actor.GetPosition() == mousePos)
                        {
                            pieceClicked = true;
                            selectedActor = actor;
                            selectedActor.Select();
                            Console.WriteLine($"{selectedActor.GetName()}");
                        }
                    }

                    if (!pieceClicked)
                    {
                        foreach (Piece actor in cast)
                        {
                            if (actor.IsSelected())
                            {
                                actor.MoveTo(mousePos);
                                actor.Deselect();
                            }
                        }
                    }

                }
                
                // move the actor and wrap it around the screen boundaries
                // actor.Move();
                // actor.WrapIn(screen);
            }
            catch (Exception exception)
            {
                callback.OnError("Couldn't move actor.", exception);
            }
        }
    }
}