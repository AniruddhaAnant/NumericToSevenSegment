using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;

namespace NumericToSevenSevenSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string line1 = " _ ";

            //string[] lines = { line1, "|_|", "|_|" };

            //File.WriteAllLines("WriteLines.txt", lines);

            if (File.Exists("WriteLines.txt"))
            {
                File.Delete("WriteLines.txt");
            }

            string input = Console.ReadLine();


            StringBuilder line1 = Method1(input);
            StringBuilder line2 = Method2(input);
            StringBuilder line3 = Method3(input);

            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            string[] lines = { line1.ToString(), line2.ToString(), line3.ToString() };

            //string[] lines = { "a","b", "c"};

            File.WriteAllLines("WriteLines.txt", lines);

       

            // File.WriteAllText("WriteLines.txt", line1.ToString());
            // File.AppendAllText("WriteLines.txt", line2.ToString());
            // File.AppendAllText("WriteLines.txt", line3.ToString());


            //for (int i = 0; i < length; i++)
            //{
            //    var element = input[i];
            //    var line1 = WriteFirstLine(element);
            //    var line2 = WriteSecondLine(element);
            //    var line3 = WriteThirdLine(element);


            //    string[] lines = { line1, line2, line3 };

            //    File.WriteAllLines("WriteLines.txt", lines);
            //    //Console.WriteLine("Input is {0}", element);
            //}

        }

        private static StringBuilder Method1(string input)
        {
            StringBuilder line = new StringBuilder();
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                var element = input[i];
                string line1 = WriteFirstLine(element);
                var line3 = line.Append(line1);

                line = line3;
            }
            return line;
        }

        private static StringBuilder Method2(string input)
        {
            StringBuilder line = new StringBuilder();
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                var element = input[i];
                string line2 = WriteSecondLine(element);
                //line.Append(line2);
                var line3 = line.Append(line2);

                line = line3;
            }
            return line;
        }

        private static StringBuilder Method3(string input)
        {
            StringBuilder line = new StringBuilder();
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                var element = input[i];
                string line3 = WriteThirdLine(element);
                //line.Append(line3);
                var line4 = line.Append(line3);

                line = line4;
            }
            return line;
        }

        private static string WriteThirdLine(char element)
        {
            string[] lines = GenerateData(element);

            return lines[2];
        }

        private static string WriteSecondLine(char element)
        {
            string[] lines = GenerateData(element);

            return lines[1];
        }

        private static string WriteFirstLine(char element)
        {
            string[] lines = GenerateData(element);

            return lines[0];
        }

        private static string[] GenerateData(char element)
        {
            string[] lines = null;

            switch (element)
            {
                case '1':
                    string[] line1 = Data1();
                    return line1;

                case '2':
                    string[] line2 = Data2();
                    return line2;
                case '3':
                    string[] line3 = Data3();
                    return line3;

                case '4':
                    string[] line4 = Data4();
                    return line4;

                case '5':
                    string[] line5 = Data5();
                    return line5;

                case '6':
                    string[] line6 = Data6();
                    return line6;

                case '7':
                    string[] line7 = Data7();
                    return line7;

                case '8':
                    string[] line8 = Data8();
                    return line8;


                case '9':
                    string[] line9 = Data9();
                    return line9;

                case '0':
                    string[] line0 = Data0();
                    return line0;

            }
            return lines;

        }

        private static string[] Data0()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append('_');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append('|');
            var e = d.Append(' ');
            var f = e.Append('|');

            var builder3 = new StringBuilder();
            var g = builder3.Append('|');
            var h = g.Append('_');
            var i = h.Append('|');


            string[] lines = { c.ToString(), f.ToString(), i.ToString() };

            return lines;
        }

        private static string[] Data9()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append('_');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append('|');
            var e = d.Append('_');
            var f = e.Append('|');

            var builder3 = new StringBuilder();
            var g = builder3.Append(' ');
            var h = g.Append('_');
            var i = h.Append('|');


            string[] lines = { c.ToString(), f.ToString(), i.ToString() };

            return lines;
        }

        private static string[] Data8()
        {

            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append('_');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append('|');
            var e = d.Append('_');
            var f = e.Append('|');


            string[] lines = { c.ToString(), f.ToString(), f.ToString() };

            return lines;

            //File.AppendAllText("WriteLines.txt", lines[0]);
            //File.AppendAllText("WriteLines.txt", lines[1]);

            //File.AppendAllText("WriteLines.txt", lines[2]);
            //File.AppendAllText("WriteLines.txt", Environment.NewLine);


            //File.WriteAllLines("WriteLines.txt", lines);
        }

        private static string[] Data7()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append('_');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append(' ');
            var e = d.Append(' ');
            var f = e.Append('|');

            string[] lines = { c.ToString(), f.ToString(), f.ToString() };

            return lines;
        }

        private static string[] Data6()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append('_');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append('|');
            var e = d.Append('_');
            var f = e.Append(' ');

            var builder3 = new StringBuilder();
            var g = builder3.Append('|');
            var h = g.Append('_');
            var i = h.Append('|');


            string[] lines = { c.ToString(), f.ToString(), i.ToString() };

            return lines;
        }

        private static string[] Data5()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append('_');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append('|');
            var e = d.Append('_');
            var f = e.Append(' ');

            var builder3 = new StringBuilder();
            var g = builder3.Append(' ');
            var h = g.Append('_');
            var i = h.Append('|');


            string[] lines = { c.ToString(), f.ToString(), i.ToString() };

            return lines;

        }

        private static string[] Data4()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append(' ');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append('|');
            var e = d.Append('_');
            var f = e.Append('|');

            var builder3 = new StringBuilder();
            var g = builder3.Append(' ');
            var h = g.Append(' ');
            var i = h.Append('|');


            string[] lines = { c.ToString(), f.ToString(), i.ToString() };

            return lines;
        }

        private static string[] Data3()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append('_');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append(' ');
            var e = d.Append('_');
            var f = e.Append('|');

            string[] lines = { c.ToString(), f.ToString(), f.ToString() };

            return lines;
        }

        private static string[] Data2()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append('_');
            var c = b.Append(' ');

            var builder2 = new StringBuilder();
            var d = builder2.Append(' ');
            var e = d.Append('_');
            var f = e.Append('|');

            var builder3 = new StringBuilder();
            var g = builder3.Append('|');
            var h = g.Append('_');
            var i = h.Append(' ');


            string[] lines = { c.ToString(), f.ToString(), i.ToString() };

            return lines;

        }

        private static string[] Data1()
        {
            var builder1 = new StringBuilder();
            var a = builder1.Append(' ');
            var b = a.Append(' ');
            var c = b.Append(' ');


            var builder2 = new StringBuilder();
            var d = builder2.Append(' ');
            var e = d.Append(' ');
            var f = e.Append('|');


            string[] lines = { c.ToString(), f.ToString(), f.ToString() };

            return lines;


            // File.WriteAllLines("WriteLines.txt", lines);
            //File.Open("WriteLines.txt", FileMode.Open);

        }
    }
}

//#region
////var builder3 = new StringBuilder();
////var g = builder2.Append(' ');
////var h = g.Append(' ');
////var i = e.Append('|');




////string line1 = string.Empty;
////string line21 = line1.Append(' ').ToString();
////string line22 = line21.Append(' ').ToString(); ;
////string line23 = line22.Append('|').ToString();
////var line24 = line23.ToString();

////string line3 = string.Empty;
////line3.Insert(0, 'g'.ToString());
////line3.Insert(1, 'h'.ToString());
////line3.Insert(2, 'i'.ToString());

////string line2 = string.Empty;
////string line31 = line2.Append(' ').ToString();
////string line32 = line21.Append(' ').ToString(); ;
////string line33 = line22.Append('|').ToString();
////var line34 = line23;
//#endregion