namespace Zawodnicy
{
    class Player
    {
        private string fName;
        private string sName;
        private double weight;
        private int age;

        public Player(string fn, string sn, double w, int a)
        {
            this.age = a;
            this.fName = fn;
            this.sName = sn;
            this.weight = w;
        }

        public string GetFirstName { get { return fName; } set { fName = value; } }
        public string GetSecondName { get { return sName; } set { sName = value; } }
        public double GetWeight { get { return weight; } set { weight = value; } }
        public int GetAge { get { return age; } set { age = value; } }
    }
}
