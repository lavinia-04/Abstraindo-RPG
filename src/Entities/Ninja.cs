namespace AbsRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        //public override string Attack()
        //{
            //return this.Name + " lançou uma shuriken";
        //}

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " atacou " + Bonus + " vezes";
            }
            else
            {
                return this.Name + " atacou com bonus de " + Bonus;
            }
        }
    }
}
