using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon2D
{
    class Camera
    {
        public Vector2 Position;
        public float Rotation;
        public float Zoom;
        public Vector2 Origin;

        public Camera()
            : this(new Vector2(0, 0))
        {

        }

        public Camera(Vector2 position)
            : this(position, 0)
        {
            
        }

        public Camera(Vector2 position, float rotation)
            : this(position, 0, 1)
        {

        }

        public Camera(Vector2 position, float rotation, float zoom)
        {
            Position = position;
            Rotation = rotation;
            Zoom = zoom;
            Origin = position;
        }

        public void Move(Vector2 direction)
        {
            Position += direction;
        }

        public Matrix GetMatrix()
        {
            Matrix translationMatrix = Matrix.CreateTranslation(new Vector3(Position, 0));
            Matrix rotationMatrix = Matrix.CreateRotationZ(Rotation);
            Matrix scaleMatrix = Matrix.CreateScale(Zoom);
            Matrix originMatrix = Matrix.CreateTranslation(new Vector3(Origin, 0));

            return translationMatrix * rotationMatrix * scaleMatrix * originMatrix;
        }
    }
}
