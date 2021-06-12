using System;
using System.Linq;
using System.Reflection;
using Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;

namespace Core.Aspects.Postsharp.Caching
{
    [Serializable]
    public class CacheAspect : MethodInterceptionAspect
    {
        private Type _cacheType;
        private int _cacheMinute;
        private ICacheManager _cacheManager;

        public CacheAspect(Type cacheType, int cacheMinute = 120)
        {
            _cacheType = cacheType;
            _cacheMinute = cacheMinute;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (!typeof(ICacheManager).IsAssignableFrom(_cacheType))
            {
                throw new Exception("Wrong cache type");
            }

            _cacheManager = (ICacheManager) Activator.CreateInstance(_cacheType);

            base.RuntimeInitialize(method);
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var methodName = string.Format("{0}.{1}.{2}",
                args.Method.ReflectedType.Namespace,
                args.Method.ReflectedType.Name,
                args.Method.Name);   // Namespace.ClassName.MethodName

            var arguments = args.Arguments.ToList();

            var key = string.Format("{0}({1})", // MethodName(<Null>) | MethodName(Arguments)
                methodName,
                string.Join(",",
                    arguments.Select(a => a != null ? a.ToString() : "<Null>")));
            
            if (_cacheManager.IsAdd(key))
            {
                args.ReturnValue = _cacheManager.Get<object>(key);
            }

            base.OnInvoke(args);

            _cacheManager.Add(key, args.ReturnValue, _cacheMinute);

        }
    }
}
