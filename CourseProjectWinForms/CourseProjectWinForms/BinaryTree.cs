using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProjectWinForms
{
    class BinaryTree
    {
        private List<Person> personArray = new List<Person>();
        public Person this[int index]
        {
            get
            {
                return (Person)personArray[index];
            }
            set
            {
                personArray.Insert(index, value);
            }
        }  //indexer

        public int Level { get; set; }
        public BinaryTree(int Level)
        {
            this.Level = Level;
        }
        public BinaryTree() { }

        public void BuildTree()
        {
            personArray.Insert(0, new Person(0));
            List<Person> tempItems = null;
            switch (Level)
            {
                case 1:
                    List<Person> items1 = new List<Person>()
                    {
                         new Person(1),
                         new Person(2),
                    };
                    tempItems = items1;
                    break;
                case 2:
                    List<Person> items2 = new List<Person>()
                    {
                        new Person(1),
                        new Person(2),
                        new Person(3),
                        new Person(4),
                        new Person(5),
                        new Person(6),
                    };
                    tempItems = items2;
                    break;
                case 3:
                    List<Person> items3 = new List<Person>()
                    {
                        new Person(1),
                        new Person(2),
                        new Person(3),
                        new Person(4),
                        new Person(5),
                        new Person(6),
                        new Person(7),
                        new Person(8),
                        new Person(9),
                        new Person(10),
                        new Person(11),
                        new Person(12),
                        new Person(13),
                        new Person(14),
                    };
                    tempItems = items3;
                    break;
                default:
                    MessageBox.Show("Not correct number");
                    break;
            }
            #region old
            /*  case 1:
List<Human>TempLeft1 = new List<Human>()
{
    new Human(1),
};

List<Human> TempRight1 = new List<Human>()
{
    new Human(2),
};
LeftNode = TempLeft1;
RightNode = TempRight1;
break;
*/
            /*  case 2:
                  List<Human> TempLeft2 = new List<Human>()
                  {
                      new Human(1),
                      new Human(3),
                      new Human(4),
                  };
                  List<Human> TempRight2 = new List<Human>()
                 {
                      new Human(2),
                      new Human(5),
                      new Human(6),
                  };
                  LeftNode = TempLeft2;
                  RightNode = TempRight2;
                  break;  */
            /* if (LeftNode != null && RightNode != null)
{
    foreach (Human human in LeftNode)
    {
        Console.WriteLine("Left: " + human.Value);
        humanArray.Insert(human.Value, human);
    }
    foreach (Human human in RightNode)
    {
        Console.WriteLine("Right: " + human.Value);
        humanArray.Insert(human.Value, human);
    }
} */


            #endregion
            if (tempItems != null)
            {
                foreach (Person human in tempItems)
                {
                    Console.WriteLine(human.Value);
                    personArray.Insert(human.Value, human);
                }

            }
        }
        public bool IsLeftNode(Person human)
        {
            int[] leftNodeIndexes = { 1, 3, 4, 7, 8, 9, 10, 15, 16, 17, 18, 19, 20, 21, 22 };

            for (int i = 0; i < leftNodeIndexes.Length; i++)
            {
                if (human.Value == leftNodeIndexes[i])
                    return true;
                else
                    return false;
            }
            return false;
        }
        public void ClearTree()
        {
            personArray.Clear();
        }
        public override string ToString()
        {
            string s = null;
            s += $"\n Level of Tree: {this.Level} " + Environment.NewLine;
            foreach (Person person in personArray)
            {
                s += $"\n Person index: {person.Value}" + Environment.NewLine +
                $"\n -- Name: {person.Name}\n" + Environment.NewLine +
                    $"\n -- Last Name: {person.LastName}\n" + Environment.NewLine +
                    $"\n -- Age: {person.Age}\n" + Environment.NewLine +
                    $"\n -- YearOfBirthday: {person.YearOfBirthday}\n" + Environment.NewLine +
                    $"\n -- Place Of birthday: {person.PlaceOfBirthday}\n" + Environment.NewLine +
                    $"\n -- IsDead?: {person.IsDead}\n" + Environment.NewLine +
                    $"\n -- Place Of Death: {person.PlaceOfDeath}\n" + Environment.NewLine +
                    $"\n -- Year of death: {person.YearOfDeath}\n" + Environment.NewLine;
            }
            return s;
        }
    }

}
