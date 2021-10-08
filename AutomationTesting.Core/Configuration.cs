﻿using System.IO;
using AutomationTesting.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace AutomationTesting.Common
{
    public class Configuration
    {
        public static TPage Deserialize<TPage>() where TPage : BasePage
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            TPage page = deserializer.Deserialize<TPage>(
                File.ReadAllText(@$"{typeof(TPage).Name}\{typeof(TPage).Name}.yaml"));
            return page;
        }
    }
}