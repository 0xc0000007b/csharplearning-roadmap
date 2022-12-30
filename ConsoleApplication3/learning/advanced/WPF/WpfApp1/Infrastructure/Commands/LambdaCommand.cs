using System;

namespace WpfApp1.Infrastructure.Commands;

internal class LambdaCommand : Command
{
    private readonly Action<object> _execule;
    private readonly Func<object, bool> _canExecute;

    public LambdaCommand(Action<Object> Execute, Func<object, bool> CanExecute = null)
    {
        _execule = Execute ?? throw new ArgumentNullException(nameof(Execute));
        _canExecute = CanExecute;
    }

    public override bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;
    public override void Execute(object? parameter) => _execule(parameter);
    
}