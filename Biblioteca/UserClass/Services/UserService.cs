using UserClass.Entities;
using Domain.Models;
using FluentValidation;
using UserClass.Interfaces;

namespace UserClass.Services
{
    public class UserService<TEntity> : IUserService where TEntity : BaseEntity
    {
        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<User>
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TOutputModel> Get<TOutputModel>() where TOutputModel : class
        {
            throw new NotImplementedException();
        }

        public TOutputModel GetById<TOutputModel>(int id) where TOutputModel : class
        {
            throw new NotImplementedException();
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<User>
        {
            throw new NotImplementedException();
        }
    }
}
