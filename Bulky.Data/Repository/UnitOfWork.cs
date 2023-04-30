using Bulky.DataAccess.Repository.IRepository;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;
        private ICompanyRepository _companyRepository;
        private IShoppingCartRepository _shoppingCartRepository;
        private IApplicationUserRepository _applicationUserRepository;


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICategoryRepository Category
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new CategoryRepository(_db);
                return _categoryRepository;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_db);
                return _productRepository;
            }
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_db);
                return _companyRepository;
            }
        }

        public IShoppingCartRepository ShoppingCart
        {
            get
            {
                if (_shoppingCartRepository == null)
                    _shoppingCartRepository = new ShoppingCartRepository(_db);
                return _shoppingCartRepository;
            }
        }

        public IApplicationUserRepository ApplicationUser
        {
            get
            {
                if (_applicationUserRepository == null)
                    _applicationUserRepository = new ApplicationUserRepository(_db);
                return _applicationUserRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
