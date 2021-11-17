namespace MyDotNet6ConsoleApp;
  
public record class MyRecordClass
{
    public string PropertyA { get; init; } = default!;
    public string PropertyB { get; init; } = default!;
    public string PropertyC { get; private set; } = default!;

    public void ChangeProp()
    {
        //init keyword prevents this:
        //PropertyA = "new";
        PropertyC = "new";
    }
}

    public record struct MyRecordStruct
    {
    public string PropertyA { get; init; } = "defaultA";
    public string PropertyB { get; init; } = "defaultB";

}

#region Note
//regular class does not support "with" expressioon
public class MyTestClass
{
    public string PropertyA { get; set; }
    public string PropertyB { get; set; }
}

//regular struc does not support "==" operator
public struct MyTestStruct
{
    public string PropertyA { get; set; }
    public string PropertyB { get; set; }
}
#endregion
