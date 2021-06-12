using System;
using System.Linq;
using System.Reflection;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net;
using PostSharp.Aspects;
using PostSharp.Extensibility;

namespace Core.Aspects.Postsharp.Logging
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method, 
        TargetMemberAttributes = MulticastAttributes.Instance)] 
    public class LogAspect : OnMethodBoundaryAspect
    {
        private Type _loggerType;

        public LogAspect(Type loggerType)
        {
            _loggerType = loggerType;
        }

        private LoggerService _loggerService;

        public override void RuntimeInitialize(MethodBase method)
        {
            if (_loggerType.BaseType != typeof(LoggerService))
            {
                throw new Exception("Wrong logger type!");
            }

            _loggerService = (LoggerService) Activator.CreateInstance(_loggerType);
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            try
            {
                if (!_loggerService.IsInfoEnabled)
                {
                    return;
                }

                var logParameters = args.Method.GetParameters()
                    .Select((p, i) => new LogParameter
                    {
                        Name = p.Name,
                        Type = p.ParameterType.Name,
                        Value = args.Arguments.GetArgument(i)
                    }).ToList();

                var logDetails = new LogDetails
                {
                    FullName = args.Method.DeclaringType == null
                        ? null
                        : args.Method.DeclaringType.Name,
                    MethodName = args.Method.Name,
                    Parameters = logParameters
                };

                _loggerService.Info(logDetails);
            }
            catch 
            {

            }

            base.OnEntry(args);

            // Table -> Log
            // Id 
            // Detail    nvarchar(MAX)
            // Date      datetime
            // Audit     nchar(10)
        }
    }
}
