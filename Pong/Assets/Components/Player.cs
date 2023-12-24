using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Scene;
using Template;

namespace Components;

public class Player : Sprite
{
    Keys[] input = new Keys[2];
    public Player(ContentManager Content, string File, Vector2 Pos, Rectangle Rect ,Keys A, Keys B) : base(Content, File, Pos, Rect)
    {
        input[0] = A;
        input[1] = B;
    }
    public override void Update()
    {
        Movement();
    }
    void Movement()
    {
        if(Keyboard.GetState().IsKeyDown(input[0]) && position.Y > 0)
        {
            position.Y -= 200 * SceneManager.delta;
        }
        if(Keyboard.GetState().IsKeyDown(input[1]) && position.Y + rect.Height < SceneManager.height)
        {
            position.Y += 200 * SceneManager.delta;
        }
    }
}