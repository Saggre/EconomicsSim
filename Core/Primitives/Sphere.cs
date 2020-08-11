﻿// Created by Sakri Koskimies (Github: Saggre) on 11/08/2020

using System.Numerics;
using EconSim.EMath;

namespace EconSim.Core.Primitives
{
    /// <summary>
    /// A sphere. What about it?
    /// </summary>
    public class Sphere : Primitive
    {
        private float radius;

        /// <summary>
        /// The radius of this sphere.
        /// </summary>
        public float Radius
        {
            get => radius;
            set => radius = value;
        }

        /// <inheritdoc />
        public Sphere()
        {
            radius = 1f;
        }

        /// <inheritdoc />
        public Sphere(Vector3 position, Quaternion rotation, float radius) : base(position, rotation, Vector3.One)
        {
            this.radius = radius;
        }

        /// <inheritdoc />
        public override PrimitiveShape GetShapeType()
        {
            return PrimitiveShape.Sphere;
        }

        /// <inheritdoc />
        public override Vector4 GetPrimitiveOptions()
        {
            return new Vector4(radius, 0f, 0f, 0f);
        }
    }
}