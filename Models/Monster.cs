namespace MVCTest.Models
{
    public class Monster
    {
        public int MonsterID { get; set; }
        public string Type { get; set; }
        //public int HP { get; set; }
        public int Damage { get; set; }
        public Room Room { get; set; }
        public Hp Hp { get; set; }
    }
}