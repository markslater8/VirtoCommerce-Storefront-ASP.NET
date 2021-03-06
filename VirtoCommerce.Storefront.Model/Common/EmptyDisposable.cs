using System;

namespace VirtoCommerce.Storefront.Model.Common
{
    public sealed class EmptyDisposable : IDisposable
    {
        public static readonly EmptyDisposable Instance = new EmptyDisposable();

        public void Dispose()
        {
            // No-op
        }
    }
}
