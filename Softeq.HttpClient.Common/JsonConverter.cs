﻿using System;
using Newtonsoft.Json;

namespace Softeq.HttpClient.Common
{
    public static class JsonConverter
    {
        public static T Deserialize<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public static bool TryDeserialize<T>(string jsonString, out T result)
        {
            try
            {
                result = Deserialize<T>(jsonString);
                return true;
            }
            catch (Exception)
            {
                result = default(T);
                return false;
            }
        }

        public static string Serialize(object obj, bool shouldIgnoreNullValue = false)
        {
            return JsonConvert.SerializeObject(
                obj,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = shouldIgnoreNullValue ? NullValueHandling.Ignore : NullValueHandling.Include
                });
        }
    }
}
