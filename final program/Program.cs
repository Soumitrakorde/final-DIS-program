using System;

namespace final_program
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Enter numbers :");
                string input_1 = Console.ReadLine();
                int number = Convert.ToInt32(input_1);
                PrintPattern(number);
            //--------------------------------------------

                Console.WriteLine("Enter the number of terms of series");
                string n_term = Console.ReadLine();
                int n2 = Convert.ToInt32(n_term);
                PrintSeries(n2);
                Console.WriteLine("\n");

            //----------------------------------------

                
          
             Console.WriteLine("Enter Time in AM/PM format");
             string string_time = Console.ReadLine();
            
             Program.UsfTime(string_time);


            //------------------------------------------- 
            Console.Write("Output of USFNumbers method is");
                Console.WriteLine("\n");
                USFNumbers(110, 11);
             //--------------------
                Console.Write("Output of PalindromePairs method is");
                Console.WriteLine("\n");
                string m = "ssslllls";
                Console.WriteLine(PalindromeCheck(m));
                string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
                PalindromePairs(words);

            }

            //----------------------------------------method 1------------------------//----------------
            private static void PrintPattern(int num)
            {
                for (int i = num; i >= 1; i--)
                {
                    

                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine("\n");


                }
            }

            // ------------------------------------ //Method 2---------------------------------------
            private static void PrintSeries(int n2)
            {
                int sum = 0;
                for (int i = 1; i <= n2; i++)
                {
                    sum = sum + i;
                    Console.Write(sum);
                    
                }
            Console.WriteLine("\nEnd of Series");
            }
        // ------------------------------------ //Method 3---------------------------------------

        public static void UsfTime(string s)
        {
           
            DateTime Eatime = Convert.ToDateTime(s);
            Console.WriteLine("You have enetered the time :" + Eatime.ToLongTimeString());
            int InHour = Eatime.Hour;
            if (InHour.ToString("tt") == "AM" || InHour.ToString("tt") == "am")
            {
                InHour = InHour + 0;
            }
            else if (InHour.ToString("tt") == "PM" || InHour.ToString("tt") == "pm")
            {
                InHour = InHour + 12;
            }

            int Secondone = InHour * 60 * 60;
            int Inpmin = Eatime.Minute;
            int Secondtwo = Inpmin * 60;
            int Secondthree = Eatime.Second;
            int TotalSecond = Secondone + Secondtwo + Secondthree;
            double USFSec = TotalSecond / 45;
            double USFMin = USFSec / 60;
            decimal USFMIN = Convert.ToDecimal(USFMin);
            decimal USFHour = decimal.Truncate(USFMIN);
            String HOUR = Convert.ToString(USFHour);
            Console.WriteLine("The hours of USF WROLD ARE:" + USFHour);
            decimal USFMIN1 = USFMIN - Math.Truncate(USFMIN);
            decimal USFMINS = USFMIN1 * 60;
            decimal USFMINSFINAL = decimal.Truncate(USFMINS);
            String MIN = Convert.ToString(USFMINSFINAL);
            Console.WriteLine(USFMINSFINAL);
            decimal USFSEC = USFMINS - Math.Truncate(USFMINS);
            decimal USFSEC1 = USFSEC * 45;
            decimal USFSECFINAL = decimal.Truncate(USFSEC1);
            String SECONDS = Convert.ToString(USFSECFINAL);
            Console.WriteLine(USFSECFINAL);
            Console.WriteLine(HOUR + ':' + MIN + ':' + SECONDS);
         
        }

        // ------------------------------------ //Method 4---------------------------------------
        public static void USFNumbers(int n, int k)
            {
                int ctr = 1;
            //Using the nested if-else.
                for (int i = 1; i <= n; i++)
                {
                    if ((i % 3 == 0) && (i % 5 == 0) && (i % 7 == 0))
                    {
                        Console.Write("USF");
                        Console.Write(",");
                    }
                    else if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        Console.Write("US");
                        Console.Write(",");
                    }
                    else if ((i % 3 == 0) && (i % 7 == 0))
                    {
                        Console.Write("UF");
                        Console.Write(",");
                    }
                    else if ((i % 5 == 0) && (i % 7 == 0))
                    {
                        Console.Write("SF");
                        Console.Write(",");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("U");
                        Console.Write(",");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("S");
                        Console.Write(",");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write("F");
                        Console.Write(",");
                    }
                    else
                    {
                        Console.Write(i);
                        Console.Write(",");
                    }
                    if (ctr == k)
                    {
                        ctr = 0;
                        Console.WriteLine("\n");
                     
                    }
                    ctr++;
                }
            }
        // ------------------------------------ //Method 5---------------------------------------
        public static void PalindromePairs(string[] words)
            {
                int length = words.Length;
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        string joint = words[i] + words[j];
                        bool outputPalindrome = PalindromeCheck(joint);
                        if (outputPalindrome == true)
                        {
                            Console.WriteLine("output array index - [{0},{1}]", i, j);
                            Console.WriteLine("\n");
                        }
                    }
                    

                }
            }
            public static bool PalindromeCheck(string s)
            {
                int a = 0;
                int b = s.Length - 1;
                //This loop checks the string input from both ends.
                while (true)
                {
                    if (a > b)
                    {
                        return true;
                    }
                    char m = s[a];
                    char n = s[b];
                    //This condition checks whether two strings created in above are equal or not
                    if (char.ToLower(m) != char.ToLower(n))
                    {
                        return false;
                    }
                    a++;
                    b--;
                }
                
            }
        
    }
}
    

