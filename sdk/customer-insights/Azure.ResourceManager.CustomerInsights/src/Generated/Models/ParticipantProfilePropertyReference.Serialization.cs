// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ParticipantProfilePropertyReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("interactionPropertyName"u8);
            writer.WriteStringValue(InteractionPropertyName);
            writer.WritePropertyName("profilePropertyName"u8);
            writer.WriteStringValue(ProfilePropertyName);
            writer.WriteEndObject();
        }

        internal static ParticipantProfilePropertyReference DeserializeParticipantProfilePropertyReference(JsonElement element)
        {
            string interactionPropertyName = default;
            string profilePropertyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("interactionPropertyName"u8))
                {
                    interactionPropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profilePropertyName"u8))
                {
                    profilePropertyName = property.Value.GetString();
                    continue;
                }
            }
            return new ParticipantProfilePropertyReference(interactionPropertyName, profilePropertyName);
        }
    }
}
