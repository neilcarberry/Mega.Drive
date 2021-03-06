using Newtonsoft.Json;
using System;

namespace EventBus.Events
{
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        [JsonConstructor]
        public IntegrationEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreationDate = createDate;
        }

        [JsonProperty]
        public bool LegacyOut { get; set; } = false;

        [JsonProperty]
        public Guid Id { get; private set; }

        [JsonProperty]
        public DateTime CreationDate { get; private set; }
    }
}