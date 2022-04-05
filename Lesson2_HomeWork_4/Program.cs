using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Урок 2, задание № 4 ----");
            Console.WriteLine();

            //определение данных для чека
            string nameOrganization = "ООО 'БУФЕТ'";              //название организации
            string name = "Закусочная 'БУФЕТ'";                   //название на вывеске
            int numCheque = 106;                                  //номер чека
            string numTable = "Р34";                              //номер стола
            int numGuest = 2;                                     //кол-во гостей
            string sDate = DateTime.Now.ToShortDateString();      //дата
            string sTimeOpen = $"{DateTime.Now.Hour - 1}:{DateTime.Now.Minute}";        //время открытия стола
            string sTimePrintCheque = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";     //время печати чека   
            string sNameCashier = "Лена";                         //имя кассира
            string sNameWaiter = "Петя";                          //имя официанта
            string sNameProduct1 = "Борщ";                        //продукт 1
            string sNameProduct2 = "Пеперони";                    //продукт 2
            string sNameProduct3 = "Сельдь";                      //продукт 3
            int numProduct1 = 2;                                  //кол-во продукта 1
            int numProduct2 = 2;                                  //кол-во продукта 2
            int numProduct3 = 2;                                  //кол-во продукта 3
            double costProduct1 = 300.5;                          //стоимость продукта 1
            double costProduct2 = 459.5;                          //стоимость продукта 2
            double costProduct3 = 845.5;                          //стоимость продукта 3
            double sumCost = costProduct1 * numProduct1 + costProduct2 * numProduct2 + costProduct3 * numProduct3;  //всего

            //печать чека
            Console.WriteLine($"            {nameOrganization}             ");
            Console.WriteLine($"          {name}        ");
            Console.WriteLine($"Чек № {numCheque}     Стол № {numTable}    Гостей {numGuest}");
            Console.WriteLine($"{sDate} Открыт {sTimeOpen} Печать {sTimePrintCheque}");
            Console.WriteLine($"Кассир:   {sNameCashier}");
            Console.WriteLine($"Официант: {sNameWaiter}");
            Console.WriteLine();
            Console.WriteLine("Блюдо          Кол-во          Сумма");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{sNameProduct1}                {numProduct1}            {costProduct1 * numProduct1}");
            Console.WriteLine($"{sNameProduct2}            {numProduct2}            {costProduct2 * numProduct2}");
            Console.WriteLine($"{sNameProduct3}              {numProduct3}           {costProduct3 * numProduct3}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Всего:                          {sumCost}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Итого к оплате:                 {sumCost}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Рубли                           {sumCost}");

            //
            Console.ReadLine();
        }
    }
}
