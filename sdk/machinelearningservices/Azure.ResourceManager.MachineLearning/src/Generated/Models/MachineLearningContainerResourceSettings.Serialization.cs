// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningContainerResourceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Cpu))
            {
                if (Cpu != null)
                {
                    writer.WritePropertyName("cpu"u8);
                    writer.WriteStringValue(Cpu);
                }
                else
                {
                    writer.WriteNull("cpu");
                }
            }
            if (Optional.IsDefined(Gpu))
            {
                if (Gpu != null)
                {
                    writer.WritePropertyName("gpu"u8);
                    writer.WriteStringValue(Gpu);
                }
                else
                {
                    writer.WriteNull("gpu");
                }
            }
            if (Optional.IsDefined(Memory))
            {
                if (Memory != null)
                {
                    writer.WritePropertyName("memory"u8);
                    writer.WriteStringValue(Memory);
                }
                else
                {
                    writer.WriteNull("memory");
                }
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningContainerResourceSettings DeserializeMachineLearningContainerResourceSettings(JsonElement element)
        {
            Optional<string> cpu = default;
            Optional<string> gpu = default;
            Optional<string> memory = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cpu = null;
                        continue;
                    }
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gpu = null;
                        continue;
                    }
                    gpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        memory = null;
                        continue;
                    }
                    memory = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningContainerResourceSettings(cpu.Value, gpu.Value, memory.Value);
        }
    }
}
