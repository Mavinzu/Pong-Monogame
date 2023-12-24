using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Template;

public class Sprite
{
    protected Texture2D sprite;
    public Rectangle rect;
    public Vector2 position;
    public Sprite(ContentManager Content, string File, Vector2 Pos, Rectangle Rect)
    {
        sprite = Content.Load<Texture2D>(File);
        position = Pos;
        rect = Rect;
    }
    public virtual void Update()
    {

    }
    public virtual void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(sprite, position, rect, Color.White);
    }
}