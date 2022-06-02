namespace ClassLibrary1
{
    public class Salary
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _sPH;
        private int _workingHours;

        public int WorkingHours
        {
            get { return _workingHours; }
            set { _workingHours = value; }
        }

        public int SPH
        {
            get { return _sPH; }
            set { _sPH = value; }
        }

        public Salary(string name, int workingHours, int salaryPerHour)
        {
            this._name = name;
            if (salaryPerHour == 0)
            {
                Console.WriteLine("boro baba");
            }
            else
            {
                this.SPH = salaryPerHour;
            }
            this.WorkingHours = workingHours;
        }
        public int Daily()
        {
            return SPH * _workingHours;
        }
        public int Monthly()
        {
            return SPH * _workingHours * 26;
        }
    }
}