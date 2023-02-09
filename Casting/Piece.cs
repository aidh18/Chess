using System;

namespace Chess.Casting
{
    /// <summary>
    /// A piece in the game.
    /// </summary>
    public class Piece : Image
    {
        private string _name;
        private bool _selected = false;
        private string _color;
        public void TranslatePosition()
        {
            
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public void Select()
        {
            _selected = true;
        }

        public void Deselect()
        {
            _selected = false;
        }

        public bool IsSelected()
        {
            return _selected;
        }
    }
}