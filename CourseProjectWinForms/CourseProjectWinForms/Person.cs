namespace CourseProjectWinForms
{
    class Person
    {
        public int Value { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirthday { get; set; }
        public string PlaceOfBirthday { get; set; }
        public bool IsDead { get; set; }
        public string PlaceOfDeath { get; set; }
        public int YearOfDeath { get; set; }
        public Person() { }
        public Person(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }
        public Person(int Value)
        {
            this.Value = Value;
        }
        public override string ToString()
        {
            return $"Information About Person:\nName:{this.Name}, \nLast Name:{this.LastName}, \nAge: {this.Age},\nYear of birthday: {this.YearOfBirthday},\nDead?: {this.IsDead},\nYear of Death: {this.YearOfDeath},\nPlace of Death: {this.YearOfDeath},  \nIndex Of Tree: {this.Value},";
        }
    }

}
