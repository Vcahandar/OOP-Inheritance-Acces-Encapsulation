using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Car
    {

        public string name;
        public string color;
        protected string komfort;
        private int _horsePower;
        //public int Marka { get; set; 
        //}
        //public DateTime data { get; set; 
        //}

        public int HorsePower
        {
            get
            {
                if (_horsePower > 700)
                {

                    Console.WriteLine("Beli");
                    return _horsePower;

                }
                Console.WriteLine("Sehfdir");
                return -1;

            }

            set
            {
                
                _horsePower= value; 


            }
        } 
        

        public void Test()
        {
            sedan sedan= new sedan();

            Console.WriteLine("salam baki");
        }
    }
}


#region MyRegion


//        public Car() 
//        {
//            Console.WriteLine("Empty");
//        }



//        public Car(string text):this()
//        {
//            Console.WriteLine(text);
//        }

//        public Car(int num, string name):this()
//            {
//            Console.WriteLine(num);

//            }
//    }
//}


#endregion
 
