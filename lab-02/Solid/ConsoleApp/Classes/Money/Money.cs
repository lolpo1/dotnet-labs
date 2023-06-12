using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.MoneyPart
{
    //dependency inversion principle
    //Абстракція не повинна бути залежна від деталей, деталі повинні бути залежні від абстракції.
  
    public abstract class Money : IMoney
    {
        public abstract string Name { set; get; }
        public abstract char Sign { set; get; }

        public string IntPart { set; get; } = "0";
        public string FractionPart { set; get; } = "0";

        public Money(string num)
        {
            double doublNum = double.Parse(num);
            if (FractionPartValidation(doublNum))
            { 
                this.WriteMoney(num);
            }

        }

        public Money(Money obj) {
            IntPart = obj.IntPart;
            FractionPart = obj.FractionPart;
            Name = obj.Name;
            Sign = obj.Sign;
        }
        public Money() { }

        public void Subtruct(double num)
        {
            if (this.FractionPartValidation(num))
            {
                Console.WriteLine($"Price minus {num}");

                double current = double.Parse($"{this.IntPart},{this.FractionPart}");
                double temp = current - num;
                if (temp <= 0)
                {
                    this.WriteMoney("0");
                }
                else
                {
                    this.WriteMoney(Math.Round(temp, 2).ToString());
                }
            }
        }

        public string GetTotalInString()
        {
            return $"{this.IntPart},{this.FractionPart}";
        }

        public void WriteMoney(string num)
        {
            string[] parts = num.Split(",");
            this.IntPart = parts[0];
            try
            {
                this.FractionPart = parts[1];
                if (this.FractionPart.Length == 1)
                {
                    int temp = int.Parse(this.FractionPart);
                    this.FractionPart = (temp * 10).ToString();
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                this.FractionPart = "0";
            }
        }

        public bool FractionPartValidation(double num)
        //частина з копійками не може записуватись з 1 цифрою
        //Правильний варіант: 0,01 або 0,10
        {
            string[] parts = num.ToString().Split(',');
            bool flag = false;
            if (parts.Length == 2)
            {
                string fractionPart = parts[1];
                if (fractionPart.Length == 2)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Fraction must be written into 2 digits, like: 0,01 or 0,10");
                    flag = false;
                }

            }
            if (parts.Length == 1)
            {
                flag = true;
            }
            return flag;
        }

        public void EnterIntPart(string num)
        {
            IntPart = num;
        }
        public void EnterFractionPart(string num)
        {
            FractionPart = num;
        }
        public abstract void ShowValue();
    }
}
