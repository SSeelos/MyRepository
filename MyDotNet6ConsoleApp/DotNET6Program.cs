
namespace DotNet6;
public class DotNET6Program
{
    public static void Main()
    {
        RecordType();

    }

    private static void RecordType()
    {

        //var myRecord = new
        var myRecord = new MyRecordClass()
        //var myRecord = new MyRecordStruct()
        {
            PropertyA = "A",
            PropertyB = "B"
        };

        //C# 9.0 and later,
        //a with expression produces a copy of its operand
        //with the specified properties and fields modified
        var otherRecord = myRecord with { PropertyB = "otherB" };

        WriteLine(myRecord);
        WriteLine(otherRecord);

        WriteLine($"Equals: {Equals(myRecord, otherRecord)}");
        WriteLine($"== operator: {myRecord == otherRecord}");
    }
}


