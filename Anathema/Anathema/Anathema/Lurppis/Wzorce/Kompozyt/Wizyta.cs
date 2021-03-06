﻿using System;
using System.Collections.Generic;
using Anathema.Lurppis.Wzorce.Kompozyt.Interface;

namespace Anathema.Lurppis.Wzorce.Kompozyt
{
    public class Wizyta : IKomponent
    {
        public int Cena { get; set; }
        public string NazwaWyswietlana { get; set; }

        private List<IKomponent> _listaDzieci = new List<IKomponent>();

        public Wizyta(string nazwa)
        {
            NazwaWyswietlana = nazwa;
        }

        public void Dodaj(IKomponent ob)
        {
            _listaDzieci.Add(ob);
            Cena += ob.Cena;
        }

        public void Usun(IKomponent ob)
        {
            _listaDzieci.Remove(ob);
            Cena -= ob.Cena;
        }

        public void Wyswietl(int przesuniecie)
        {
            Console.WriteLine(new String('-', przesuniecie) + String.Format("{0} : Cena {1} zł", NazwaWyswietlana, Cena));

            foreach (IKomponent ob in _listaDzieci)
            {
                ob.Wyswietl(przesuniecie + 2);
            }
        }
    }
}