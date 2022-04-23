using System;
using System.Text;

namespace Ref_Out_Extension
{
    static class Program
    {
        static void Main(string[] args)
        {
            #region ref,out
            //int[] nums = { 1, 3, 5 };
            //int num = 7;
            //ArrayExtend(ref nums, num);
            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //string name = "Hikmet Abbasov";
            //Elovset (ref name);
            //Console.WriteLine(name);
            #endregion
            #region Extension


            string text = "exTensiON claSSi staTIc OLMalIdiR";
           Console.WriteLine( text.Capitalize());
            #endregion
        }
        #region ref,out
        //static void ArrayExtend(ref int[] nums,int num)
        //{
        //    Array.Resize(ref nums, nums.Length + 1);
        //    nums[nums.Length - 1] = num;
        //}
        //static void Elovset(ref string text)
        //{
        //    string newText = "";
        //    foreach (var item in text)
        //    {
        //        //if(item ==' ')
        //        //{
        //        //    continue;
        //        //}
        //        //else
        //        //{
        //        //    newText += item;
        //        //}
        //        if(item!=' ')
        //        {
        //            newText += item;
        //        }
        //    }
        //    text = newText;

        //}
        //static StringBuilder Space(ref string text)
        //{
        //    StringBuilder result = new StringBuilder();
        //    foreach (var item in text)
        //    {
        //        if(item!=' ')
        //        {
        //            result.Append(item);
        //        }
        //    }
        //    text = result.ToString();
        //    return result;
        //}
        #endregion
        #region Extension


        static string Capitalize(this string text)
        {
            string newText = "";
            string result = "";
            foreach (var item in text)
            {
                newText += char.ToLower(item);
            }
            //exTensiON claSSi staTIc OLMalIdiR
            result += char.ToUpper(newText[0]);
            for (int i = 1; i < newText.Length; i++)
            {
                if(newText[i]==' ')
                {
                    result += newText[i];
                    result += char.ToUpper(newText[i+1]);
                    i++;
                }
                else
                {
                    result += newText[i];
                }
            }
            return result;
        }
        #endregion

    }
}
