using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1;
            String str2;
            Console.WriteLine("Enter string № 1");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter string № 2");
            str2 = Console.ReadLine();

            

            List<char> uniqeCharStr1 = new List<char>();
           List<char> uniqeCharStr2 = new List<char>();

            void CreateUniqeListFromString(String inputString, List<char> uniqeList)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    char[] s = inputString.ToCharArray();
                    if (uniqeList.Count == 0)
                    {
                        uniqeList.Add(s[i]);
                    }
                    else
                    {
                        for (int j = 0; j < uniqeList.Count; j++)
                        {

                            if (s[i] == uniqeList[j])
                            {
                                break;
                            }
                            if (j == uniqeList.Count - 1)
                            {
                                uniqeList.Add(s[i]);
                            }

                        }
                    }
                }
                
            }
            void ClearVector(List<char> listWhichCleaning)
            {
                int listSize = listWhichCleaning.Count;
                for (int i =0; i < listSize; i++)
                {
                    listWhichCleaning.RemoveAt(0);
                    
                }
            }

            bool IfString1ContainString2(string string1,string string2)
            {
                bool ifHave = true; ;
                CreateUniqeListFromString(string1, uniqeCharStr1);
                CreateUniqeListFromString(string2,
                    uniqeCharStr2);
                int notSame= 0;
                if (uniqeCharStr2.Count == 0)
                {
                    ifHave = true;
                }
                else
                {
                    for (int i = 0; i < uniqeCharStr2.Count; i++)
                    {
                        for (int j = 0; j < uniqeCharStr1.Count; j++)
                        {
                            if (uniqeCharStr2[i] == uniqeCharStr1[j])
                            {
                                notSame = 0;
                                break;
                            }
                            else
                            {
                                notSame = notSame + 1;
                            }
                            
                        }
                        if(notSame == uniqeCharStr1.Count)
                        {
                            ifHave = false;
                            break;
                        }
                    }
                }
                ClearVector(uniqeCharStr1);
                ClearVector(uniqeCharStr2);
                return ifHave;
            }

            void СhangeSameSymbolsString1(string string1, string string2)
            {

                char[] s1 = string1.ToCharArray();
                char[] s2 = string2.ToCharArray();
                for (int i = 0; i < string2.Length; i++)
                {
                    for (int j = 0; j < string1.Length; j++)
                    {
                        if (s2[i] == s1[j])
                        {
                            s1[j] = '#';


                        }
                    }
                }
            
                Console.WriteLine("New String 1 are looking as  ");
                for (int i = 0; i < str1.Length; i++)
                {
                    Console.Write(s1[i]);
                }
            }

         
            int CountRepetition(string string1, string string2)
            {
                string temp = string1.Replace(str2, "");
                int result = (str1.Length - temp.Length) / str2.Length;
                return result;


            }

            Console.WriteLine();
            if (IfString1ContainString2(str1, str2))
            {
                Console.WriteLine("String №1 contains symbol of String № 2");
            }
            else
            {
                Console.WriteLine("String №1 not contain String № 2");
            }
            Console.WriteLine();
            СhangeSameSymbolsString1(str1, str2);
            Console.WriteLine();
            if (CountRepetition(str1, str2) == 0)
            {
                Console.WriteLine("String №2 not occur in String № 1");
            }
            else
            {
                Console.WriteLine($"String №2  occurs in String № 1 - {CountRepetition(str1, str2)}  times");
            }
        





            Console.ReadKey();


        }
    }
}
