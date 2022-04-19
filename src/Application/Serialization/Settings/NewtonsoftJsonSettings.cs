
using HelpDesk.Architecture.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace HelpDesk.Architecture.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}