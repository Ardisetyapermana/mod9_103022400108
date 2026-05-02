// See https://aka.ms/new-console-template for more information
using Modul9_103022400108;

public class Program
{
    public static void Main(string[] args)
    {
        BankTransferConfig bankTransferConfig = new BankTransferConfig();
        double amount;

        if (bankTransferConfig.config.lang == "en")
        {
            Console.Write("Please insert the amount of money to transfer: ");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Transfer fee:" +
                (amount <= bankTransferConfig.config.transfer.threshold
                ? bankTransferConfig.config.transfer.low_fee
                : bankTransferConfig.config.transfer.high_fee)
                 );
            Console.WriteLine("Total amount: " + (amount + (amount <= bankTransferConfig.config.transfer.threshold
                ? bankTransferConfig.config.transfer.low_fee
                : bankTransferConfig.config.transfer.high_fee)));
            Console.WriteLine("Select transfer method: ");
            bankTransferConfig.config.methods.ForEach(method => Console.WriteLine(method));
        }
        else if (bankTransferConfig.config.lang == "id")
        {
            Console.Write("Masukkan jumlah uang yang akan di transfer: ");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Biaya transfer:" +
                (amount <= bankTransferConfig.config.transfer.threshold
                ? bankTransferConfig.config.transfer.low_fee
                : bankTransferConfig.config.transfer.high_fee)
                 );
            Console.WriteLine("Total biaya: " + (amount + (amount <= bankTransferConfig.config.transfer.threshold
                ? bankTransferConfig.config.transfer.low_fee
                : bankTransferConfig.config.transfer.high_fee)));
            Console.WriteLine("Pilih metode transfer: ");
            bankTransferConfig.config.methods.ForEach(method => Console.WriteLine(method));
        
        }
       
    }
}
