using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOnTiles
{
    static class TextureLibrary
    {
        static Dictionary<string, Texture2D> textures;

        public static Texture2D GetTexture(string key)
        {
            return textures[key];
        }

        public static void LoadTextures(ContentManager contentManager)
        {
            textures = new Dictionary<string, Texture2D>
            {
                ["Player"] = contentManager.Load<Texture2D>("player")
            };
        }
    }
}
