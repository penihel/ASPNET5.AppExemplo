using System;
using System.Reflection;

namespace AppExemplo.Core
{
    public static class ObjectExtentions
    {
        public static TTarget CopyTo<TTarget>(this object source)
            where TTarget : class, new()
        {
            var destination = default(TTarget);
            Type p;

           

            var destProperties = destination.GetType().GetRuntimeProperties();

            if (!(destination.GetType().Equals(source.GetType())))
                throw new ArgumentException("Type mismatch");

            foreach (var sourceProperty in source.GetType().GetRuntimeProperties())
            {
                foreach (var destProperty in destProperties)
                {
                    if (destProperty.CanWrite && destProperty.Name == sourceProperty.Name)
                    {
                        destProperty.SetValue(destination, sourceProperty.GetValue(
                            source, new object[] { }), new object[] { });

                        break;
                    }
                }
            }

            return destination;
        }
    }
}
