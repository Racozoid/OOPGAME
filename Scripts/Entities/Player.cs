using System;
using Godot;
using OOPGAME.Utilities;

// Класс игрока
namespace OOPGAME.Entities
{
    public class Player : Entity
    {
        private Camera2D _Camera;

        public Player()
        {
            // Параметры игрока
            Data.Sprite.Texture = ImageLoader.LoadTexture("res://Sprites/Entities/Player/Knight.png", true);
            Data.InitBody(6, 4, new Vector2(0, -16));
            Data.InitCollider(3, 6);

            // Камера
            _Camera = new Camera2D();
            _Camera.Current = true;

            AddChild(_Camera);

            Body.PhysicsProcess += Control;
        }

        // Управление персонажем
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
