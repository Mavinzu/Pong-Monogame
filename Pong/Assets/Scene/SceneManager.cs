using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Scene;

public class SceneManager
{
    public static int width = 600, height = 400;
    public static float delta;
    GameScene gameScene;
    MenuScene menuScene;
    WinnerScene winnerScene;
    public static int index;
    public SceneManager(ContentManager Content)
    {
        gameScene = new(Content);
        menuScene = new(Content);
        winnerScene = new(Content);
        index = 0;
    }
    public void Update(GameTime gameTime)
    {
        delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
        if(index == 0)
        {
            menuScene.Update();
        }
        if(index == 1)
        {
            gameScene.Update();
        }
        if(index == 2)
        {
            winnerScene.Update();
        }
        
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        if(index == 0)
        {
            menuScene.Draw(spriteBatch);
        }
        if(index == 1)
        {
            gameScene.Draw(spriteBatch);
        }
        if(index == 2)
        {
            winnerScene.Draw(spriteBatch);
        }
    }
}