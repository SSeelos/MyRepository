namespace MyXUnitTestProject
{
    public class MyMemberDataTheory
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void MyTheoryA(string paramA, string paramB)
        {
            Assert.True(paramA.Equals("pA1") || paramA.Equals("pA2"));
            Assert.True(paramB.Equals("pB1") || paramB.Equals("pB2"));
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new string[] { "pA1", "pB1" };
            yield return new string[] { "pA2", "pB2" };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        [MemberData(nameof(GetDataB))]
        public void MyTheoryB(string paramA, string paramB)
        {
            Assert.True(paramA.Equals("pA1") || paramA.Equals("pA2") || paramA.Equals("pAB"));
            Assert.True(paramB.Equals("pB1") || paramB.Equals("pB2") || paramB.Equals("pBB"));
        }

        public static IEnumerable<object[]> GetDataB()
        {
            yield return new string[] { "pAB", "pBB" };
        }
    }
}
