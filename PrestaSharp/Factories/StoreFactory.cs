using Bukimedia.PrestaSharp.Entities;

namespace Bukimedia.PrestaSharp.Factories
{
    public class StoreFactory : GenericFactory<store>
    {
        protected override string singularEntityName => "store";

        protected override string pluralEntityName => "stores";

        public StoreFactory(string BaseUrl, string Account, string Password) : base(BaseUrl, Account, Password) { }
    }
}
