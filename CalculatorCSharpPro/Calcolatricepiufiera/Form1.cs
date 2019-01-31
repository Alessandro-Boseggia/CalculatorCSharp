using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc; // Libreira aggiunta e non presente in Visual Studio per esegure espressioni in una stringa
using NCalc.Domain;

namespace Calcolatricepiufiera
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            n = "0";
        }
        string n = "";// Variabile contenente l'esspressione
        char[] el = { '0', '.' }; // Array per eliminare di caratteri tramite il comando "nomestringa.TrimEnd"
        bool cont = false; // Variabile booleana per il controllo dello 0 dopo un operatore arittemtico dello 0
        int CV = 0; //variabile controllo della virgola
        int CO = 0;// Variabile di controllo per evitare di ritrovarsi tanti operatori arittemtici
        int CP = 0;//variabile di controllo delle parentesi

        //NUMERI
        private void uno_Click(object sender, EventArgs e)
        {
            switch (n == "0") // Utilizzo lo switch così da poter uscire dalla situazione vero o falsa evitando esecuzione di codice non desiderato
            {
                case true:// Quando il caso è vero(quasto caso viene solitamente usato per la parte prima del operatore aritmetico)

                    n = "1"; // Pongo n = 1 così da sostituire lo 0 presente 
                    ris.Text = n;// Stampo il valore di n
                    CO = 0;// Metto la variabile di controllo degli operatori arittmetici a 0 così da poter esegure un operazuione

                    break; // Esco dal caso e vado avanti senza considerare il secondo caso

                case false:// Quando il caso è falso
                    if (cont == true)// Solo quando premo 0 dopo l'operatore arittmetico il caso diventa vero. 
                    {
                        n = n.TrimEnd(el);//Elimina lo 0 dopo un operatore arittmetico e sostituendolo con il datao da me scelto
                        cont = false;//Faccio tornare il caso false per evitare rimozione di zeri che non centrano nulla
                    }
                    n = n + "1";// Aggiungo 1 dopo eventuali numeri o operatori arittmetici
                    ris.Text = n;// Stampo il valore di n
                    CO = 0;// Metto la variabile di controllo degli operatori arittmetici a 0 così da poter esegure un operazuione
                    CP = 1;
                    break;// Esco dal caso e vado avanti senza considerare il secondo caso

            }
        }


        private void due_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "2";
                    ris.Text = n;
                    CO = 0;
                    break;
                case false:
                    if (cont == true)
                    {
                        n = n.TrimEnd(el);
                        cont = false;
                    }
                    n = n + "2";
                    ris.Text = n;
                    CO = 0;
                    break;
            }

        }


        private void tre_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "3";
                    ris.Text = n;
                    CO = 0;
                    break;

                case false:
                    if (cont == true)
                    {
                        n = n.TrimEnd(el);
                        cont = false;
                    }
                    n = n + "3";
                    ris.Text = n;
                    CO = 0;
                    break;

            }
        }

        private void quattro_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "4";
                    ris.Text = n;
                    CO = 0;
                    break;
                case false:
                    if (cont == true)
                    {
                        n = n.TrimEnd(el);
                        cont = false;
                    }
                    n = n + "4";
                    ris.Text = n;
                    CO = 0;
                    break;


            }
        }

        private void cinque_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "5";
                    ris.Text = n;
                    CO = 0;
                    break;
                case false:
                    if (cont == true)
                    {
                        n = n.TrimEnd(el);
                        cont = false;
                    }
                    n = n + "5";
                    ris.Text = n;
                    CO = 0;
                    break;

            }
        }

        private void sei_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "6";
                    ris.Text = n;
                    CO = 0;
                    break;
                case false:
                    if (cont == true)
                    {
                        n = n.TrimEnd(el);
                        cont = false;
                    }
                    n = n + "6";
                    ris.Text = n;
                    CO = 0;
                    break;

            }
        }

        private void sette_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "7";
                    ris.Text = n;
                    CO = 0;
                    break;
                case false:
                    if (cont == true)
                    {
                        n = n.TrimEnd(el);
                        cont = false;
                    }
                    n = n + "7";
                    ris.Text = n;
                    CO = 0;
                    break;

            }
        }

        private void otto_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "8";
                    ris.Text = n;
                    CO = 0;
                    break;
                case false:
                    if (cont == true)
                    {
                        n = n.TrimEnd(el);
                        cont = false;
                    }
                    n = n + "8";
                    ris.Text = n;
                    CO = 0;
                    break;

            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "9";
                    ris.Text = n;
                    CO = 0;
                    break;
                case false:
                    if (cont == true)
                    {
                        n = n.TrimEnd(el);
                        cont = false;
                    }
                    n = n + "9";
                    ris.Text = n;
                    CO = 0;
                    break;

            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "0";
                    ris.Text = n;
                    CO = 0;
                    break;
                case false:

                    n = n + "0";
                    ris.Text = n;
                    if (CO == 1)//Controlla se sono stati premuti eventuali operatori arittmetici
                    {
                        cont = true;//Pongo cont a true
                    }
                    CO = 0;
                    break;

            }
        }

        //OPERAZIONI

        private void piu_Click(object sender, EventArgs e)
        {

            if (CO == 0)
            {
                switch (n == "0")
                {
                    case true:
                        n = "0+";// Aggiungo un + solo davanti allo 0 iniziale
                        ris.Text = n;
                        CO = 1;
                        break;
                    case false:
                        if (CO == 0) //controlla se è stato premuto un numero e nessun operatore arittemtico 
                        {

                            n = n.TrimEnd(el[1]); //Elimina la virgola se non è stato premuto alcun numero dopo di essa
                        }


                        n = n + "+";
                        ris.Text = n;

                        CO = 1;
                        CV = 0;
                        CP = 0;
                        break;
                }

            }
        }
        private void meno_Click(object sender, EventArgs e)
        {

            if (CO == 0)
            {
                switch (n == "0")
                {
                    case true:
                        n = "0-";// Aggiungo un - solo davanti allo 0 iniziale
                        ris.Text = n;
                        CO = 1;

                        break;

                    case false:
                        if (CO == 0)
                        {

                            n = n.TrimEnd(el[1]);
                        }
                        n = n + "-";
                        ris.Text = n;
                        CO = 1;
                        CV = 0;

                        break;
                }
            }
        }

        private void per_Click(object sender, EventArgs e)
        {

            if (CO == 0)
            {
                switch (n == "0")
                {
                    case true:
                        n = "0*";// Aggiungo un * solo davanti allo 0 iniziale
                        ris.Text = n;
                        CO = 1;
                        break;

                    case false:
                        if (CO == 0)
                        {

                            n = n.TrimEnd(el[1]);
                        }
                        n = n + "*";
                        ris.Text = n;
                        CO = 1;
                        CV = 0;

                        break;

                }
            }
        }

        private void diviso_Click(object sender, EventArgs e)
        {

            if (CO == 0)
            {

                switch (n == "0")
                {
                    case true:
                        n = "0/"; // Aggiungo un / solo davanti allo 0 iniziale
                        ris.Text = n;
                        CO = 1;

                        break;
                    case false:
                        if (CO == 0)
                        {

                            n = n.TrimEnd(el[1]);
                        }
                        n = n + "/";
                        ris.Text = n;
                        CO = 1;
                        CV = 0;

                        break;


                }
            }
        }



        //RESTO

        private void uguale_Click(object sender, EventArgs e)
        {

            try
            {
                Expression f = new Expression(n); // Oggetto che mi eleabora l'espressione

                string f2 = Convert.ToString(f.Evaluate());


                ris.Text = f2; // Sampo il risultato

                n = Convert.ToString(f.Evaluate());
            }
            catch { ris.Text = "ERROR"; }

        }


        private void canc_Click(object sender, EventArgs e)
        {
            n = "0";// Resetto n
            ris.Text = n;// Stampo n
            CV = 0;
        }



        private void virgola_Click(object sender, EventArgs e)
        {
            if (CV == 0 && CO == 0) /* Controllo se è stato premuto un operatore arittemtico e un numero. La variabile CV è impostata a  0 di default
                                       Se premo un operatore arittemtico e subito dopo un numero allora posso  mettere la virgola
                                       altrimeti non la posso mettere */
            {

                switch (n == "0")
                {
                    case true:
                        n = "0.";
                        ris.Text = n;
                        CV = 1;
                        break;
                    case false:
                        n = n + ".";
                        ris.Text = n;
                        CV = 1;
                        break;


                }
            }
        }

        private void pa_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    n = "(";
                    ris.Text = n;
                    CO = 1;
                    CP = 1;

                    break;
                case false:
                    if (CP == 0)
                    {
                        if (CO == 0)
                        {

                            n = n.TrimEnd(el[1]);
                        }
                        n = n + "(";
                        ris.Text = n;
                        CO = 1;
                        CV = 0;
                        CP = 1;
                    }

                    break;
            }


        }

        private void pc_Click(object sender, EventArgs e)
        {
            switch (n == "0")
            {
                case true:
                    
                    
                        n = ")";
                        ris.Text = n;
                        CO = 1;
                    
                    break;

                case false:
                    
                    
                        if (CO == 0)
                        {

                            n = n.TrimEnd(el[1]);
                        }
                        n = n + ")";
                        ris.Text = n;
                        
                        CV = 0;
                        
                    

                    break;

                    
            }
        }
    }
}