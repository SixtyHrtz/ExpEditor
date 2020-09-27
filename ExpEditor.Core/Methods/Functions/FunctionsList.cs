using System.Collections.Generic;
using System.Linq;

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
                new FunctionInfo<AbsFunction>("Abs"),
                new FunctionInfo<ArithmeticFunction>("Arithmetic"),
                new FunctionInfo<BitAndFunction>("Bit And"),
                new FunctionInfo<BitOrFunction>("Bit Or"),
                new FunctionInfo<BitXorFunction>("Bit Xor"),
                new FunctionInfo<FloatToIntegerFunction>("Convert Float To Integer"),
                new FunctionInfo<MaxFunction>("Max"),
                new FunctionInfo<MinFunction>("Min"),
                new FunctionInfo<RandomNumberFunction>("Random Number"),
                new FunctionInfo<SignFunction>("Sign"),
                new FunctionInfo<StringLengthFunction>("String Length"),
                new FunctionInfo<StringToIntegerFunction>("Convert String To Integer"),
                // String
                new FunctionInfo<ConcatenateStringsFunction>("Concatenate Strings"),
                new FunctionInfo<IntegerToStringFunction>("Convert Integer To String"),
                new FunctionInfo<SubstringFunction>("Substring")
            };

            Functions = Functions
                .OrderBy(x => x.Name)
                .ToList();
        }

        public static void Add(IFunctionInfo functionInfo) =>
            Functions.Add(functionInfo);
    }
}
