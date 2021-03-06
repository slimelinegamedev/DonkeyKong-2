using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GameStateManagementSample.Entities
{

  
    abstract class GameEntity
    {
        // Animation representing the player
        public Texture2D PlayerTexture;

        // Position of the Player relative to the upper left side of the screen
        public Vector2 Position;

        // State of the player
        public Boolean Active;

        // Get the width of the player ship
        public Int32 Width
        {
            get { return PlayerTexture.Width; }
        }

        // Get the height of the player ship
        public Int32 Height
        {
            get { return PlayerTexture.Height; }
        }

        #region basemethods
        public void Initialize()
        {
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw()
        {
        }

        #endregion


    }
}
