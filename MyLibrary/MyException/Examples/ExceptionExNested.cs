using System;

namespace MyLibrary_DotNETstd_2_1
{
    public class ExceptionExNested : IExample
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("try");
                ThrowNestedEx();
            }
            catch (MyException ex)
            {
                Console.WriteLine("catch");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                var inner = ex.InnerException;
                while (inner != null)
                {
                    Console.WriteLine(nameof(Exception.InnerException));
                    Console.WriteLine(inner.Message);
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }
            //catch any exception type
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
            catch (Exception ex)
            {
                throw new MyException("my oops", ex);
            }
        }
    }
}
