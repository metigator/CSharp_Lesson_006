namespace Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Expression Types
            //1. Primary Expression

            var amount = Math.Cos(30) + 1;
            Console.WriteLine(amount);  // 1,154251449887584

            //2. Void Expression

            Console.WriteLine("Issam");

            //3. Assignment statement
            var x = 2;
            var y = 5;

            // Binary Operators and precedence

            x = x + 10;            // 12
            var z = 8 / 4 / 2;     // 1
            var k = 8 / (4 / 2);   // 4

            Console.WriteLine($"x + y = {x + y}");
            Console.WriteLine($"x - y = {x - y}");
            Console.WriteLine($"x / y = {x / y}");
            Console.WriteLine($"x * y = {x * y}");
            Console.WriteLine($"x % y = {x % y}");

            var s1 = "";
            var s2 = "";
            var s3 = s1 = s2 = "Issam";

            // Null coalescing Operator ??

            string s4 = null;

            s4 = s4 ?? "Issam";

            Console.WriteLine(s4);   // Issam
            s4 = s4 ?? "someone else";

            Console.WriteLine(s4);   // Issam

            //Null conditional ? 

            string s5 = null;

            var s6 = s5?.ToUpper();  // null
            // or
            s6 = s5 is null ? null : s5.ToUpper(); // null

            // Statement vs Statement blocks


            Console.WriteLine("hi");    // Statement
            {                            // Statement block
                Console.WriteLine("hi");
                Console.WriteLine("hi");
            }

            // Declaration Statement 
            int a;

            //--- Expression Statement
            var name = "Issam";

            //1. change state

            name = name + "A";

            //2. call something that change the state

            name = name.ToUpper();

            //3. Assignment

            name = name + "A";

            //4. Increment / decrement

            var totalFriends = 150;
            ++totalFriends;   // 151

            --totalFriends;   // 150

            var x1 = 2;
            Console.WriteLine(x1++);  // 2;
            Console.WriteLine(x1);  // 3;


            // 5. Object instansiation

            object o = new object();

            // Selection statement if, if else switch
            //1.if

            var mark = 90;
            if (mark >= 85)
                Console.WriteLine("Excellent");

            //2.if else

            var mark1 = 55;
            if (mark1 >= 60)
            {
                Console.WriteLine("pass");
            }
            else if (mark1 >= 55)
            {
                Console.WriteLine("you have a chance in a make up exam");
            }
            else
            {
                Console.WriteLine("fail");
            }

            //3. switch

            var amountJOD = 100;
            var currType = "USD";
            var output = 0d;

            //  JOD -> USD = 1.41, JOD -> EUR = 119, JOD -> CAD = 178
            var JODTOUSD = 1.41d;
            var JODTOEUR = 1.19d;
            var JODTOCAD = 1.78d;

            switch (currType)
            {
                case "USD":
                    output = amountJOD * JODTOUSD;
                    Console.WriteLine($"{amountJOD} JOD  = {output} USD");
                    break;
                case "EUR":
                    output = amountJOD * JODTOEUR;
                    Console.WriteLine($"{amountJOD} JOD  = {output} EUR");
                    break;
                case "CAD":
                    output = amountJOD * JODTOCAD;
                    Console.WriteLine($"{amountJOD} JOD  = {output} CAD");
                    break;
                default:
                    Console.WriteLine("Uknown currency type");
                    break;
            }

            // one value execute the same statement
            var num = 3;
            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("odd");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("even");
                    break;
            }

            //

            object o1 = 3;
            switch (o1)
            {
                case int i:
                    Console.WriteLine($"It's int,  sqr of{i}={i * i}");
                    break;
                case string i:
                    Console.WriteLine($"It's string ,capitalization of {i} = {i.ToUpper()}");
                    break;
            }

            //

            bool isVip = true;
            switch (isVip)
            {
                case bool s when s == true:
                    Console.WriteLine("yes");
                    break;
                case bool s:
                    Console.WriteLine("no");
                    break;
            }

            // Switch Expression

            var cardNo = 13;
            string cardName = cardNo switch
            {
                1 => "ACE",
                13 => "KING",
                12 => "QUEEN",
                10 => "JACK",
                _ => cardNo.ToString()
            };
            Console.WriteLine(cardName); // KING

            //Iterations while, do while, for, foreach
            //1. while
            var counter = 0;
            while (counter < 10)
            {
                Console.Write(counter + " ");
                ++counter;
            }
            counter = 0;
            Console.WriteLine();
            //2.do while

            do
            {
                Console.Write(counter + " ");
                ++counter;
            } while (counter < 10);

            Console.WriteLine();
            //3. for

            for (var count = 0; count < 10; count++)
            {
                Console.Write(count + " ");
            }

            Console.WriteLine();

            //Fibonacci [0,1,1,2,3,5,8,13,21,34]

            for (int count = 0, prev = 0, current = 1; count < 10; ++count)
            {
                Console.Write(prev + " ");
                int newFib = prev + current;
                prev = current;
                current = newFib;
            }

            // for(; ; )     // infinite loop      
            //  {
            //    Console.WriteLine("");
            //  }
            Console.WriteLine();

            //4. foreach

            foreach (char c in "Full stack Devoloper course")
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            var arr = new int[] { 1, 2, 3 };
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            // =
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            // Jump statement [break, continue, goto, return]

            //1. break

            var j = 0;
            while (j < 10)
            {
                if (j > 5)
                    break;
                Console.Write(j + " ");
                ++j;
            }
            Console.WriteLine();
            //2. continue

            for (int i = 0; i < 10; ++i)
            {
                if (i % 2 == 0)
                    continue;
                Console.Write(i + " ");
            }

            Console.WriteLine();
            //3. goto

            var u = 0;
            start:
            if (u < 5)
            {
                Console.Write(u + " ");
                ++u;
                goto start;
            }

            Console.WriteLine();

            //4. return

            var input = .44m;
            var result = AsPercentage(input);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        // 0.44 -> 44
        static decimal AsPercentage(decimal amount)
        {
            return amount * 100;
        }
    }
}