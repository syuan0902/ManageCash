using System;

namespace ManageCash
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy Kyo = new Guy() { m_cash = 50, m_name = "Kyo" };
            Guy Syuan = new Guy() { m_cash = 100, m_name = "Syuan" };

            while(true)
            {
                Kyo.WriteMyInfo();
                Syuan.WriteMyInfo();

                Console.Write("請輸入一個金額：　" );
                string m_howMuch = Console.ReadLine();
                if (m_howMuch == "") return;
                
                if(int.TryParse(m_howMuch, out int amount))
                {
                    Console.Write("誰應該給錢： ");
                    string m_whichGuy = Console.ReadLine();
                    
                    if(m_whichGuy == "Kyo")
                    {
                        int m_cashGiven = Kyo.GiveCash(amount);
                        Syuan.ReceiveCash(m_cashGiven);
                    }

                    else if(m_whichGuy == "Syuan")
                    {
                        int m_cashGiven = Syuan.GiveCash(amount);
                        Kyo.ReceiveCash(m_cashGiven);
                    }

                    else
                    {
                        Console.WriteLine("請輸入'Kyo'或是'Syuan'");
                    }
                }
                else
                {
                    Console.WriteLine("請輸入一個金額(或按Enter離開)");
                }
            }
           
        }
    }
}
