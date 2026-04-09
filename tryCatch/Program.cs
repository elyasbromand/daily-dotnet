using System.ComponentModel.Design;
using System.Diagnostics;

namespace tryCatch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int? number;
            try
            {
                number = int.Parse(Console.ReadLine()!);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Inconsistent input stream");
                Debug.WriteLine(ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("You ran out of memory, try to free some.");
                Debug.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Value is out of integer range");
                Debug.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Pass a value.");
                Debug.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter a valid integer");
                Debug.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Cast resulted to overflow");
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
