﻿using System;

using LinqToDB;
using NpgsqlTypes;

namespace Linq2db.Postgis.Extensions
{
    // http://postgis.refractions.net/documentation/manual-1.5/reference.html#Geometry_Processing

    public static class GeometryProcessingFunctions
    {
        /// <summary>
        /// Returns a geometry that represents all points whose distance from this Geometry is less than or equal to distance.
        /// http://postgis.refractions.net/documentation/manual-1.5/ST_Buffer.html
        /// </summary>
        /// <param name="geom">Input geometry</param>
        /// <param name="radius">Radius of buffer</param>
        /// <returns>Buffer geometry</returns>
        [Sql.Function("ST_Buffer", ServerSideOnly = true)]
        public static PostgisGeometry StBuffer(this PostgisGeometry geom, double radius)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// The convex hull of a geometry represents the minimum convex geometry that encloses all geometries within the set.
        /// http://postgis.refractions.net/documentation/manual-1.5/ST_ConvexHull.html
        /// </summary>
        /// <param name="geom">Input geometry</param>
        /// <returns>The convex hull of a geometry</returns>
        [Sql.Function("ST_ConvexHull", ServerSideOnly = true)]
        public static PostgisGeometry StConvexHull(this PostgisGeometry geom)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Returns the smallest circle polygon that can fully contain a geometry.
        /// http://postgis.refractions.net/documentation/manual-1.5/ST_MinimumBoundingCircle.html
        /// </summary>
        /// <param name="geom">Input geometry</param>
        /// <returns>Smallest circle polygon that can fully contain a geometry.</returns>
        [Sql.Function("ST_MinimumBoundingCircle", ServerSideOnly = true)]
        public static PostgisGeometry StMinimumBoundingCircle(this PostgisGeometry geom)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Returns a geometry that represents the point set union of the input geometries.
        /// http://postgis.refractions.net/documentation/manual-1.5/ST_Union.html
        /// </summary>
        /// <param name="geomA">Input geometry A</param>
        /// <param name="geomB">Input geometry B</param>
        /// <returns>Union of the input geometries</returns>
        [Sql.Function("ST_Union", ServerSideOnly = true)]
        public static PostgisGeometry StUnion(this PostgisGeometry geomA, PostgisGeometry geomB)
        {
            throw new InvalidOperationException();
        }
    }
}
