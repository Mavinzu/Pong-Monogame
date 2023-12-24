using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Scene;

namespace Template;

public class Button
{
    Texture2D sprite;
    Rectangle rectangle;
    Color color;
    public Button(ContentManager Content, string FileImage, Rectangle Rect)
    {
        sprite = Content.Load<Texture2D>(FileImage);
        rectangle = Rect;
        color = Color.White;
    }
    public void Update()
    {
        if (rectangle.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton > 0)
        {
            color = Color.Blue;
            SceneManager.index = 1;
        } else
        {
            color = Color.White;
        }
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(sprite, rectangle, null, color);
    }
}