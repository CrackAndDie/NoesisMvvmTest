using System;
using System.Windows.Input;

namespace Assets
{
    public class DelegateCommand<T> : ICommand
    {
        public DelegateCommand(Action<T> execute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, System.EventArgs.Empty);
            }
        }

        private Action<T> _execute;
    }

    public class DelegateCommand : ICommand
    {
        public DelegateCommand(Action execute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, System.EventArgs.Empty);
            }
        }

        private Action _execute;
    }
}
