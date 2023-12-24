using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Scene;
using Template;

namespace Ui;

public class Score
{
    Text score1;
    Text score2;
    public static int _score, _score2;
    public Score(ContentManager Content)
    {
        _score = 0;
        _score2 = 0;
        score1 = new Text(Content, "File", new Vector2(SceneManager.width / 2 - 20, 10));
        score2 = new Text(Content, "File", new Vector2(SceneManager.width / 2 + 20, 10));
    }
    public void Update()
    {
        if (_score > 9 || _score2 > 9)
        {
            SceneManager.index = 2;
        }
        if (_score > 9)
        {
            WinnerScene.iPlayer2 = 1;
            _score = 0;
        } else if (_score2 > 9)
        {
            WinnerScene.iPlayer1 = 1;
            _score2 = 0;
        }

        
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        score1.Draw(spriteBatch, _score.ToString());
        score2.Draw(spriteBatch, _score2.ToString());
    }
}