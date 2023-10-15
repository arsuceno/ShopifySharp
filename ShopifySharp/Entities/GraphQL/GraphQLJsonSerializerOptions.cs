﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShopifySharp.Entities.GraphQL
{
    internal class GraphQLJsonSerializerOptions
    {
        public static readonly JsonSerializerOptions Instance = new JsonSerializerOptions
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            Converters = { new JsonStringEnumConverter() },
        };
    }
}
