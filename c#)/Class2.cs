using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    public class Class2
    {

        private string _position;//принадлежат 
        public static decimal salary;
        public const string COMPANY_NAME = "Ростелеком";
        public readonly string departament;//можно проинициализировать  при создании объекта



        //private string _name;
    }
        public Class2(string position, string departament)
        {
            _position = position;
            this.departament = departament;//неявная ссылка на экзепляр этого класса 
        }
        public Class2()
        {

        }
        public static int Increment(int a) {


        }

    }
}