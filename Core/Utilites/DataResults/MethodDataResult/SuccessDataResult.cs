using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.DataResults.MethodDataResult
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //burayı tekrar yaz copy paste ile yaptın
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        //ister sadece data ver base e data ve true gönder
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        //alttaki iki ctor genelde kullanılmaz
        //ister sadece message ver datayı default ver yani T türünde true ve messagı base e gönder
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        //ister datayı default ver hiç bir şey yani T gönder sadece  message verme true gönder base e
        public SuccessDataResult() : base(default, true) 
        {

        }
    }
}
