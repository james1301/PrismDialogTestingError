namespace PrismDialogTestingError;

public class DialogTestViewModel : IDialogAware
{
    public DialogCloseListener RequestClose { get; }

    public DelegateCommand DialogCloseCommand { get; }

    public DialogTestViewModel()
    {
        DialogCloseCommand = new DelegateCommand(DialogClose);
    }

    private void DialogClose()
    {
        RequestClose.Invoke(ButtonResult.Cancel);
    }

    public bool CanCloseDialog() => true;

    public void OnDialogClosed()
    {
    }

    public void OnDialogOpened(IDialogParameters parameters)
    {
    }
}
