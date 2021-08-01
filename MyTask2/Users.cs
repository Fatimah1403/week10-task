using System;
using MyTask2;

namespace MyTask2
{
    public class Users
    {
        /// <summary>
        /// to validate the users input
        /// </summary>
        /// <param name="data"></param>
        /// <returns> The integer value of the data if valid or -1 if invalid</returns>
        public static int IsValidInput(string data)
        {
            bool isValid = int.TryParse(data, out int value);
            if (!isValid)
                return -1;
            else if (value < 0 || value > 7)
                return -1;
            else
                return value;
        }
        /// <summary>
        /// Executes the Logic relating to the required app
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public static string UserInput(string firstValue, string secondValue)
        {
            try
            {
                var isValidFirstInput = int.TryParse(firstValue, out int FirstInput);
                if (!isValidFirstInput)
                {
                    return "Input is invalid, please enter a valid one";
                }
                var isValidSecondInput = double.TryParse(secondValue, out double secondInput);
                if (!isValidFirstInput)
                {
                    return "Input is invalid, please enter a valid one";
                }
                return "The result is = " + HospitalQueueLogic<string>.Enqueue("", "", "", "");
            }
            catch (ArithmeticException ex)
            {
                throw new ArithmeticException(ex.Message);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }






    }
}