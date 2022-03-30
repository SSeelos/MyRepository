using MyLibrary_DotNETstd_2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDotNet6ConsoleApp;

    internal class RecordTypeProgram:IProgram
    {
    public void Run()
    {
        RecordType();
    }

        private void RecordType()
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

