﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace ProductPriceTracking.MvcUi.ExtensionMethods
{
    public static class HtmlExtensionMethods
    {
        public static IHtmlContent ToJson(this IHtmlHelper helper, object obj)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            settings.Converters.Add(new JavaScriptDateTimeConverter());
            return helper.Raw(JsonConvert.SerializeObject(obj, settings));
        }
    }
}
