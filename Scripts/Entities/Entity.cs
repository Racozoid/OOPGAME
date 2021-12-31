using System;
using Godot;

// Класс для описания любого живого сущесства в игре (игрок, противники и т.д.)
namespace OOPGAME.Entities
{
    public abstract class Entity
    {
        public EntityBody Body;
        public EntityData Data;

        public Entity()
        {
            Data = new EntityData();
            Body = new EntityBody(Data);

            AddChild(Data.Sprite);
            AddChild(Data.Collider);

            Body.PhysicsProcess = PhysicsProcess;
            Body.Process = Process;
            Body.Input = Input;
        }

        // Базовые методы для передачи в делегаты KinematicBody2D
        public void PhysicsProcess(float delta)
        {

        }

        public void Process(float delta)
        {

        }
        public void Input(InputEvent ev)
        {

        }

        
        public void ConnectToNode(Node parent)
        {
            parent.AddChild(Body);
        }

        public void DisconnecFromNode(Node parent)
        {
            parent.RemoveChild(Body);
        }

        public void AddChild(Node child)
        {
            Body.AddChild(child);
        }

        public void RemoveChild(Node child)
        {
            Body.RemoveChild(child);
        }
    }
}
