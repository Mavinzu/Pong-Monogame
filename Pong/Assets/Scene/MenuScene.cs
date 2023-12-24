using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Template;

namespace Scene;

public class MenuScene
{
    Button button;
    Text text;
    public MenuScene(ContentManager Content)
    {
        button = new Button(Content, "Sprite", new Rectangle(SceneManager.width / 2 - 50, SceneManager.height / 2 - 8, 100, 32));
        text = new Text(Content, "File", new Vector2(SceneManager.width / 2 - 37, SceneManager.height / 2 - 9));
    }
    public void Update()
    {
        button.Update();
        text.Update();
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        button.Draw(spriteBatch);
        text.Draw(spriteBatch, "Play");
    }
}