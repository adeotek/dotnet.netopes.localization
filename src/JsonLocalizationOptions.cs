using Microsoft.Extensions.Localization;

namespace Netopes.Localization
{
    public enum ResourcesType
    {
        CultureBased,
        TypeBased,
        Mixed
    }
    
    public enum ResourcesLoadMode
    {
        File,
        EmbeddedResource
    }

    public enum ResourcesCacheMode
    {
        None,
        InMemory
    }

    public class JsonLocalizationOptions : LocalizationOptions
    {
        public ResourcesType ResourcesType { get; set; } = ResourcesType.TypeBased;
        public ResourcesLoadMode ResourcesLoadMode { get; set; } = ResourcesLoadMode.File;
        public ResourcesCacheMode ResourcesCacheMode { get; set; } = ResourcesCacheMode.None;
    }
}
