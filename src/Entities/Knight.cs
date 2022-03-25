namespace AbsRPG.src.Entities
{
 

    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Knight()
        {
            
        }

         public string Attack(int Bonus) {
        if(Bonus > 6) {
            return this.Name + " atacou com a espada " + Bonus + " vezes";
        } else {
            return this.Name + " atacou com a espada " + Bonus + " vezes";
        }
    }
}
}