﻿// Modified from original Samu Lang source by Joseph Phillips; 2011.
using Newtonsoft.Json;

namespace SharpGeoJSON
{
    public class GeometryCollection<T> : GeoObject
    {
        [JsonProperty("geometries")]
        public T[] Geometries { get; set; }

        public GeometryCollection() : base(ObjectType.GeometryCollection) { }
    }
}
