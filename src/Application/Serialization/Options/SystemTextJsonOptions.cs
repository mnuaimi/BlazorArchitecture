using System.Text.Json;
using HelpDesk.Architecture.Application.Interfaces.Serialization.Options;

namespace HelpDesk.Architecture.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}