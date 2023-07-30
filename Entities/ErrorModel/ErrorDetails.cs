using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities.ErrorModel
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);//this ile bu iki değeri alır ve json a çevirir.
        }
    }
}
//JsonSerializer.Serialize metodu, bir nesneyi JSON formatına çevirmek için kullanılır. 
//this anahtar kelimesi, bir sınıfın içerisinde tanımlı olan özelliklere ve metotlara erişmek için kullanılır. this anahtar kelimesi, sınıfın kendi kendini ifade eden bir referansıdır.
//override ile errordetail.tostring dediğimde sürekli aynı değer gelmez.değişken değerler gelebilir.