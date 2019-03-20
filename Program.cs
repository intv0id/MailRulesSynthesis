using System;
using System.IO;
using System.Reflection;
using Microsoft.ProgramSynthesis;
using Microsoft.ProgramSynthesis.Compiler;

namespace MailRules
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawGrammar = File.ReadAllText("Language/MailRulesSyntax.cs.grammar");
            CompilerOptions compileOptions = new CompilerOptions(){
                InputGrammarText = rawGrammar,
                References = CompilerReference.FromAssemblyFiles(typeof(Program).GetTypeInfo().Assembly)
            };
            Grammar grammar = DSLCompiler.Compile(compileOptions).Value;
        }
    }
}
