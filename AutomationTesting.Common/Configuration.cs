using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace AutomationTesting.Common
{
    public class Configuration
    {
        public TPage Deserializer<TPage>() where TPage : class
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            return deserializer.Deserialize<TPage>(
                File.ReadAllText(@$"{typeof(TPage).Name}\{typeof(TPage).Name}.yaml"));
        }
    }
}