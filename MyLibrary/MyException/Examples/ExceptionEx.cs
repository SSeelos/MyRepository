using System;

namespace MyLibrary_DotNETstd_2_1
{
    public class ExceptionEx : IExample
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("try");
                throw new Exception("you done fucked up");
            }
            catch (Exception ex)
            {
                Console.WriteLine("catch");
                Console.WriteLine($"{nameof(Exception.Message)}:{Environment.NewLine}{ex.Message}");
                Console.WriteLine($"{nameof(Exception.StackTrace)}:{Environment.NewLine}{ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
