namespace Calendar.Application.Models
{
    internal interface IEvent
    {
        public Guid Id { get; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTimeOffset? Date { get; set; }

        public IReadOnlyList<IEvent> childEvents { get; set; }
    }
}
