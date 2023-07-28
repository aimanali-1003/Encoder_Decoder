# Art+Logic Encoder and Decoder

## Description

The Encoding and Decoding Utility is a C# console application that provides functionalities to encode and decode strings. The main purpose of this project is to convert a given string into a binary representation using a custom encoding algorithm and then decode it back to its original form.

## Getting Started

### Prerequisites

Before using the Encoding and Decoding Utility, ensure you have the following prerequisites installed on your system:

1. .NET Core SDK: The project is built using C# and requires the .NET Core SDK to compile and run. You can download the latest version of the .NET Core SDK from the official .NET website: https://dotnet.microsoft.com/download

2. C# Compiler (csc): The .NET Core SDK includes the C# compiler (csc). Make sure the C# compiler is available in your system's PATH environment variable.

3. An Integrated Development Environment (IDE): Although not mandatory, having an IDE such as Visual Studio or Visual Studio Code can enhance your development experience and provide useful features like code completion, debugging, and project management.

### Installation

Once you have the prerequisites installed, follow these steps to set up the Encoding and Decoding Utility:

1. Navigate to the project directory:
    cd encoding-decoding-utility

2. Build the project:
    dotnet build

3. Run the application:
   dotnet run

The application should now be running, and you can start using the Encoding and Decoding Utility.

## Files

The Encoder and Decoder classes are separated into their own files.

- Encoder.cs: Contains the Encoder class responsible for encoding the input string.
- Decoder.cs: Contains the Decoder class responsible for decoding the encoded values.
- Utility.cs: Contains the Utility class with the DecimalToBinaryTwosComplement method shared by both Encoder and Decoder.
