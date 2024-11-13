using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirtoli_cassaforte
{
    internal class Cassaforte
    {
        private string matricola;
        private string produttore;
        private string modello;
        private string codiceSblocco;
        private int codiceUtente;

        public string Matricola
        {
            get { return matricola; }
        }

        public string Produttore
        {
            get { return produttore; }
        }

        public string Modello
        {
            get { return modello; } 
        }

        public string CodiceSblocco
        {
            get { return codiceSblocco; }
            set { codiceSblocco = value; }
        }

        public int CodiceUtente
        {
            get { return codiceUtente; }
            set { codiceUtente = value; }
        }

        public Cassaforte(string matricola, string produttore, string modello, string codiceSblocco, int codiceUtente)
        {
            this.matricola = matricola;
            this.produttore = produttore;
            this.modello = modello;
            this.codiceSblocco = codiceSblocco;
            this.codiceUtente = codiceUtente;
        }

        public void apri()
        {
            
        }

        public void chiudi()
        {

        }

        public void sblocca()
        {

        }
    }
}
