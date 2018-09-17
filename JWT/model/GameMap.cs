using FluentNHibernate.Mapping;

namespace JWT.model
{
    public class GameMap : ClassMap<Game>
    {
        GameMap()
        {
            Table("Game");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Year);
        }
    }
}
