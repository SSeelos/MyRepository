using System;

namespace MyLibrary_DotNETstd_2_1
{
    public class ExceptionExNestedB : IExample
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("try");
                ThrowNestedEx();
            }
            //catch any type of exception
            catch (Exception ex)
            {
                Console.WriteLine("catch");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
        private void ThrowNestedEx()
        {
            try
            {
                throw new Exception("oops");
            }
            //catches another type of exception as is thrown
            catch (MyException ex)
            {
                throw new MyException("my oops", ex);
            }
        }
    }
}
