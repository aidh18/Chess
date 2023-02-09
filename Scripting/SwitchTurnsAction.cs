using System;
using System.Collections.Generic;


namespace Chess.Scripting
{
    /// <summary>
    /// Draws the actors on the screen.
    /// </summary>
    public class SwitchTurnsAction : Chess.Scripting.Action
    {
        public SwitchTurnsAction() { }

        public override void Execute(Scene scene, float deltaTime, IActionCallback callback)
        {
            try
            {
                
            }
            catch (Exception exception)
            {
                callback.OnError("Couldn't switch turns.", exception);
            }
        }
    }
}