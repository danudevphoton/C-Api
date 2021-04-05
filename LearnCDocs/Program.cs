using System;

namespace LearnCDocs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        
            int[] data;
            data = new int[3];

            Second();
            Third();
            Fourth();
            Fifth();
        }

        public static void Second()
        {
            Console.WriteLine("Second:");
            // int first = 2;
            // string second = "4";
            // string result = first + second;
            // Console.WriteLine(result);

            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            // int first = 5;
            // int second = 7;
            // string message = first.ToString() + second.ToString();
            // Console.WriteLine(message);

            string first = "5";
            string second = "7";
            int sum = int.Parse(first) + int.Parse(second);
            Console.WriteLine(sum);

            string value = "102";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");

            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            decimal total = 0m;
            string message = "";

            foreach (var getvalue in values)
            {
                decimal number;
                if (decimal.TryParse(getvalue, out number))
                {
                    total += number;
                } else
                {
                    message += getvalue;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");

            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            int result1 = Convert.ToInt32((decimal)value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }

        public static void Third()
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            // Console.WriteLine("Sorted...");
            // Array.Sort(pallets);
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");
            // Console.WriteLine("Reversed...");
            // Array.Reverse(pallets);
            // foreach (var pallete in pallets)
            // {
            //     Console.WriteLine($"-- {pallete}");
            // }

            //Console.WriteLine("");

            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            // Console.WriteLine("");

            // Console.WriteLine($"Before: {pallets[0].ToLower()}");
            // Array.Clear(pallets, 0, 2);
            // Console.WriteLine($"After: {pallets[0].ToLower()}");

            // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            // foreach (var pallet in pallets)
            // {
            //     Console.WriteLine($"-- {pallet}");
            // }

            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }       

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            //string result = new string(valueArray);
            string result = String.Join(",", valueArray);
            Console.WriteLine(result);
            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }         

            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string results = String.Join(" ", newMessage);
            Console.WriteLine(results);

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items2 = orderStream.Split(',');

            foreach (var item in items2)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }  

        }

        public static void Fourth()
        {
            string first = "Hello";
            string second = "World";
            Console.WriteLine("{1} {0}!", first, second);
            Console.WriteLine("{0} {0} {0}!", first, second);

            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");
            Console.WriteLine($"Measurement: {measurement:N4} units");

            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");

            int invoiceNumber = 1201;
            decimal productMeasurement = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
            Console.WriteLine($"     Sub Total: {subtotal:C}");
            Console.WriteLine($"           Tax: {taxPercentage:P2}");
            Console.WriteLine($"     Total Due: {total:C}");

            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12));

            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));

            string paymentId = "769";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);
            Console.WriteLine("1234567890123456789012345678901234567890");

            Console.WriteLine(formattedLine);

            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:C} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);
        }

        public static void Fifth()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            // openingPosition += 1;

            // int lengths = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, lengths));

            // openingPosition += 6;
            // int length1 = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length1));

            // openingPosition += openSpan.Length;
            // int length2 = closingPosition - openingPosition;
            // Console.WriteLine(message.Substring(openingPosition, length2));

            string messages = "(What if) there are (more than) one (set of parentheses)?";
            char[] openSymbols = { '[', '{', '(' };
            int closingPositions = 0;
            while (true)
            {
                int openingPositions = messages.IndexOfAny(openSymbols, closingPositions);

                if (openingPositions == -1) break;

                string currentSymbol = messages.Substring(openingPositions, 1);

                // Now we must find the matching closing symbol
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // Finally, use the techniques we've already learned to display the sub-string:

                openingPositions += 1;
                closingPositions = messages.IndexOf(matchingSymbol, openingPositions);

                int lengthz = closingPositions - openingPositions;
                Console.WriteLine(messages.Substring(openingPositions, lengthz));

                string data = "12345John Smith          5000  3  ";
                string updatedData = data.Remove(5, 20);
                Console.WriteLine(updatedData);

                string message2 = "This--is--ex-amp-le--da-ta";
                message2 = message2.Replace("--", " ");
                message2 = message2.Replace("-", "");
                Console.WriteLine(message2);

                string input = "<div class='product'><h2>Widgets &trade;</h2><span>5000</span></div>";

                string quantity = "";
                string output = "";

                // Your work here

                const string spanTag = "<span>";

                // Extract the quantity
                int quantityStart = input.IndexOf(spanTag);
                int quantityEnd = input.IndexOf("</span>");
                quantityStart += spanTag.Length;
                int quantityLength = quantityEnd - quantityStart;
                quantity = input.Substring(quantityStart, quantityLength);

                // Set output to input, replacing the trademark symbol with the registered trademark symbol
                output = input.Replace("&trade;", "&reg;");

                // Remove the opening <div> tag
                int divStart = input.IndexOf("<div");
                int divEnd = input.IndexOf(">");
                int divLength = divEnd - divStart;
                divLength += 1;
                output = output.Remove(divStart, divLength);

                // Remove the closing <div> tag
                int divCloseStart = output.IndexOf("</div");
                int divCloseEnd = output.IndexOf(">", divCloseStart);
                int divCloseLength = divCloseEnd - divCloseStart;
                divCloseLength += 1;
                output = output.Remove(divCloseStart, divCloseLength);

                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Output: {output}");
            }
        }
    }
}
