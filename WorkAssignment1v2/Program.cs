using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAssignment1
{
    internal class Assignment
    {
        void ListAllValues(string[] names,int arrayLength)
        {

            Console.WriteLine("************Listing All values");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("************ All values Listed");
        }

        void Reverse(string [] names,int arrayLength)
        {
            Console.WriteLine("*********Code to Reverse array");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("*********Code to Reverse array");
        }

        void LastThreeValues(string [] names,int arrayLength)
        {
            Console.WriteLine("************last 3 values**********");
            for (int i = names.Length - 3; i <= names.Length - 1; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("************last 3 values**********");
        }

        void SecondValue(string [] names,int arrayLength)
        {
            Console.WriteLine("*********Second value********");
            Console.WriteLine(names[1]);
            Console.WriteLine("*********Second value********");
        }
        
        void SortAscendingOrder(string [] names,int arrayLength)
        {
            Console.WriteLine("bubble Sort placeholder");
        }

        void TopTwoValues(string [] names,int arrayLength)
        {
            Console.WriteLine("**********Top Two values");
            for (int i = 0; i < names.Length; i++)
            {
                if (i == 2)
                {
                    break;

                }
                Console.WriteLine(names[i]);
            }
            // Console.WriteLine();
            Console.WriteLine("**********Top Two values");
        }

        void VowelsOnly(string [] names,int arrayLength)
        {
            Console.WriteLine("**************vovel start****************");
            foreach (var item in names)
            {
                char[] charName = item.ToCharArray();

                for (int i = 0; i < charName.Length; i++)
                {
                    if (charName[i] == 'a' || charName[i] == 'e' || charName[i] == 'i' || charName[i] == 'o' || charName[i] == 'u')
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
            }
            Console.WriteLine("**************vovel start****************");
        }

        void DuplicateValues(string [] names,int arrayLength)
        {
            int temp = 1;
            Console.WriteLine("**********Dupilicate elements start*************");
            for (int i = 0; i < names.Length; i++)
            {

                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i] == names[j])
                    {

                        if (temp == 1 && names[j] != "")
                        {
                            Console.WriteLine(names[j] + "");
                        }
                        names[j] = "";
                        temp++;
                    }
                }
                temp = 1;
            }
            Console.WriteLine("**********Dupilicate elements end*************");
        }

        void AppExit()
        {
           Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            int selection;
            string input;
            string[] names = new string[10];
            int alength = names.Length;
            Boolean exit = false;

            Assignment assignment = new Assignment();   


            Console.WriteLine("Enter maximum of 10 names");
            for (int i = 0; i < 10; i++)
            {
                names[i] = Console.ReadLine();

            }

            Console.WriteLine("Press 1 to print all the names");
            Console.WriteLine("Press 2 to print all the names in reverse");
            Console.WriteLine("Press 3 to print last 3 names");
            Console.WriteLine("Press 4 to print 2nd name from the list");
            Console.WriteLine("Press 5 to sort in ascending order");
            Console.WriteLine("Press 6 to print first 2 names");
            Console.WriteLine("Press 7 to print all the names that contains vowels");
            Console.WriteLine("Press 8 to print duplicate values");
            Console.WriteLine("Press 9 to exit");

          

            do
            {
                Console.WriteLine("Press appropriate number from above selection:");
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1: assignment.ListAllValues(names,alength);
                        break;
                    case 2: assignment.Reverse(names,alength);
                        break;
                    case 3: assignment.LastThreeValues(names,alength);
                        break;
                    case 4: assignment.SecondValue(names,alength);
                        break;
                    case 5:assignment.SortAscendingOrder(names, alength);
                        break;
                    case 6:assignment.TopTwoValues(names,alength);
                        break;
                    case 7:assignment.VowelsOnly(names,alength);
                        break;
                    case 8:assignment.DuplicateValues(names, alength);
                        break;
                    case 9:assignment.AppExit();
                        break;
                }

            } while (true);

          
/*
            Console.WriteLine("************Listing All values");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("************ All values Listed");

            //Code to reverse
            Console.WriteLine("*********Code to Reverse array");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            //Sorting array in ascending order
            //

            //show last 3 values 3rd logic start
            Console.WriteLine("************last 3 values**********");
            for (int i = names.Length - 3; i <= names.Length - 1; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("************last 3 values**********");
            //show last 3 values 3rd logic end



            //Show 2nd values start
            Console.WriteLine("*********Second value********");
            Console.WriteLine(names[1]);
            Console.WriteLine("*********Second value********");
            //Show 2nd values end


            //Show top two values
            Console.WriteLine("**********Top Two values");
            for (int i = 0; i < names.Length; i++)
            {
                if (i == 2)
                {
                    break;

                }
                Console.WriteLine(names[i]);
            }

            Console.WriteLine();
            Console.WriteLine("**********Top Two values");
            //Show top two values

            //Duplicate Elements start

            int temp = 1;
            Console.WriteLine("**********Dupilicate elements start*************");
            for (int i = 0; i < names.Length; i++)
            {

                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i] == names[j])
                    {

                        //string[] temp = new string[5];
                        // temp[i] = names[j];
                        if (temp == 1 && names[j] != "")
                        {
                            Console.WriteLine(names[j] + "");
                        }
                        names[j] = "";
                        temp++;
                    }
                }
                temp = 1;
            }
            Console.WriteLine("**********Dupilicate elements end*************");

            //Duplicate Elements stop

            //Vovel start
            Console.WriteLine("**************vovel start****************");
            foreach (var item in names)
            {
                char[] charName = item.ToCharArray();

                for (int i = 0; i < charName.Length; i++)
                {
                    if (charName[i] == 'a' || charName[i] == 'e' || charName[i] == 'i' || charName[i] == 'o' || charName[i] == 'u')
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
            }
            Console.WriteLine("**************vovel start****************");
            //Vovel end

            */
           // Console.ReadKey();
        }
    }
}