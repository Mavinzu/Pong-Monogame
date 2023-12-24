using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Template;

namespace Scene;

public class WinnerScene
{
    Text text;
    public static int iPlayer1, iPlayer2;
    float timer;
    public WinnerScene(ContentManager Content)
    {
        text = new Text(Content, "File", new Vector2(SceneManager.width / 2 - 150, SceneManager.height / 2 - 50));
        timer = 3f;
    }
    public void Update()
    {
        timer -= SceneManager.delta;
        if (timer < 0)
        {
            timer = 3f;
            SceneManager.index = 0;
        }
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        text.Draw(spriteBatch, "Winner is " + Winner());
    }
    string Winner()
    {
        if(iPlayer1 > 0)
        {
            return "player2";
        }else if(iPlayer2 > 0)
        {
            return "player1";
        }
        return "";
        
    }
}