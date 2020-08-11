﻿// Created by Sakri Koskimies (Github: Saggre) on 11/08/2020

using System.Numerics;

namespace EconSim.Core.Primitives
{
    /// <summary>
    /// Interface for raymarched primitive shapes.
    /// </summary>
    public interface IPrimitive
    {
        /// <summary>
        /// Get options used by the shader's signed distance field functions.
        /// Like radius for a sphere for example.
        /// </summary>
        /// <returns></returns>
        public Vector4 GetPrimitiveOptions();

        /// <summary>
        /// Get this shape's type
        /// </summary>
        /// <returns></returns>
        public PrimitiveShape GetShapeType();

        // TODO move out of class
        /// <summary>
        /// Get data that can be sent to the raymarch shader to represent this object.
        /// </summary>
        /// <returns></returns>
        public RaymarchGameObjectBufferData GetBufferData();
    }
}