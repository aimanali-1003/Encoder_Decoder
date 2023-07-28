
namespace Utility
{
    public static class Utility
    {
        // Convert a decimal value to binary in Two's Complement format
        public static string DecimalToBinaryTwosComplement(int decimalValue)
        {
            uint uintValue = (uint)decimalValue;
            string binary = Convert.ToString(uintValue, 2).PadLeft(32, '0');
            return binary;
        }
    }
}

