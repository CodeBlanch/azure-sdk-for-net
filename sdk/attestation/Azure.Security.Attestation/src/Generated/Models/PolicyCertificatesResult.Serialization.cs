// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Security.Attestation
{
    [JsonConverter(typeof(PolicyCertificatesResultConverter))]
    internal partial class PolicyCertificatesResult
    {
        internal static PolicyCertificatesResult DeserializePolicyCertificatesResult(JsonElement element)
        {
            Optional<JsonWebKeySet> xMsPolicyCertificates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x-ms-policy-certificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    xMsPolicyCertificates = JsonWebKeySet.DeserializeJsonWebKeySet(property.Value);
                    continue;
                }
            }
            return new PolicyCertificatesResult(xMsPolicyCertificates.Value);
        }

        internal partial class PolicyCertificatesResultConverter : JsonConverter<PolicyCertificatesResult>
        {
            public override void Write(Utf8JsonWriter writer, PolicyCertificatesResult model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override PolicyCertificatesResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePolicyCertificatesResult(document.RootElement);
            }
        }
    }
}
