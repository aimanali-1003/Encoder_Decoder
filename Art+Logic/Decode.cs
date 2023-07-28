using System;
using System.Collections.Generic;
using Utility;

namespace Art_Logic { 
    public static class Decoder
    {
        public static List<string> DecodedArray = new List<string>();
        public static void Decode(int decimal_code)
        {
            string binary = Utility.Utility.DecimalToBinaryTwosComplement(decimal_code);
            string[] decoded_codes = new string[4];
            int decode_array_index = 0;
            foreach (char item in binary)
            {
                decoded_codes[decode_array_index] += item;
                decode_array_index = (decode_array_index + 1) % 4;
            }

            // Convert each binary to hexadecimal representation
            string[] hexa_codes = new string[4];
            for (int i = 0; i < decoded_codes.Length; i++)
            {
                int decimal_value = Convert.ToInt32(decoded_codes[i], 2);
                string hex_val = decimal_value.ToString("X2");
                hexa_codes[i] = "0x" + hex_val;
            }

            Array.Reverse(hexa_codes);

            // Convert hexadecimal codes to characters and create the decoded string
            string decoded_string = "";
            foreach (string hex_val in hexa_codes)
            {
                int decimal_code_value = Convert.ToInt32(hex_val.Substring(2), 16);
                if (decimal_code_value != 0)
                {
                    decoded_string += (char)decimal_code_value;
                }
            }

            DecodedArray.Add(decoded_string);
        }
    }

}
