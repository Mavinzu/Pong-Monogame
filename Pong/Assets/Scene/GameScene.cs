using Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Ui;
namespace Scene;

public class GameScene
{
    Player player1;
    Player player2;
    Ball ball;
    Score score;
    public GameScene(ContentManager Content)
    {
        player1 = new Player(Content, "Player", new Vector2(5, 150), new Rectangle(0,0,8,50), Keys.W, Keys.S);
        ball = new Ball(Content, "Ball", new Vector2(SceneManager.width / 2, SceneManager.height / 2), new Rectangle(0,0,8,8));
        player2 = new Player(Content, "Player", new Vector2(SceneManager.width - 10, 150), new Rectangle(0,0,8,50), Keys.Up, Keys.Down);
        score = new(Content);
    }
    public void Update()
    {
        Bounds();
        player1.Update();
        player2.Update();
        ball.Update();
        score.Update();
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        player1.Draw(spriteBatch);
        player2.Draw(spriteBatch);
        ball.Draw(spriteBatch);
        score.Draw(spriteBatch);
    }

    public void Bounds()
    {
        if(ball.position.X < player1.position.X + player1.rect.Width && 
           ball.position.Y > player1.position.Y + player1.rect.Height / 2 &&
           ball.position.Y < player1.position.Y + player1.rect.Height ||
           ball.position.X + ball.rect.Width > player2.position.X &&
           ball.position.Y > player2.position.Y + player2.rect.Height / 2 &&
           ball.position.Y < player2.position.Y + player2.rect.Height)
        {
            ball.speed += 30;
            ball.speed = -ball.speed;
            ball.speedY = -150;
        }
        if(ball.position.X < player1.position.X + player1.rect.Width && 
           ball.position.Y < player1.position.Y + player1.rect.Height / 2 &&
           ball.position.Y > player1.position.Y ||
           ball.position.X + ball.rect.Width > player2.position.X &&
           ball.position.Y < player2.position.Y + player2.rect.Height / 2 &&
           ball.position.Y > player2.position.Y)
        {
            ball.speed += 30;
            ball.speed = -ball.speed;
            ball.speedY = 150;
        }
    }
}