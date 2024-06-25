namespace Calendar.Application.Models
{
    internal record Event : IEvent
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string? Description { get; set; } = null;
        public DateTimeOffset? Date { get; set; } = null;
        public IReadOnlyList<IEvent> childEvents { get; set; } = Array.Empty<IEvent>();

        public Event(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
    }
}
