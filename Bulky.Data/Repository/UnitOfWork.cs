using Bulky.DataAccess.Repository.IRepository;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;
        private ICompanyRepository _companyRepository;
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

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
