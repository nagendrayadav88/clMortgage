
using System.Linq.Expressions;
using BusinessService.Model;
using clMortgageDAL.Repositories.IMortgageRepository;

namespace clMortgageBAL
{
    public class clMortgageService : IMortgageService
    {
        private readonly IMortgageRepository _IMortgageRepository;
        public clMortgageService(IMortgageRepository iMortgageRepository)
        {
            _IMortgageRepository = iMortgageRepository;
        }

        public async Task<LoanDetail> Add(LoanDetail model)
        {
           var loandetail = await _IMortgageRepository.Add(model);
           return loandetail;
        }

        public async Task Delete(Guid? id)
        {
            var toDelete= await _IMortgageRepository.Get(x=>x.id==id);
            await _IMortgageRepository.Delete(toDelete);
        }

        public async Task<LoanDetail> Get(Guid? id)
        {
            return await _IMortgageRepository.Get(x=>x.id == id);
        }

        public async Task<List<LoanDetail>> GetList()
        {
            return await _IMortgageRepository.GetList();
        }

        public async Task<LoanDetail> Update(LoanDetail entity)
        {
            var toupdate = await _IMortgageRepository.Get(x=>x.id==entity.id);
            return await _IMortgageRepository.Update(toupdate);
        }
    }

}