using System;

namespace Cosmos.IL2CPU.X86.IL
{
	[Cosmos.IL2CPU.OpCode(ILOpCode.Code.Ldc_R4)]
	public class Ldc_R4: ILOp
	{
		public Ldc_R4(Cosmos.IL2CPU.Assembler aAsmblr):base(aAsmblr)
		{
		}

    public override void Execute(MethodInfo aMethod, ILOpCode aOpCode) {
      throw new NotImplementedException();
    }

    
		// using System;
		// using System.Linq;
		// 
		// using CPU = Indy.IL2CPU.Assembler.X86;
		// using Indy.IL2CPU.Assembler;
		// 
		// namespace Indy.IL2CPU.IL.X86 {
		// 	[OpCode(OpCodeEnum.Ldc_R4)]
		// 	public class Ldc_R4: Op {
		// 		private Single mValue;
		// 		public Ldc_R4(ILReader aReader, MethodInformation aMethodInfo)
		// 			: base(aReader, aMethodInfo) {
		// 			mValue = aReader.OperandValueSingle;
		// 		}
		// 		public override void DoAssemble() {
		// 			new CPU.Push{DestinationValue=BitConverter.ToUInt32(BitConverter.GetBytes(mValue), 0)};
		// 			Assembler.Stack.Push(new StackContent(4, typeof(Single)));
		// 		}
		// 	}
		// }
		
	}
}
