using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1HW
{
    public class Program
    {
        public static void Main()
        {
            Account alexAccount = new Account("Alex's account", 1500.00);
            Account mariaAccount = new Account("Maria's account", 5000.00);

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Баланс рахунку Alex: " + alexAccount.Balance);
                Console.WriteLine("Баланс рахунку Maria: " + mariaAccount.Balance);

                Console.WriteLine("\nОберіть операцію:");
                Console.WriteLine("1. Поповнити рахунок Alex");
                Console.WriteLine("2. Зняти гроші з рахунку Alex");
                Console.WriteLine("3. Поповнити рахунок Maria");
                Console.WriteLine("4. Зняти гроші з рахунку Maria");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введіть суму для поповнення рахунку Alex: ");
                        double alexDeposit = Convert.ToDouble(Console.ReadLine());
                        alexAccount.Deposit(alexDeposit);
                        Console.WriteLine("Новий баланс рахунку Alex: " + alexAccount.Balance);
                        break;

                    case 2:
                        Console.Write("Введіть суму для зняття з рахунку Alex: ");
                        double alexWithdrawal = Convert.ToDouble(Console.ReadLine());
                        alexAccount.TakeMoney(alexWithdrawal);
                        Console.WriteLine("Новий баланс рахунку Alex: " + alexAccount.Balance);
                        break;

                    case 3:
                        Console.Write("Введіть суму для поповнення рахунку Maria: ");
                        double mariaDeposit = Convert.ToDouble(Console.ReadLine());
                        mariaAccount.Deposit(mariaDeposit);
                        Console.WriteLine("Новий баланс рахунку Maria: " + mariaAccount.Balance);
                        break;

                    case 4:
                        Console.Write("Введіть суму для зняття з рахунку Maria: ");
                        double mariaWithdrawal = Convert.ToDouble(Console.ReadLine());
                        mariaAccount.TakeMoney(mariaWithdrawal);
                        Console.WriteLine("Новий баланс рахунку Maria: " + mariaAccount.Balance);
                        break;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}
