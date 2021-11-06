using Godot;
using System;

public class Player : KinematicBody
{
    int speed = 8, groundAcceleration = 8, airAcceleration = 2, acceleration = groundAcceleration, stickAmount = 10, mouseSensitivity = 1;
    float jump = 4.5, gravity = 9.8;
    bool grounded = true
    Vector3 direction, velocity, movement, gravityVec;

    public override void _Input(InputEvent event)
    {
        if(event == InputEventMouseMotion)
        {
            RotationDegrees.y -= event.relative.x * mouseSensitivity / 10;
            GetNode("Camera").RotationDegrees.x = GD.Clamp(GetNode("Camera").RotationDegrees.x - event.relative.y * mouseSensitivity / 10, -90, 90);
            direction = Vector3;
            direction.z = -Input.GetActionStrength("MoveForward") + Input.GetActionStrength("MoveBackward");
            direction.x = -Input.GetActionStrength("MoveLeft") + Input.GetActionStrength("MoveRight");
            direction = direction.Normalized().Rotated(Vector3.UP, Rotation.y);
        }
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//
//  }
}
