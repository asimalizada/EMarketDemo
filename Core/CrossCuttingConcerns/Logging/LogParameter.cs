using System;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogParameter
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
