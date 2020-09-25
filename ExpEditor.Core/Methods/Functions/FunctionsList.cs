using System.Collections.Generic;

namespace ExpEditor.Core
{
    public static class FunctionsList
    {
        public static List<IFunctionInfo> Functions;

        static FunctionsList()
        {
            Functions = new List<IFunctionInfo>()
            {
                // Boolean
                new FunctionInfo<AndFunction>("And"),
                // Integer
                new FunctionInfo<ArithmeticFunction>("Arithmetic"),
                new FunctionInfo<StringLengthFunction>("String Length"),
                new FunctionInfo<FloatToIntegerFunction>("Float To Integer"),
                new FunctionInfo<StringToIntegerFunction>("String To Integer"),
                new FunctionInfo<RandomNumberFunction>("Random Number"),
                new FunctionInfo<MinFunction>("Min"),
                new FunctionInfo<MaxFunction>("Max"),
                new FunctionInfo<AbsFunction>("Abs"),
                new FunctionInfo<SignFunction>("Sign"),
                // String
                new FunctionInfo<ConcatenateStringsFunction>("Concatenate Strings"),
                new FunctionInfo<SubstringFunction>("Substring"),
                new FunctionInfo<IntegerToStringFunction>("Integer To String")
            };
        }

        public static void Add(IFunctionInfo functionInfo) =>
            Functions.Add(functionInfo);
    }
}
