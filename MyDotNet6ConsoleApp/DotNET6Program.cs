//namespace for this document
using MyLibrary_DotNETstd_2_1;

namespace MyDotNet6ConsoleApp;
public class DotNET6Program
{

    private static ProgramRunner programRunner = new ProgramRunner();
    public static void Main()
    {
        programRunner.RunProgram(new RecordTypeProgram());

        programRunner.RunProgram(new ThreadingProgram());

    }


}


