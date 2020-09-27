using System.Collections.Generic;

namespace ExpEditor.Core
{
    public static class ConstantsList
    {
        public static List<IConstantInfo> Constants;

        static ConstantsList()
        {
            Constants = new List<IConstantInfo>()
            {
                new ConstantInfo<PlusConstant>("+"),
                new ConstantInfo<MinusConstant>("-"),
                new ConstantInfo<MultiplyConstant>("*"),
                new ConstantInfo<DivideConstant>("/"),
                new ConstantInfo<ModuloConstant>("%")
            };
        }

        public static void Add(IConstantInfo constantInfo) =>
            Constants.Add(constantInfo);
    }
}
