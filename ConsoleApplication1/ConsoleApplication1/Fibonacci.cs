﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

         class Fibonacci
    {
        public int calcular(int entero)
        {

            if (entero == 1 || entero == 2)
            {

                return 1;
            }
            else
            {
                return calcular(entero - 2) + calcular(entero - 1);
            }

            return 0;


        }
        public ArrayList calculaArray(IEnumerable myList)
        {
            ArrayList result = new ArrayList();
            foreach (int obj in myList)
            {

                result.Add(calcular(obj));
               
            } return result;
        } 
    }
}