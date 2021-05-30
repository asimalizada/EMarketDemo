using Core.CrossCuttingConcerns.Validation.FluentValidation;
using FluentValidation;
using PostSharp.Aspects;
using System;
using System.Linq;

namespace Core.Aspects.Postsharp.Validation
{
    [Serializable]
    public class ValidationAspect : OnMethodBoundaryAspect
    {
        private Type _validatorType;

        public ValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validatorInstance = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidate(validatorInstance, entity);
            }
        }
    }
}
