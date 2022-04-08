using Incremental.Common.Random;
using MediatR;
using Navigator.Actions;
using Navigator.Extensions.Probabilities.Extensions;

namespace Navigator.Extensions.Probabilities;

internal class ProbabilitiesActionMiddleware<TAction, TResponse> : IActionMiddleware<TAction, TResponse> where TAction : IAction
{
    public async Task<Status> Handle(TAction action, CancellationToken cancellationToken, RequestHandlerDelegate<Status> next)
    {
        var random = RandomProvider.GetThreadRandom()?.Next(0, 100);

        if (random.GetValueOrDefault() <= typeof(TAction).GetProbabilities())
        {
            return new Status(true);
        }

        return await next();
    }
}