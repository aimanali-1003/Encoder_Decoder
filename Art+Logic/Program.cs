using Art_Logic;

class Program
{
    static void Main()
    {
        string chunk = string.Empty;
        int chunkSize = 0;

        Console.Write("Enter a string: ");
        string? input_string = Console.ReadLine();
        if (string.IsNullOrEmpty(input_string))
        {
            input_string = string.Empty;
        }

        while (input_string.Length > 0)
        {
            if (input_string.Length >= 4)
            {
                chunkSize = Math.Min(4, input_string.Length);
                chunk = input_string.Substring(0, chunkSize);
            }
            else
            {
                chunk = input_string;
                chunkSize = input_string.Length;
            }
            int decimal_code = Encoder.Encode(chunk);
            Decoder.Decode(decimal_code);

            input_string = input_string.Substring(chunkSize);
        }

        // Display the encoded values as an array
        string combinedIntegers = string.Join(",", Encoder.EncodedArray);
        Console.WriteLine($"Encoded: [{combinedIntegers}]");

        // Display the decoded values as a combined string
        string combinedString = string.Join("", Decoder.DecodedArray.ToArray());
        Console.WriteLine("Decoded: " + combinedString);
    }
}