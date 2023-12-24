using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Scene;
using Template;
using Ui;

namespace Components;

public class Ball : Sprite
{
    public int speed, speedY;

    public Ball(ContentManager Content, string File, Vector2 Pos, Rectangle Rect) : base(Content, File, Pos, Rect)
    {
        speed = 200;
    }
    public override void Update()
    {
        Points();
        if (position.Y <= 0 || position.Y >= SceneManager.height)
        {
            speedY = -speedY;
        }
        position.X -= speed * SceneManager.delta;
        position.Y -= speedY * SceneManager.delta;
    }

    void Points()
    {
        if(position.X <= 0)
        {
            Score._score2 += 1;
        }
        if(position.X > SceneManager.width)
        {
            Score._score +=1;
        }
        if (position.X <= 0 || position.X > SceneManager.width)
        {
            position.X = SceneManager.width / 2;
            position.Y = SceneManager.height / 2;
            speedY = 0;
        }
    }
}