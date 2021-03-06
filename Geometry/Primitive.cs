﻿// Created by Sakri Koskimies (Github: Saggre) on 22/10/2019

using System.Drawing;
using System.Numerics;

namespace RaymarchEngine.Geometry
{
    // TODO return indices for all primitives
    public static class Primitive
    {
        /// <summary>
        /// Returns vertices for a single equilateral unit triangle
        /// </summary>
        /// <returns></returns>
        public static RenderVertex[] Triangle()
        {
            return new[]{
                 new RenderVertex(new Vector4(-0.5f, 0.0f, 0.5f, 1.0f), new Vector2(0.0f, 1.0f)),
                 new RenderVertex(new Vector4(0.5f, 0.0f, 0.5f, 1.0f), new Vector2(1.0f, 1.0f)),
                 new RenderVertex(new Vector4(0.0f, 0.0f, -0.5f, 1.0f), new Vector2(0.5f, 0.0f))
 };
        }

        /// <summary>
        /// Returns vertices for a unit plane centered at (0, 0)
        /// </summary>
        /// <returns></returns>
        public static RenderVertex[] Plane()
        {
            return new[]{
                new RenderVertex(new Vector4(0.0f, 0.0f, 0.0f, 1.0f), new Vector2(0.0f, 1.0f)), // Top
                new RenderVertex(new Vector4(0.0f, 0.0f, 1.0f, 1.0f), new Vector2(0.0f, 0.0f)),
                new RenderVertex(new Vector4(1.0f, 0.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4(0.0f, 0.0f, 0.0f, 1.0f), new Vector2(0.0f, 1.0f)),
                new RenderVertex(new Vector4(1.0f, 0.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4(1.0f, 0.0f, 0.0f, 1.0f), new Vector2(1.0f, 1.0f)),
            };
        }

        public static RenderVertex[] Cube()
        {
            return new[]{
                new RenderVertex(new Vector4(0.0f, 0.0f, 0.0f, 1.0f), new Vector2(0.0f, 1.0f)), // Front
                new RenderVertex(new Vector4(0.0f, 1.0f, 0.0f, 1.0f), new Vector2(0.0f, 0.0f)),
                new RenderVertex(new Vector4( 1.0f, 1.0f, 0.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4(0.0f, 0.0f, 0.0f, 1.0f), new Vector2(0.0f, 1.0f)),
                new RenderVertex(new Vector4( 1.0f, 1.0f, 0.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4( 1.0f, 0.0f, 0.0f, 1.0f), new Vector2(1.0f, 1.0f)),

                new RenderVertex(new Vector4(0.0f, 0.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)), // Back
                new RenderVertex(new Vector4( 1.0f, 1.0f, 1.0f, 1.0f), new Vector2(0.0f, 1.0f)),
                new RenderVertex(new Vector4(0.0f, 1.0f, 1.0f, 1.0f), new Vector2(1.0f, 1.0f)),
                new RenderVertex(new Vector4(0.0f, 0.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4( 1.0f, 0.0f, 1.0f, 1.0f), new Vector2(0.0f, 0.0f)),
                new RenderVertex(new Vector4( 1.0f, 1.0f, 1.0f, 1.0f), new Vector2(0.0f, 1.0f)),

                new RenderVertex(new Vector4(0.0f, 1.0f, 0.0f, 1.0f), new Vector2(0.0f, 1.0f)), // Top
                new RenderVertex(new Vector4(0.0f, 1.0f, 1.0f, 1.0f), new Vector2(0.0f, 0.0f)),
                new RenderVertex(new Vector4( 1.0f, 1.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4(0.0f, 1.0f, 0.0f, 1.0f), new Vector2(0.0f, 1.0f)),
                new RenderVertex(new Vector4( 1.0f, 1.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4( 1.0f, 1.0f, 0.0f, 1.0f), new Vector2(1.0f, 1.0f)),

                new RenderVertex(new Vector4(0.0f,0.0f, 0.0f, 1.0f), new Vector2(1.0f, 0.0f)), // Bottom
                new RenderVertex(new Vector4( 1.0f,0.0f, 1.0f, 1.0f), new Vector2(0.0f, 1.0f)),
                new RenderVertex(new Vector4(0.0f,0.0f, 1.0f, 1.0f), new Vector2(1.0f, 1.0f)),
                new RenderVertex(new Vector4(0.0f,0.0f, 0.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4( 1.0f,0.0f, 0.0f, 1.0f), new Vector2(0.0f, 0.0f)),
                new RenderVertex(new Vector4( 1.0f,0.0f, 1.0f, 1.0f), new Vector2(0.0f, 1.0f)),

                new RenderVertex(new Vector4(0.0f, 0.0f, 0.0f, 1.0f), new Vector2(0.0f, 1.0f)), // Left
                new RenderVertex(new Vector4(0.0f, 0.0f, 1.0f, 1.0f), new Vector2(0.0f, 0.0f)),
                new RenderVertex(new Vector4(0.0f, 1.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4(0.0f, 0.0f, 0.0f, 1.0f), new Vector2(0.0f, 1.0f)),
                new RenderVertex(new Vector4(0.0f, 1.0f, 1.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4(0.0f, 1.0f, 0.0f, 1.0f), new Vector2(1.0f, 1.0f)),

                new RenderVertex(new Vector4(1.0f, 0.0f, 0.0f, 1.0f), new Vector2(1.0f, 0.0f)), // Right
                new RenderVertex(new Vector4(1.0f, 1.0f, 1.0f, 1.0f), new Vector2(0.0f, 1.0f)),
                new RenderVertex(new Vector4(1.0f, 0.0f, 1.0f, 1.0f), new Vector2(1.0f, 1.0f)),
                new RenderVertex(new Vector4(1.0f, 0.0f, 0.0f, 1.0f), new Vector2(1.0f, 0.0f)),
                new RenderVertex(new Vector4(1.0f, 1.0f, 0.0f, 1.0f), new Vector2(0.0f, 0.0f)),
                new RenderVertex(new Vector4(1.0f, 1.0f, 1.0f, 1.0f), new Vector2(0.0f, 1.0f)),
             };

        }
    }
}