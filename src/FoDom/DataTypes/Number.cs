﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
namespace Fonet.DataTypes
{
    public class Number
    {
        private decimal value;

        public Number(int n)
        {
            value = n;
        }

        public Number(decimal n)
        {
            value = n;
        }

        public Number(double n)
        {
            value = (decimal)n;
        }

        public int IntValue()
        {
            return (int)value;
        }

        public double DoubleValue()
        {
            return (double)value;
        }

        public float FloatValue()
        {
            return (float)value;
        }

        public decimal DecimalValue()
        {
            return value;
        }
    }
}