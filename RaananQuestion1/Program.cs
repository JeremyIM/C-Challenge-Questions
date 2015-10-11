using System;
using System.Collections.Generic;
using System.Text;

namespace RaananQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuestionOne(); //done
            //QuestionTwo(new int[4][] { new int[6] { 1, 2, 3, 4, 5, 6 }, new int[6] { 7, 8, 9, 10, 11, 12 }, new int[6] { 13, 14, 15, 16, 17, 18 }, new int[6] { 19, 20, 21, 22, 23, 24 } });
            //QuestionThree(); //done
            //QuestionFour("the24Balls",2); 
            Console.Read();
        }

        /// <summary>
        /// <para>Write a function string AddNumbers(string m, int f) that adds numbers in a string to the value of f. E.g. Note that numbers may contain negative signs.</para>
        /// <para>Do not use Regex</para>
        /// </summary>
        /// <example>
        /// AddNumbers ("The24balls.", 2) = "The26balls.
        /// </example>
        private static void QuestionFour(string m, int f)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in m)
            {
                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
            }

            int temp = Convert.ToInt32(sb.ToString());
            m = m.Replace(temp.ToString(), (temp + f).ToString());
            Console.WriteLine(m);
        }

        /// <summary>
        /// <para>There are two classes: Box and Chocolate.Chocolate contains properties Name and Sweetness.Box contains properties Chocolates (list of Chocolates) and Boxes(list of Boxes). </para>
        /// <para>Write a function void Print(Box b) that prints a list of all Chocolate Names with Sweetness rating of 5 within Box b(and all Boxes contained within).</para>
        /// </summary>
        private static void QuestionThree()
        {
            Box b = new Box();
            b.PopulateBoxes();

            foreach (Box box in b.Boxes)
            {
                foreach (Chocolate chocolate in box.Chocolates)
                {
                    if (chocolate.Sweetness == 5)
                    {
                        Console.WriteLine(chocolate.Name);
                    }
                }
            }
        }

        /// <summary>
        /// <para>Write a function void Print(int[][] m) that prints contents of an 2-dimensional array row by row,</para>  
        /// <para> with only the first 3 elements on the even rows printed in reverse.</para>
        /// </summary>
        private static void QuestionTwo(int[][] m)
        {
            // There clearly is a better way to do this.
            for (int i = 0; i < m.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 2; j >= 0; j--)
                    {//first three elements printed in reverse order
                        Console.Write(m[i][j] + " ");
                    }
                    if (m[i].Length > 2)
                    {//if more than three elements, print the rest
                        for (int j = 3; j < m[i].Length; j++)
                        {
                            Console.Write(m[i][j] + " ");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < m[i].Length; j++)
                    {//non even, just print
                        Console.Write(m[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Write a program that prints numbers 100 to 1, skipping numbers that pairs (e.g. 11, 22, 33 etc).
        /// </summary>
        private static void QuestionOne()
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 11 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }

    public class Box
    {
        public Box()
        {
            PopulateBox();
        }

        public void PopulateBoxes()
        {
            Boxes.Add(new Box());
            Boxes.Add(new Box());
            Boxes.Add(new Box());
            Boxes.Add(new Box());
            Boxes.Add(new Box());
        }

        void PopulateBox()
        {
            Chocolates.Add(new Chocolate("SandPop", 2));
            Chocolates.Add(new Chocolate("ToothGlue", 3));
            Chocolates.Add(new Chocolate("Grunk Bar", 6));
            Chocolates.Add(new Chocolate("Homework The Candy", 3));
            Chocolates.Add(new Chocolate("Count Discount", 5));
            Chocolates.Add(new Chocolate("Mr Adequate Bar", 1));
            Chocolates.Add(new Chocolate("Chocolate Coated Turnip", 2));
            Chocolates.Add(new Chocolate("Generico Bar", 3));
            Chocolates.Add(new Chocolate("Reeces Sneezes", 5));
            Chocolates.Add(new Chocolate("Icelandic Liquorice", 8));
        }

        private List<Box> _boxes = new List<Box>();
        public List<Box> Boxes
        {
            get { return _boxes; }
            set { _boxes = value; }
        }

        private List<Chocolate> _chocolates = new List<Chocolate>();
        public List<Chocolate> Chocolates
        {
            get { return _chocolates; }
            set { _chocolates = value; }
        }

    }
    public class Chocolate
    {
        #region Constructor
        public Chocolate() { }
        public Chocolate(string inName, int inSweetness)
        {
            Name = inName;
            Sweetness = inSweetness;
        }
        #endregion

        #region Properties
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        int _sweetness;
        public int Sweetness
        {
            get
            {
                return _sweetness;
            }
            set
            {
                _sweetness = value;
            }
        }
        #endregion
    }
}
