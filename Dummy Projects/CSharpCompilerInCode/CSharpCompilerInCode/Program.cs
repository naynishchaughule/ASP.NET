using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;

namespace CSharpCompilerInCode
{
    class Program
    {
        static void Main(string[] args)
        {            
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = "Output.exe";
            CompilerResults results = icc.CompileAssemblyFromFile(parameters, @"C:\Users\naynish\Desktop\Dummy Projects\CSharpCompilerInCode\SampleCode.cs");
            foreach (var item in results.Output)
            {
                Console.WriteLine(item);
            }
            Process.Start("Output.exe");
            Console.WriteLine("successful");
            Console.ReadLine();
        }
    }
}
