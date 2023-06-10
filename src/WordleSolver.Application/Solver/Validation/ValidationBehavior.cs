using FluentValidation;
using LanguageExt.Common;

namespace WordleSolver.Application.Solver.Validation;

// public class ValidationBehavior<TRequest, TResult> : IPipelineBehavior<TRequest, Result<TResult, ValidationFailed>>
// {
//     public readonly IValidator<TRequest> _validator;
//     public ValidationBehavior(IValidator<TRequest> validator)
//     {
//         _validator = validator;
//     }
//
//
//     public async Task<Result<TResult, ValidationFailed>> Handle(
//         IRequest request, 
//         RequestHandlerDelegate<Result<TResult, ValidationFailed>> next,
//         CancellationToken cancellationToken)
//     {
//         
//     }
// }