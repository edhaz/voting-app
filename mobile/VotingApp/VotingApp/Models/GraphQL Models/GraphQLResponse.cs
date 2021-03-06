﻿using Newtonsoft.Json;

namespace VotingApp
{
    class GraphQLResponse<T>
    {
        public GraphQLResponse(T data, GraphQLError[] errors)
        {
            Data = data;
            Errors = errors;
        }

        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("errors")]
        public GraphQLError[] Errors { get; set; }
    }
}
