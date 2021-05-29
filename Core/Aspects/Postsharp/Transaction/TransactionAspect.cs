using PostSharp.Aspects;
using System;
using System.Transactions;

namespace Core.Aspects.Postsharp.Transaction
{
    [Serializable]
    public class TransactionAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope();
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)(args.MethodExecutionTag)).Complete();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)(args.MethodExecutionTag)).Dispose();
        }
    }
}
