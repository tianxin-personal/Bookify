﻿using Bookify.Domain.Abstracts;
using MediatR;

namespace Bookify.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}

public interface IBaseCommand
{
}