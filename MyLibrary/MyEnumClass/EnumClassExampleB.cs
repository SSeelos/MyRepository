namespace MyLibrary_DotNETstd_2_1
{
    public class EnumClassExampleB : IExample
    {
        public void Execute()
        {
            var enumC = new MyEnumClassContainer.MyEnumClassC();
            var enumD = new MyEnumClassContainer.MyEnumClassD();
            var holder = new EnumHolderType();
            holder.Add(enumC);
            holder.Add(enumD);

            var itemC = holder.MyEnumClasses[typeof(MyEnumClassContainer.MyEnumClassC)];
            var itemD = holder.MyEnumClasses[typeof(MyEnumClassContainer.MyEnumClassD)];
        }
    }
}
