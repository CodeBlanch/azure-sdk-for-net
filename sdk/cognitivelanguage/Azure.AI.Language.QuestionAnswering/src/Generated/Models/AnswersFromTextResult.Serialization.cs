// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class AnswersFromTextResult
    {
        internal static AnswersFromTextResult DeserializeAnswersFromTextResult(JsonElement element)
        {
            Optional<IReadOnlyList<TextAnswer>> answers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("answers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TextAnswer> array = new List<TextAnswer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnswer.DeserializeTextAnswer(item));
                    }
                    answers = array;
                    continue;
                }
            }
            return new AnswersFromTextResult(Optional.ToList(answers));
        }
    }
}
