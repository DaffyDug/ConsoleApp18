using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, int> arr1 = new Dictionary<int, int>();
            //Dictionary<char, char> arr2 = new Dictionary<char, char>();
            //Dictionary<bool, bool> arr3 = new Dictionary<bool, bool>();
            //arr1.TryAdd(12, 23);
            //arr1.TryAdd(1122, 232);
            //arr2.TryAdd('e', 'f');
            //arr2.TryAdd('y', 'v');
            //arr3.TryAdd(true, false);
            //arr3.TryAdd(false, true);
            InputHelper.Input("введите число ", 1, 5, out int value);
        }
    }

    public static class InputHelper
    {
        public static bool Input(string _text, int _min, int _max, out int inputValue)
        {
            bool result = false;
            Console.WriteLine(_text);
            string InputValue = Console.ReadLine();
            inputValue = int.Parse(InputValue);

            if (inputValue >= _min || inputValue <= _max)
            {
                Console.WriteLine("Твое число "+ inputValue);
                result = true;
            }
            else
            {
                Console.WriteLine("Ошибка");
                result = true;
            }
            return result;
        }
    }
}