using System.Linq;
using Mono.Cecil;

namespace Rewriter
{
    class Program
    {
        static void Main(string[] args)
        {
            using var assemblyDefinition = AssemblyDefinition.ReadAssembly("../../../../TestLibrary/bin/Debug/net5.0/TestLibrary.dll");
            var module = assemblyDefinition.Modules.Last();
            var prop = module.Types.Last().Properties.First();
            prop.Name = prop.Name.Replace("Prop", "");
            
            assemblyDefinition.Write("../../../../TestLibrary.dll");
        }
    }
}