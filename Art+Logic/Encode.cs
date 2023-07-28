using System;
using System.Collections.Generic;

namespace Art_Logic
{
    public static class Encoder
    {
        public static List<int> EncodedArray = new List<int>();
        public static int Encode(string chunks)
        {
            string[] hex_codes = new string[4];
            for (int i = 0; i < 4; i++)
            {
                // Convert each character to hexadecimal representation
                if (i < chunks.Length)
                {
                    char character = chunks[i];
                    string hex_val = ((int)character).ToString("X2");
                    hex_codes[i] = "0x" + hex_val;
                }
                else
                {
                    hex_codes[i] = "0x00";
                }
            }

            // Convert each hexadecimal to binary representation
            string[] binary_codes = new string[4];
            for (int i = 0; i < hex_codes.Length; i++)
            {
                string hex_val = hex_codes[i];
                int decimal_value = int.Parse(hex_val.Substring(2), System.Globalization.NumberStyles.HexNumber);
                string binary_code = Convert.ToString(decimal_value, 2).PadLeft(8, '0');
                binary_codes[i] = binary_code;
            }

            Array.Reverse(binary_codes);

            // Concatenate the binary codes to get the final encoded value
            string[] Encoded = new string[32];
            string encoded_value = "";
            int index = 0;
            int string_index = 0;
            for (int iteration = 1; iteration <= 32; iteration++)
            {
                encoded_value += binary_codes[index][string_index];
                if (iteration % 8 == 0)
                {
                    Encoded[iteration / 8 - 1] = encoded_value;
                    encoded_value = "";
                }
                index = (index + 1) % 4;
                if (index == 0)
                {
                    string_index += 1;
                }
            }

            // Convert concatenated binary to decimal
            string concatenated_binary = string.Join("", Encoded);
            int decimal_code = Convert.ToInt32(concatenated_binary, 2);
            string hex_val_result = decimal_code.ToString("X8");

            // Add the decimal code to the EncodedArray
            EncodedArray.Add(decimal_code);

            return decimal_code;
        }

    }
}
