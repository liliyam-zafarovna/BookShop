using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Shop
    {
            public void Shopping()

            {
                string[][] book = new string[10][];
                book[0] = new string[] { "Mehrobdan chayon       | Abdulla Qodiriy" };
                book[1] = new string[] { "O'tkan kunlar          | Abdulla Qodiriy" };
                book[2] = new string[] { "Yashamoq               | Yuy Xua" };
                book[3] = new string[] { "Saodat asri qissalari  | Ahmad Lutfiy Qozonchi" };
                book[4] = new string[] { "Ikki eshik orasi       | O'tkir Hoshimov" };
                book[5] = new string[] { "Jimjitlik              | Said Ahmad" };
                book[6] = new string[] { "Men                    | Fotih Duman" };
                book[7] = new string[] { "I - Ayn                | Fotih Duman" };
                book[8] = new string[] { "SH - Shin              | Fotih Duman" };
                book[9] = new string[] { "Q - Qof                | Fotih Duman" };

                string login, parol, ism, raqam;
                bool result = true;
                int tanla;
                if (result == true)
                {
                    //Console.WriteLine("Kirish\t\tChiqish");
                    //tanla = Convert.ToInt32(Console.ReadLine());
                    //switch (tanla)
                    //{
                    //    case 1:

                    //    case 2:
                    //        return; break;
                    //    default: break;

                    //}
                    Console.Clear();
                    Console.WriteLine("Bizda mavjud kitoblar ro'yxati:");

                    for (int i = 0; i < book.Length; i++)
                    {
                        for (int j = 0; j < book[i].Length; j++)
                        {

                            Console.WriteLine(i + " | " + book[i][j]);
                        }
                    }
                    Console.WriteLine("Qaysi kitob haqida ma'lumotlarni olishini xohlaysiz? Kitob ID raqamini kiriting!");
                    Console.WriteLine("MA'LUMOT O'RNIDA => Bizning BookShop saytimiz sinov muddatida bo'lganligi uchun bizda faqat o'zbek tilida va 10 ta online sotuvga qo'yilgan!");
                    tanla = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (tanla)
                    {
                        case 0:
                            Console.WriteLine(book[0][0] + "..........Narxi: 35000 so'm..........Tili: O'zbek..........Soni: 3"); break;
                        case 1:
                            Console.WriteLine(book[1][0] + "..........Narxi: 400000 so'm..........Tili: O'zbek..........Soni: 2"); break;
                        case 2:
                            Console.WriteLine(book[2][0] + "..........Narxi: 59000 so'm..........Tili: O'zbek..........Soni: 5"); break;
                        case 3:
                            Console.WriteLine(book[3][0] + "..........Narxi: 119000 so'm..........Tili: O'zbek..........Soni: 11"); break;
                        case 4:
                            Console.WriteLine(book[4][0] + "..........Narxi: 40000 so'm..........Tili: O'zbek..........Soni: 1"); break;
                        case 5:
                            Console.WriteLine(book[5][0] + "..........Narxi: 25000 so'm..........Tili: O'zbek..........Soni: 7"); break;
                        case 6:
                            Console.WriteLine(book[6][0] + "..........Narxi: 79000 so'm..........Tili: O'zbek..........Soni: 4"); break;
                        case 7:
                            Console.WriteLine(book[7][0] + "..........Narxi: 59000 so'm..........Tili: O'zbek..........Soni: 3"); break;
                        case 8:
                            Console.WriteLine(book[8][0] + "..........Narxi: 69000 so'm..........Tili: O'zbek..........Soni: 3"); break;
                        case 9:
                            Console.WriteLine(book[9][0] + "..........Narxi: 89000 so'm..........Tili: O'zbek..........Soni: 3"); break;
                        default: break;

                    }
                    Console.WriteLine("Sotib olishni xohlaysizmi?");
                    Console.WriteLine("HA\t\tYO'Q");
                    tanla = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (tanla)
                    {
                        case 1:
                            Console.WriteLine("Ismingizni kiriting:");
                            ism = Console.ReadLine();
                            Console.WriteLine("Telefon raqamingizni kiriting:");
                            raqam = Console.ReadLine();
                            Console.WriteLine("Muvaffaqiyatli amalga oshirildi! Sizga bog'lanamiz!");

                            break;
                        default: break;





                    }
                }
            }
        }
    }


