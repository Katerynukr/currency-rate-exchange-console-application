namespace CurrencyExchangeRate.Interfaces
{
    public interface IDisplayMessageService
    {
        string ReadCommand();
        void WriteCommand(string input);
    }
}