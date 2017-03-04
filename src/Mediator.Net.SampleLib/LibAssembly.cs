using System.Reflection;

namespace Mediator.Net.SampleLib
{
    public static class LibAssembly
    {
        public static Assembly Assembly
        {
            get
            {
                return typeof(LibAssembly).GetTypeInfo().Assembly;
            }
            
        }
    }
}
