using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //generic class --> üzerinde çalışacağımız özel veri tipi var
    class MyList<T>
    {
        
        T[] items; //metodun dışında yazıldı, class ın içindeki her metottan erişilebiliriz
        public MyList() //ctor tab tab
        {
            items = new T[0];
        }
        //bir class new lendiği anda çalışan bloğa consturctor denir
        public void Add(T item)
        {
            //aşağıda new lendikten sonra elemanlar kaybolmasın diye yeni bir diziye atarız
            T[] tempArray = items;
            //geçici dizinin referansı = items'ın referansı
            items = new T[items.Length + 1];

            ////benim çözümüm:
            ////items = tempArray;
            ////items[items.Length - 1] = item;

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;
        }
    }
}
