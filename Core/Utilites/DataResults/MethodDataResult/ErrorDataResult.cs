using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.DataResults.MethodDataResult
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        //Başarısız Data Hatası bunu kullanıyoruz


        //ister data message ver bunları base e gönder
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //ister sadece data ver base e data ve true gönder
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //alttaki iki ctor genelde kullanılmaz
        //ister sadece message ver datayı default ver yani T türünde true ve messagı base e gönder
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //ister datayı default ver hiç bir şey yani T gönder sadece  message verme true gönder base e
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
