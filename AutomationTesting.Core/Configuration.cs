using System.Collections.Generic;
using System.IO;
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
                File.ReadAllText(@$"{typeof(TPage).Name}.yaml"));
            page.ControlRegistry = new Dictionary<string, Control>();

            foreach (var property in page.GetType().GetProperties())
            {
                if (property.GetValue(page) is Control)
                    page.ControlRegistry.Add(property.Name, (Control) property.GetValue(page));
            }
            
            return page;
        }
    }
}