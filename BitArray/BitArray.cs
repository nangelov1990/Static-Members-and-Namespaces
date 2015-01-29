namespace BitArray
{
    using System;
    using System.Numerics;

    public class BitArray
    {
        private readonly uint _bitsCount;
        private string[] _bitValues;
        private const int MaxSize = 100000;

        public BitArray(uint bitCount)
        {
            this._bitsCount = bitCount;
            CreateBitArray(BitsCount);
        }

        private void CreateBitArray(uint bitCount)
        {
            if (bitCount <= MaxSize)
            {
                BitValues = new string[bitCount];

                for (uint i = 0; i < bitCount; i++)
                {
                    this.BitValues[i] = "0";
                }
            }
            else
            {
                throw new IndexOutOfRangeException(String.Format(
                        "Size {0} is invalid!",
                        bitCount));
            }
        }

        private uint BitsCount
        {
            get { return this._bitsCount; }
        }

        private string[] BitValues
        {
            get { return this._bitValues; }
            set { this._bitValues = value; }
        }

        // Indexer declaration
        public byte this[uint index]
        {
            get
            {
                if (index < BitsCount)
                {
                    return byte.Parse(this.BitValues[index]);
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!",
                        index));
                }

                
            }

            set
            {
                if (index > BitsCount - 1)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!",
                        index));
                }
                if (value > 1)
                {
                    throw new ArgumentException(String.Format(
                        "Value {0} is invalid!",
                        value));
                }

                this.BitValues.SetValue(value.ToString(), index);
            }
        }

        private BigInteger CalculateValue()
        {
            BigInteger output = 0;

            for (int i = 0; i < this._bitsCount; i++)
            {
                if (BitValues[i] == "1")
                {
                    output += BigInteger.Pow(2, i);
                }
            }

            return output;
        }

        public override string ToString()
        {
            return CalculateValue().ToString();
        }
    }
}
