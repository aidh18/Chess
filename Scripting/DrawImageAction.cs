using System;
using System.Collections.Generic;
using Chess.Casting;
using Chess.Scripting;
using Chess.Services;


namespace Chess.Scripting
{
    /// <summary>
    /// Draws the actors on the screen.
    /// </summary>
    public class DrawImageAction : Chess.Scripting.Action
    {
        private IVideoService _videoService;

        public DrawImageAction(IServiceFactory serviceFactory)
        {
            _videoService = serviceFactory.GetVideoService();
        }

        public override void Execute(Scene scene, float deltaTime, IActionCallback callback)
        {
            try
            {
                // get the actors from the cast
                Image board = scene.GetFirstActor<Image>("board");
                List<Image> pieces = scene.GetAllActors<Image>("pieces");

                // draw the actors on the screen using the video service
                _videoService.ClearBuffer();
                _videoService.Draw(board);
                _videoService.Draw(pieces);
                _videoService.FlushBuffer();
            }
            catch (Exception exception)
            {
                callback.OnError("Couldn't draw robots.", exception);
            }
        }
    }
}