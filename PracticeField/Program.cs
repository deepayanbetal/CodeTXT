using System;


namespace PracticeField
{
    
    public class CodeForces
    {
       

        public static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "bce";

            int len1 = word1.Length;
            int len2 = word2.Length;

            if(len1==len2)
            {
                char[] char1 = word1.ToCharArray();
                char[] char2 = word2.ToCharArray();

                Array.Sort(char1);
                Array.Sort(char2);

                for(int i=0;i<=len1-1;i++)
                {
                    if (char1[i] == char2[i])
                    {
                        Console.WriteLine("permutation");
                    }
                    else
                        Console.WriteLine("not");
                }

            }



        }
    }
}



//https://www.geeksforgeeks.org/browserstack-placement-paper/?ref=lbp

