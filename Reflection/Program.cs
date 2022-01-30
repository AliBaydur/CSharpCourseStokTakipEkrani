﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));
            //Console.WriteLine(dortIslem.Carp2());
            //Console.WriteLine(dortIslem.Carp(3, 4));

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type, 6, 7);
            
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine("-----------------------");

            var metodlar = type.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("MetodAdi : {0}", info.Name);
                foreach (var parametreInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parametreInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Çarpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

        public class MetodNameAttribute : Attribute
        {
            private string name;

            public MetodNameAttribute(string name)
            {
                this.name = name;
            }
        }
    }
}