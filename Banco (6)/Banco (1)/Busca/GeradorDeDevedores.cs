﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Busca
{
    public class GeradorDeDevedores
    {
        public SortedSet<string> GeraList()
        {
            SortedSet<string> nomes = new SortedSet<string>();
            for(int i =0; i < 30000; i++)
            {
                nomes.Add("devedor " + i);
            }
            return nomes;
        }
    }
}
//public List<string> GeraList()
//{
//    List<string> nomes = new List<string>();
//    for (int i = 0; i < 30000; i++)
//    {
//        nomes.Add("devedor " + i);
//    }
//    return nomes;
//}
