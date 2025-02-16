// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class MongoDBParameterPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString");
                writer.WriteStringValue(ConnectionString);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database");
                writer.WriteStringValue(Database);
            }
            if (Optional.IsDefined(Command))
            {
                writer.WritePropertyName("command");
                writer.WriteStringValue(Command);
            }
            writer.WriteEndObject();
        }
    }
}
