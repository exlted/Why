using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class Player
    {
        public enum moveDirection { Up, Down, Left, Right }

        Vector2 pos;
        Texture2D sprite;

        public Player()
        {
            pos = new Vector2(0f, 0f);
            sprite = null;
        }

        public Player(float X, float Y)
        {
            pos = new Vector2(X, Y);
            sprite = null;
        }

        public Player(float X, float Y, Texture2D Sprite)
        {
            pos = new Vector2(X, Y);
            sprite = Sprite;
        }

        public Vector2 getPos()
        {
            return pos;
        }

        public Texture2D getSprite()
        {
            return sprite;
        }

        public void setSprite(Texture2D newSprite)
        {
            sprite = newSprite;
        }

        public void Render()
        {
            //TODO: Add proper render calls here!
        }

        public bool Move(moveDirection MoveDirection, float Distance = 1)
        {
            switch(MoveDirection)
            {
                case moveDirection.Up:
                    pos.Y -= Distance;
                    return true;
                case moveDirection.Down:
                    pos.Y += Distance;
                    return true;
                case moveDirection.Left:
                    pos.X -= Distance;
                    return true;
                case moveDirection.Right:
                    pos.X += Distance;
                    return true;
                default:
                    return false;
            }
        }
    }
}
