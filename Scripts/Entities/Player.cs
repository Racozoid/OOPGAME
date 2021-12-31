using System;
using Godot;
using OOPGAME.Utilities;


namespace OOPGAME.Entities
{
    public class Player : Entity
    {
        private Camera2D _Camera;

        public Player()
        {
            Data.Sprite.Texture = ImageLoader.LoadTexture("res://Sprites/Entities/Player/Knight.png", true);
            Data.InitBody(6, 4, new Vector2(0, -16));
            Data.InitCollider(3, 6);

            _Camera = new Camera2D();
            _Camera.Current = true;

            AddChild(_Camera);

            Body.PhysicsProcess += Control;
        }

        
        private void Control(float delta)
        {
            GetInputDirection();
        }

        private void GetInputDirection()
        {
            Data.Velocity.x = Godot.Input.GetActionStrength("Right") - Godot.Input.GetActionStrength("Left");
            Data.Velocity.y = Godot.Input.GetActionStrength("Down") - Godot.Input.GetActionStrength("Up");

        }
    }
}
