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
                new FunctionInfo<BooleanAndFunction>("And"),
                new FunctionInfo<BooleanOrFunction>("Or"),
                // Float
                new FunctionInfo<FloatAbsFunction>("Abs"),
                new FunctionInfo<FloatArithmeticFunction>("Arithmetic"),
                new FunctionInfo<FloatFromIntegerFunction>("Convert Integer To Float"),
                new FunctionInfo<FloatFromStringFunction>("Convert String To Float"),
                new FunctionInfo<FloatMaxFunction>("Max"),
                new FunctionInfo<FloatMinFunction>("Min"),
                new FunctionInfo<FloatRandomFunction>("Random Number"),
                // Integer
                new FunctionInfo<IntegerAbsFunction>("Abs"),
                new FunctionInfo<IntegerArithmeticFunction>("Arithmetic"),
                new FunctionInfo<IntegerBitAndFunction>("Bit And"),
                new FunctionInfo<IntegerBitOrFunction>("Bit Or"),
                new FunctionInfo<IntegerBitXorFunction>("Bit Xor"),
                new FunctionInfo<IntegerFromFloatFunction>("Convert Float To Integer"),
                new FunctionInfo<IntegerFromStringFunction>("Convert String To Integer"),
                new FunctionInfo<IntegerMaxFunction>("Max"),
                new FunctionInfo<IntegerMinFunction>("Min"),
                new FunctionInfo<IntegerRandomFunction>("Random Number"),
                new FunctionInfo<IntegerSignFunction>("Sign"),
                new FunctionInfo<IntegerStringLengthFunction>("String Length"),
                // String
                new FunctionInfo<StringConcatenateFunction>("Concatenate Strings"),
                new FunctionInfo<StringFromFloatFunction>("Convert Float To String"),
                new FunctionInfo<StringFromIntegerFunction>("Convert Integer To String"),
                new FunctionInfo<StringSubstringFunction>("Substring")
            };

            Functions = Functions
                .OrderBy(x => x.Name)
                .ToList();
        }

        public static void Add(IFunctionInfo functionInfo) =>
            Functions.Add(functionInfo);
    }
}
