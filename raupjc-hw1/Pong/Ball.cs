﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    /// <summary >
    /// Game ball object representation
    /// </ summary >
    public class Ball : Sprite
    {
        /// <summary >
        /// Defines current ball speed in time .
        /// </ summary >
        public float Speed { get; set; }
        public float BumpSpeedIncreaseFactor { get; set; }
        public float MaximumBallSpeed { get; set; }
        /// <summary >
        /// Defines ball direction .
        /// Valid values ( -1 , -1) , (1 ,1) , (1 , -1) , ( -1 ,1).
        /// Using Vector2 to simplify game calculation . Potentially
        /// dangerous because vector 2 can swallow other values as well .
        /// OPTIONAL TODO : create your own , more suitable type
        /// </ summary >
        public BallDirectionVector Direction { get; set; }
        public Ball(int size, float speed, float defaultBallBumpSpeedIncreaseFactor, float initialMaximumBallSpeed) : base(size, size)
        {
            Speed = speed;
            BumpSpeedIncreaseFactor = defaultBallBumpSpeedIncreaseFactor;
            MaximumBallSpeed = initialMaximumBallSpeed;
            // Initial direction
            Direction = new BallDirectionVector(1, 1);
        }
    }
}
