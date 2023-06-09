﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace Merkle_Hellman
{
    public class MyMerkleHellman
    {
        private readonly Form1 _myFormControl;

        public MyMerkleHellman(Form1 myForm)
        {
            _myFormControl = myForm;

        }

        public List<int> CalculateHardknapsacks(List<int> simlpeknapsacks, int w, int n)
        {
            PrintToScreen("**** Расчет тяжелых рюкзаков ****", Color.Green);
            var res = new List<int>();
            for (int i = 0; i < simlpeknapsacks.Count; i++)
            {
                var h = (simlpeknapsacks[i] * w) % n;
                PrintToScreen(simlpeknapsacks[i] + " * " + w + " mod " + n + " = " + h);
                res.Add(h);
            }
            PrintToScreen("H = [" + string.Join(",", res) + "]");
            PrintToScreen("**************************************", Color.MediumPurple);
            return res;
            // return simlpeknapsacks.Select(h => (h * w) % n).ToList();
        }

        public List<int> EncryptMessage(List<int> hard, string message)
        {
            PrintToScreen("**** Шифрования сообщение ****", Color.Green);
            var m = hard.Count;
            PrintToScreen("**** Разделить сообщение на длину" + m + " ****");
            var list = Split(message.ToList(), m);

            var str = "";
            foreach (var l in list)
            {
                str += string.Join("", l) + "  ";
            }
            PrintToScreen("P = " + str);

            PrintToScreen("**** Отрегулируйте длину вложенного сообщения " + m + " ****");
            var listAdjusted = CheckMessageLength(list, hard.Count);

            var strA = "";
            foreach (var l in listAdjusted)
            {
                strA += string.Join("", l) + "  ";
            }
            PrintToScreen("P = " + strA);

            PrintToScreen("**** Вычисление суммы шифра ****", Color.Green);

            var result = new List<int>();
            foreach (var ele in listAdjusted)
            {
                var count = 0;
                for (var i = 0; i < ele.Count; i++)
                {
                    count += ele[i] * hard[i];
                }
                PrintToScreen(" [" + string.Join(",", ele) + "]" + " * " + " [" + string.Join(",", hard) + "]" + " = " + count);
                result.Add(count);
                //result.Add(hard.Select((t, i) => ele[i] * t).Sum());
            }
            PrintToScreen("Сумма шифра= [" + string.Join(",", result) + "]", Color.Blue);
            PrintToScreen("**************************************", Color.MediumPurple);

            return result;

        }

        // W-1 = (w^n-2)%n
        public int CalculateWinvers(int w, int n)
        {
            PrintToScreen("**** Вычисление W обратного ****", Color.Green);
            PrintToScreen("**** W-1 = (w^n-2)%n ****", Color.DodgerBlue);
            var big = BigInteger.ModPow(w, n - 2, n);
            // var temp = (BigInteger)Math.Pow(w, n - 2);
            //  var wi = (int) (temp%n);
            var wi = (int) big;
            PrintToScreen(" W-1 = " + wi);
            PrintToScreen("**************************************", Color.MediumPurple);
            return wi;
        }

        public List<List<int>> DecryptMessage(List<int> message, int wi, int n, List<int> s)
        {
            PrintToScreen("**** Расшифровывающее сообщение ****", Color.Green);
            var res = new List<List<int>>();
            foreach (var num in message)
            {
                var temp = (num * wi) % n;
                PrintToScreen("(" + num + "*" + wi + ") mod " + n + " = " + temp);
                PrintToScreen("**** Найти сумму сообщения  ****");

                var sumList = FindSum(s, temp);
                var mappedList = MapMessageList(s, sumList);
                PrintToScreen(temp + " > Sum In > " + " [" + string.Join(",", s) + "]" + "==>>" + " [" + string.Join(",", mappedList) + "]");
                res.Add(mappedList);
            }

            var str = "";
            foreach (var l in res)
            {
                str += string.Join("", l);
            }

            PrintToScreen("Открытый текст = [" + str + "]", Color.Blue);
            PrintToScreen("**************************************", Color.MediumPurple);
            return res;
        }

        private void PrintToScreen(string text, Color color = default(Color))
        {
            _myFormControl.Invoke(_myFormControl.UpdateTextBox, text, color); // обновляет текстовое поле №9 в WinForm

        }

        private List<List<int>> CheckMessageLength(List<List<int>> messge, int size)
        {
            foreach (var m in messge.Where(m => size != m.Count))
            {
                for (var i = size - m.Count; i < size; i++)
                {
                    m.Insert(i, 0);
                }
            }
            return messge;
        }

        private List<List<int>> Split(List<char> source, int sub)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / sub)
                .Select(x => x.Select(v => Convert.ToInt32(v.Value.ToString())).ToList())
                .ToList();
        }

        private List<int> MapMessageList(List<int> simple, List<int> sumList)
        {
            var res = new List<int>();
            foreach (var num in simple)
            {
                //var temp = sumList.Any(s => s == num);
                res.Add(sumList.Any(s => s == num) ? 1 : 0);
            }
            return res;
        }
        private List<int> FindSum(List<int> simple, int targetSum, int index = 0)
        {

            for (var i = index; i < simple.Count; i++)
            {
                int remainder = targetSum - simple[i];
                // если текущее число слишком велико для целевого значения, пропустите
                if (remainder < 0)
                    continue;
                // если текущее число является решением, верните список с ним
                if (remainder == 0)
                    return new List<int>() { simple[i] };

                // в противном случае попробуйте найти сумму для остатка позже в списке
                var s = FindSum(simple, remainder, i + 1);

                // если номер не был возвращен, мы не смогли найти решение, поэтому пропустите
                if (s.Count == 0)
                    continue;

                // в противном случае мы нашли решение, поэтому добавьте к нему наш текущий номер и верните результат
                s.Insert(0, simple[i]);
                return s;
            }

            // если мы окажемся здесь, мы проверим все номера в списке и не найдем решения
            return new List<int>();
        }

    }
}