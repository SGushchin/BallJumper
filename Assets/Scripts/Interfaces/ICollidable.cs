using System;
using UnityEngine;


namespace BallJumper.Interfaces
{
    public interface ICollidable
    {
        event Action<object, Collision2D> OnCollisionEnter2DEvent;
    }
}
