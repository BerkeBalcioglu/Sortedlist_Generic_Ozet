using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTEDLİST_GENERİC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList slist = new SortedList();
            slist.Add("1", "berke bal");                             // keys-value    :     sol taraf keys- sağ taraf value
            slist.Add("2", "namık ekin");
            slist.Add("3", "acun ılıcalı");
            slist.Add("4", "teyip");
            foreach (DictionaryEntry item in slist)
            {
                Console.WriteLine(item.Key + "    :   "  + item.Value);   // foreach ile yazdrıma
            }
         for (int i = 0; i< slist.Count; i++)
            {
                Console.WriteLine(slist.GetKey(i) + " :  " + slist.GetByIndex(i));    // get key ve getbyındex ile çağır ve listele.
            }
         foreach (object anahtar in slist.Keys)                                       // anahtar nesene yap ve keys(anahtar) kategorisine ekle slistteki anahtarlardan birisi oluyor.
            {
                Console.WriteLine(anahtar + " : " +  slist[anahtar]);
            }

            bool cevap = slist.Contains("1");                                            // CONTAİNS içine girilen değişken listede var mı yok mu onu söyler.
            Console.WriteLine(cevap);
            cevap= slist.ContainsKey("2");                                               //anahtarlar arasında bu değer var mı yokmu onu bulur.
            Console.WriteLine(cevap);
            cevap= slist.ContainsValue("3");                                             // değişken valudamı onu sorgular  3 değişkeni valuda değil keys tedir.
            Console.WriteLine(cevap);
            int x = slist.IndexOfKey("1");                                               // değişkenin anahtar-key tarafında kaçıncı sırada olduğunu söyler.
            Console.WriteLine(x);
            x = slist.IndexOfValue("1");                                                 // değişeknin value-değer ksımında kaçıncı sırada olduğunu söyler.
            Console.WriteLine(x);                                                         

            Console.ReadKey(); 








        }
    }
}
