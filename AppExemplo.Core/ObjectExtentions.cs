using System;

namespace AppExemplo.Core
{
    public static class ObjectExtentions
    {
        public static TTarget CopyTo<TTarget>(this object source)
            where TTarget : class, new()
        {
            var destination = default(TTarget);

            var destProperties = destination.GetType().GetProperties();

            if (!(destination.GetType().Equals(source.GetType())))
                throw new ArgumentException("Type mismatch");

            foreach (var sourceProperty in source.GetType().GetProperties())
            {
                foreach (var destProperty in destProperties)
                {
                    if (destProperty.CanWrite && destProperty.Name == sourceProperty.Name &&
                destProperty.PropertyType.IsAssignableFrom(sourceProperty.PropertyType))
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
