using FluentNHibernate.Mapping;

namespace JWT.model
{
    public class ConsoleMap : ClassMap<Console>
    {
        ConsoleMap()
        {
            Table("Console");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.year);
        }
    }
}
