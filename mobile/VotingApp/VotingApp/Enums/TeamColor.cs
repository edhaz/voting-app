﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VotingApp
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TeamColor
    {
        [EnumMember(Value = "red")]
        Red = 1,

        [EnumMember(Value = "green")]
        Green = 2
    }
}
