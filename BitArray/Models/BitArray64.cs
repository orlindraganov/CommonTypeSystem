namespace BitArray.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    using Students.Common;

    public class BitArray64 : IEnumerable<int>
    {
        #region Fields, Ctors, Props
        private const int Length = 64;
        private int[] bits = new int[Length];

        public BitArray64(ulong number)
        {
            string bin = ConvertDecToBin(number);
            this.bits = BitsToArr(bin);
        }

        public int this[int index]
        {
            get
            {
                //Next time Validator lives on his own out of the projects
                Validator.ValidateRange(index, 0, this.bits.Length - 1);
                return this.bits[index];
            }
        }
        #endregion

        #region Methods
        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return (first.Equals(second));
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first.Equals(second));
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var otherArr = obj as BitArray64;

            for (int i = 0; i < Length; i++)
            {
                if (!otherArr[i].Equals(this[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.bits);
        }

        private static string ConvertDecToBin(ulong dec)
        {
            StringBuilder bin = new StringBuilder();

            do
            {
                bin.Insert(0, dec % 2);
                dec = dec / 2;
            }

            while (dec != 0);

            return bin.ToString();
        }

        private static int[] BitsToArr(string bin)
        {
            int[] bitArr = new int[Length];
            while (bin.Length < 64)
            {
                bin = bin.Insert(0, "0");
            }
            Validator.ValidateStringLength(bin, Length, "Bits as string");
            for (int i = 0; i < Length; i++)
            {
                bitArr[i] = int.Parse(bin[i].ToString());
            }
            return bitArr;
        }


        #endregion
    }
}