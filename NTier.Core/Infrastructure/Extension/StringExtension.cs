using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.Core
{
    public static class StringExtension
    {

        private static JsonSerializerSettings set = new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        };
        public static string ToJson(this object model)
        {
            if (model != null)
                return JsonConvert.SerializeObject(model, set);
            else
                return null;
        }
        public static Model FromJson<Model>(this string jsonModel) where Model : class
        {
            if (!string.IsNullOrEmpty(jsonModel))
                return JsonConvert.DeserializeObject<Model>(jsonModel, set);
            else
                return Activator.CreateInstance<Model>();
        }
    }
}