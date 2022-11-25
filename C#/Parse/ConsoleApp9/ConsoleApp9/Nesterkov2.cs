using System;
using System.Diagnostics;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace ConsoleApp18 {
  class Cars {
    public string name { get; set; }
    public int coast { get; set; }
    public string discription { get; set; }
    public string photo { get; set; }
    public Cars() {
      name = "";
      coast = 0;
      discription = "";
      photo = "";
    }
    public Cars(string name, int coast, string discription, string photo) {
      this.name = name;
      this.coast = coast;
      this.discription = discription;
      this.photo = photo;
    }
    public override string ToString() {
      return $"Name:{name} coast:{coast}\ndiscription:{discription}";
    }
  }
  class Program {
    public static string getSubStr(ref string html, string from, string to) {
      html = html.Remove(0, html.IndexOf(from) + from.Length);
      string substring = html[..html.IndexOf(to)];
      return substring;
    }
    static void WriteTxtFile(string filePath, string writeText) {
      FileStream fs = new FileStream(filePath, FileMode.Append);
      StreamWriter sw = new StreamWriter(fs);

      foreach (char item in writeText) {
        sw.Write($"{item}");
      }
      sw.Close();
      fs.Close();

    }

    static string ReadTxtFile(string filePath) {
      FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
      StreamReader sr = new StreamReader(fs, Encoding.UTF8);

      string text = sr.ReadToEnd();
      sr.Close();
      fs.Close();

      return text;

    }

    
    
    static void Main() {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Random rand = new Random();
      WebClient client = new WebClient();
      string html = client.DownloadString("https://av.by/");
      string[] carbrand = new string[86];
      string badcoaststr = "";               //цена включает буквы
      string goodcoaststr = "";                //цена включает только цифры
      string discription = "";
      int coast = 0;
      char c = ' ';     
      string nameofcar = "";
      int choose = 0;
      string photo = "";

      for (int ii = 0; ii != 86; ++ii) {
        getSubStr(ref html, "<OPTION value=\"", "\">");
        badcoaststr = getSubStr(ref html, "\">", "</OPTION>");

        carbrand[ii] = badcoaststr;
        Console.WriteLine(carbrand[ii]);
      }


      Console.WriteLine("Выберете марку авто");
      nameofcar = Console.ReadLine();
      string html1 = client.DownloadString("https://cars.av.by/" + nameofcar);
      html = html1;
      List<Cars> cars = new List<Cars>();

      for (int ii = 0, j = 0, page = 2; ; ++ii, ++j) {
        discription += getSubStr(ref html1, "class=\"listing-item__params\"><div>", "</div>");
        discription += " " + getSubStr(ref html1, "<div>", "<!-- -->");
        discription += " " + getSubStr(ref html1, ", <!-- -->", "<!-- -->,");

        badcoaststr = getSubStr(ref html1, "<div class=\"listing-item__price\">", "р.</div><div");
        badcoaststr = badcoaststr[..(badcoaststr.Length - 1)];
        for (int i = 0; i != badcoaststr.Length; ++i) {
          c = badcoaststr[i];
          if (c == ' ') { }
          else {
            goodcoaststr += c;
          }
        }

        photo = getSubStr(ref html, "data-srcset=\"", "2x\"/></div>");
        coast = Convert.ToInt32(goodcoaststr);
        cars.Add(new Cars(nameofcar, coast, discription, photo));
        discription = "";
        goodcoaststr = "";
        Console.WriteLine(j + " в каталоге " + cars[j]);
     

        if (html1.IndexOf("class=\"listing-item__params\"><div>") == -1) {
          html1 = client.DownloadString("https://cars.av.by/filter?brands[0][brand]=" + getSubStr(ref html1, nameofcar + "\",\"intValue\":", "},") + "&price_currency=2&page=" + page);
          html = html1;
          page++;
          ii = 0;

          if (html1.IndexOf("class=\"listing-item__params\"><div>") == -1) {
            break;
          }
        }
      }


      Console.WriteLine("Выбрать критерий поиска?");
      choose = Convert.ToInt32(Console.ReadLine());
      if (choose == 0) {
        Console.WriteLine("Какой критерий поиска?(Цена(до),год выпуска,объём двигл)");
        choose = Convert.ToInt32(Console.ReadLine());
        switch (choose) {
          case 0:
            Console.WriteLine("Введите желаемую цену");
           coast = Convert.ToInt32(Console.ReadLine());
            for (int ii = 0; ii != cars.Count; ++ii) {
              if (coast >= cars[ii].coast) {
                Console.WriteLine(ii + " в каталоге " + cars[ii]);
              }
            }
            break;
          case 1:
            Console.WriteLine("Введите год желаемого выпуска");
            discription = Console.ReadLine();
            for (int ii = 0; ii != cars.Count; ++ii) {
              if (discription == cars[ii].discription[..4]) {
                Console.WriteLine(ii + " в каталоге " + cars[ii]);
              }
            }
            break;
          case 2:
            Console.WriteLine("Введите желаемый обьем двиг");
            discription = Console.ReadLine();
            for (int ii = 0; ii != cars.Count; ++ii) {
              if (discription == cars[ii].discription[(cars[ii].discription.Length - 5)..(cars[ii].discription.Length - 2)]) {
                Console.WriteLine(ii + " в каталоге " + cars[ii]);
              }
            }
            break;
        }
      }
      else { };


      int choose1 = 0;
      while (true) {
        Console.WriteLine("Выберете авто(по номеру) которое хотите купить");
        choose = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Нужно фото авто?");
        choose1 = Convert.ToInt32(Console.ReadLine());

        if (choose1 == 0) {
          Console.WriteLine(cars[choose].photo);
        }
        else { }
        Console.WriteLine("Покупаете?");
        choose1 = Convert.ToInt32(Console.ReadLine());

        if (choose1 == 0) {
          break;
        }
        
      }
     

      WriteTxtFile("choose.txt", cars[choose].name + " ");
      WriteTxtFile("choose.txt", Convert.ToString(cars[choose].coast) + " ");
      WriteTxtFile("choose.txt", cars[choose].discription + " ");
      WriteTxtFile("choose.txt", DateTime.UtcNow.ToString() + "\n");
      WriteTxtFile("choose.txt", cars[choose].photo + "\n");


      Console.WriteLine("Показать ранее купленные авто?");
      choose1 = Convert.ToInt32(Console.ReadLine());

      if (choose1 == 0) {
        Console.WriteLine("Ранее купленное");
        Console.WriteLine(ReadTxtFile("choose.txt"));
      }
      else { }     
    }
  }
}
