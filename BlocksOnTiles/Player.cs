using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOnTiles
{
    class Player : GameObject
    {
        Texture2D texture;
        Rectangle rectangle;
        Vector2 moveDir;
        float speed;

        public Player()
        {
            texture = TextureLibrary.GetTexture("Player");
            speed = 600;
            rectangle = texture.Bounds;
        }

        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            KeyboardState keyboardState = Keyboard.GetState();
            moveDir = new Vector2();
            if (keyboardState.IsKeyDown(Keys.D))
                moveDir.X = 1;
            if (keyboardState.IsKeyDown(Keys.A))
                moveDir.X = -1;
            if (keyboardState.IsKeyDown(Keys.W))
                moveDir.Y = -1;
            if (keyboardState.IsKeyDown(Keys.S))
                moveDir.Y = 1;

            if (moveDir != Vector2.Zero)
            {
                moveDir.Normalize();
                rectangle.Location += (moveDir * speed * deltaTime).ToPoint();
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
