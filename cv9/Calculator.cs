using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv9
{
    public class Calculator
    {

        private enum Stav
        {
            PrvniCislo,
            Operace,
            DruheCislo,
            Vysledek
        };

        private enum Operace
        {
            Plus,
            Minus,
            Krat,
            Deleni
        };

        private Stav _stav = Stav.PrvniCislo;
        private Operace _operace;

        public String Display { get; set; }//co se má zobrazit.
        public String Pamet { get; set; }//vzdy prazdne

        private string prvni = "";
        private string druhy = "";
        private string vysledek = "";

        private string Vysledek()
        {
            double a = Convert.ToDouble(prvni);
            double b = Convert.ToDouble(druhy);
            double vysledek = 0;

            switch (_operace)
            {
                case Operace.Plus:
                    vysledek = a + b;
                    break;
                case Operace.Minus:
                    vysledek = a - b;
                    break;
                case Operace.Krat:
                    vysledek = a * b;
                    break;
                case Operace.Deleni:
                    vysledek = a / b;
                    break;
            }

            return "" + vysledek;
        }

        public void Tlacitko(String btn)
        {
            string cislo = "";
            switch (btn)
            {
                case "0":
                    cislo += "0";
                    break;

                case "1":
                    cislo += "1";
                    break;

                case "2":
                    cislo += "2";
                    break;

                case "3":
                    cislo += "3";
                    break;

                case "4":
                    cislo += "4";
                    break;

                case "5":
                    cislo += "5";
                    break;

                case "6":
                    cislo += "6";
                    break;

                case "7":
                    cislo += "7";
                    break;

                case "8":
                    cislo += "8";
                    break;

                case "9":
                    cislo += "9";
                    break;

                case ",":
                    cislo += ",";
                    break;

                case "+":
                    _stav = Stav.Operace;
                    _operace = Operace.Plus;
                    break;

                case "-":
                    _stav = Stav.Operace;
                    _operace = Operace.Minus;
                    break;

                case "*":
                    _stav = Stav.Operace;
                    _operace = Operace.Krat;
                    break;

                case "/":
                    _stav = Stav.Operace;
                    _operace = Operace.Deleni;
                    break;

                case "=":
                    _stav = Stav.Vysledek;
                    vysledek = Vysledek();
                    Display = vysledek;
                    prvni = "";
                    druhy = "";
                    vysledek = "";
                    break;

                case "+/-":
                    if (Display != "")
                    {
                        if (_stav == Stav.PrvniCislo)
                            prvni = "" + Convert.ToDouble(prvni) * -1; 
                        if (_stav == Stav.DruheCislo)
                            druhy = "" + Convert.ToDouble(druhy) * -1;
                    }
                    break;

                case "CE":
                    if (_stav == Stav.PrvniCislo)
                    {
                        prvni = "";
                        Display = prvni;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        druhy = "";
                        Display = druhy;
                    }
                    break;

                case "C":
                    _stav = Stav.PrvniCislo;
                    Display = vysledek;
                    prvni = "";
                    druhy = "";
                    vysledek = "";
                    break;

                case "<=":
                    if (_stav == Stav.PrvniCislo)
                    {
                        prvni = prvni.Substring(0, prvni.Length - 1);
                        Display = prvni;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        druhy = prvni.Substring(0, druhy.Length - 1);
                        Display = druhy;
                    }
                    break;

                /*case "MS":
                    Pamet = Display;
                    break;

                case "MR":
                    if (_stav == Stav.PrvniCislo)
                    {
                        prvni = Pamet;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        druhy = Pamet;
                    }

                    Display = Pamet;
                    break;

                case "MC":
                    Pamet = "";
                    break;*/

                default:
                    break;
            }
            switch (_stav)
            {
                case Stav.PrvniCislo:
                    prvni += cislo;
                    Display = prvni;
                    break;

                case Stav.DruheCislo:
                    druhy += cislo;
                    Display = druhy;
                    break;

                case Stav.Operace:
                    _stav = Stav.DruheCislo;
                    break;

                case Stav.Vysledek:
                    _stav = Stav.PrvniCislo;
                    break;
            }
        }
    }
}
