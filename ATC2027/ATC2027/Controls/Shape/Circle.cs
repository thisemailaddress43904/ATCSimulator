using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATC2027.Controls
{
    public class Circle : IComponent
    {
        GraphicsDevice graphicsDevice;
        Vector2 location;
        int radius;
        Color color;

        bool radiusHasChanged;

        bool getShouldTextureBeUpdated() => radiusHasChanged;

        Texture2D texture;

        public Circle(Vector2 location, int radius, Color color, GraphicsDevice graphicsDevice) {
            this.location = location;
            this.radius = radius;
            this.graphicsDevice = graphicsDevice;
            this.color = color;
            UpdateTexture();
        }

        public void setLocation(Vector2 vector2) => this.location = vector2;
        public Vector2 getLocation() => this.location;
        public int getRadius() => this.radius;
        public void setRadius(int radius) {
            this.radius = radius;
            this.radiusHasChanged = true;
        } 

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, location, null, color);
        }

        public void UpdateTexture()
        {
            this.radiusHasChanged = false;

            int diameter = radius * 2;
            this.texture = new Texture2D(this.graphicsDevice, diameter, diameter);
            Color[] data = new Color[diameter * diameter];

            for (int y = 0; y < diameter; y++)
            {
                for (int x = 0; x < diameter; x++)
                {
                    int index = x + y * diameter;
                    Vector2 pos = new Vector2(x - radius, y - radius);
                    data[index] = pos.Length() <= radius ? this.color : Color.Transparent;
                }
            }
            this.texture.SetData(data);
        }

        public void Update(GameTime gameTime)
        {
            if (getShouldTextureBeUpdated())
            {
                UpdateTexture();
            }
        }
    }
}
