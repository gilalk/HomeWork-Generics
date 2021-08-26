using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Generics
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            #region Q1 implementation

            //int[] n1 = new int[] { 1, 4, 6, 7, 2 };
            //int[] n2 = new int[] { 4, 1, 6, 9, 2, 3, 7 };

            //int[] n3 = Combine(n1, n2);
            //Debug.WriteLine(n3);

            #endregion

            #region Q2 implementation

            //GenericReadOnly<int> genericReadOnly = new GenericReadOnly<int>();
            //genericReadOnly.Add(12);
            //genericReadOnly.Add(34);
            //genericReadOnly.Add(2);
            //genericReadOnly.Add(5);
            //genericReadOnly.Add(87);
            //genericReadOnly.Add(11);
            //genericReadOnly.Switch = true;
            //try
            //{
            //    genericReadOnly.Add(41);
            //}
            //catch (InvalidOperationException)
            //{
            //    Debug.WriteLine("Sorry, switch 'readonly' is on");
            //}

            #endregion

            #region Q3 implementation

            //SortedArr<int> sortedArr = new SortedArr<int>();
            //sortedArr.Add(12);
            //sortedArr.Add(34);
            //sortedArr.Add(1);
            //sortedArr.Add(87);
            //sortedArr.Add(23);

            //SortedArr<char> sortedArrChar = new SortedArr<char>();
            //sortedArrChar.Add('e');
            //sortedArrChar.Add('s');
            //sortedArrChar.Add('g');
            //sortedArrChar.Add('a');
            //sortedArrChar.Add('k');


            #endregion

        }


    }
}
    