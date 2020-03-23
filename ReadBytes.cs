using System;
using System.Linq;

namespace ReadBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple tiff data
            byte[] bytes = { 0, 254, 0, 155, 0, 125 };

            // If the system architecture is little-endian (that is, little end first),
            // reverse the byte array.
            //if (BitConverter.IsLittleEndian)
            //    Array.Reverse(bytes);

            // If you want to convert only 2 bytes to integer
            //Int16 i = BitConverter.ToInt16(bytes, 0);

            // convert bytes to chars
            //char[] cArray = System.Text.Encoding.ASCII.GetString(bytes).ToCharArray();

            // simple
            int[] bytesAsInts = Array.ConvertAll(bytes, c => (int)c);

            // using linq
            int[] bytesAsInts2 = bytes.Select(x => (int)x).ToArray();
            int[] aEven = bytesAsInts2.Where((x, i) => i % 2 == 0).ToArray();
            int[] aOdd = bytesAsInts2.Where((x, i) => i % 2 != 0).ToArray();
        }
    }
}
