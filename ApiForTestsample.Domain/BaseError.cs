using System.Collections.Generic;
using System.Linq;

namespace ApiForTestsample.Domain
{
    public abstract class BaseError
    {
        private List<string> _errors;

        protected BaseError()
        {
            _errors = new List<string>();
        }

        public void AddError(string erro)
        {
            if (_errors == null) _errors = new List<string>();
            _errors.Add(erro);
        }

        public void AddError(IEnumerable<string> errors)
        {
            if (errors == null) errors = new List<string>();
            foreach (string error in errors) AddError(error);
        }

        public void AddError(BaseError baseError) => AddError(baseError?.GetErrors());

        public void AddError(IEnumerable<BaseError> baseErrors)
        {
            if (baseErrors == null) return;
            baseErrors.ToList().ForEach(AddError);
        }

        public List<string> GetErrors() => _errors;

        public bool IsValid() => _errors != null && !_errors.Any();
    }
}