using System;

namespace JWT.model
{
    public class Game
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Year { get; set; }
    }
}
