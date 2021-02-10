using System;
using System.Collections.Generic;
using System.Text;

namespace Занятие__2
{
    class Person
    {
        /* поля/члены без модификтора по умолчанию private  
               string name; -> имеет параметр private 

        */
        public string name;
        private string _name; // для доступа создают специальные методы. смотреть ниже
        public string GetName()
        {
            return _name;
        }

        public void SetNAme(string _name)
        {
            _name = name;
        }
    }
}
