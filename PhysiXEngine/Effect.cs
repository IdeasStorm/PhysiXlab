﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PhysiXEngine
{
    abstract class Effect
    {
        protected HashSet<Body> bodies;

        public void AddBody(Body body)
        {
            bodies.Add(body);
        }

        public void RemoveBody(Body body)
        {
            bodies.Remove(body);
        }

        public void Update(float time)
        {
            foreach (Body body in bodies)
            {
                Affect(body,time);
            }
        }

        public void Affect(Body body, float duration);
        public void Affect(Body body1, Body body2, float duration);

    }
}
