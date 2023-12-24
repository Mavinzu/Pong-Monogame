using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Template;

public class Text
{
    protected SpriteFont spriteFont;
    protected Vector2 position;
    public Text(ContentManager Content, string File, Vector2 Pos)
    {
        spriteFont = Content.Load<SpriteFont>(File);
        position = Pos;
    }
    public virtual void Update()
    {

    }
    public virtual void Draw(SpriteBatch spriteBatch, string Text)
    {
        spriteBatch.DrawString(spriteFont, Text, position, Color.White);
    }
}