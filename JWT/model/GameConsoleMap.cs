using FluentNHibernate.Mapping;

namespace JWT.model
{
    public class GameConsoleMap : ClassMap<GameConsole>
    {
        GameConsoleMap()
        {
            Table("GameConsole");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Year);
        }
    }
}
