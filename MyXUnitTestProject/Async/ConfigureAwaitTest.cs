namespace MyXUnitTestProject
{
    public class ConfigureAwaitTest
    {

        [Fact]
        public void Fact()
        {

        }

        async Task MyAsyncMethod()
        {
            await Task.Delay(1);

            await Task.Delay(1)
                .ConfigureAwait(continueOnCapturedContext: false);
            // Code here runs without the original
            // context (in this case, on the thread pool).
        }

    }
}
