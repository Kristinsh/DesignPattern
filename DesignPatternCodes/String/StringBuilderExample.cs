using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.String
{
    class StringBuilderExample
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            SBCleaner();  //Same but cleaner
        }

        private static void SBCleaner()
        {
            var builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('+', 10));
            Console.WriteLine(builder);

        }
    }
}
