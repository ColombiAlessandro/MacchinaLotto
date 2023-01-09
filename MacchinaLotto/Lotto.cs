using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacchinaLotto
{
    public class Lotto
    {
        private string _id;
        private string _dataFabb;
        private int[] _numeriEstratti;
        private int contEstratti;
        private int maxNumeri=90;
        private int contEstrazioni;

        public string ID
        {
            private set
            {
                this._id = value;
            }
            get
            {
                return _id;
            }
        }
        public string DataFabb
        {
            get
            {
                return _dataFabb;
            }
            private set
            {
                _dataFabb = value;
            }
        }
        public int[] NumeriEstratti
        {
            get { return _numeriEstratti; }
            private set { _numeriEstratti = value; }
        }
        public Lotto(string id, string dataFabb, int[] numeriEstratti, int contEstratti, int contEstrazioni)
        {
            ID = id;
            DataFabb = dataFabb;
            NumeriEstratti = numeriEstratti;
            this.contEstratti = contEstratti;
            this.contEstrazioni = contEstrazioni;
        }
        public Lotto(string id, string dataFabb) : this(id, dataFabb, null, 0,0)
        {
            NumeriEstratti = new int[maxNumeri];
        }
        public Lotto() : this("IDNULLO", "N/A", null, 0,0)
        {

        }
        public Lotto(Lotto l) : this(l.ID, l.DataFabb, l.NumeriEstratti, l.contEstratti, l.contEstrazioni)
        {

        }
        public bool Equals(Lotto l)
        {
            if (l == null) return false;
            if (this==l) return true; 
            return (this.ID == l.ID);
        }
        public Lotto Clone()
        {
            return new Lotto(this);
        }
        public int EstraiSingolo()
        {
            if (contEstratti >= 90) throw new Exception("Massimo superato");
            bool controllo=true;
            Random r = new Random();
            if (contEstrazioni < 5)
            {
                while (controllo)
                {
                    int estratto = r.Next(1, 90);
                    controllo = false;
                    for (int i = 0; i < contEstratti; i++)
                    {
                        if (estratto == NumeriEstratti[i])
                        {
                            controllo = true;
                        }
                    }
                    contEstratti++;
                    NumeriEstratti[contEstratti] = estratto;
                    return estratto;
                }
                
            } else
            {
                throw new Exception("Massimo numero di estrazioni singole raggiunto");
            }
            throw new Exception("Errore");
        }
        public int[] EstraiCinque()
        {
            int [] ret = new int[5];
            int tmp = contEstrazioni;
            contEstrazioni = 0;
            for(int i = 0; i < 5; i++)
            {
                ret[i] = EstraiSingolo();
            }
            contEstrazioni = tmp;
            return ret;
        }
        public void Reset()
        {
            NumeriEstratti = new int[maxNumeri];
            contEstratti = 0;
            contEstrazioni = 0;
        }
        public int[] RegistroEstrazioni()
        {
            return NumeriEstratti;
        }
        public int VerificaEstrazioni(int[] Sequenza, int SequenzaLength)
        {
            int contRet = 0;
            for(int i = 0; i < SequenzaLength; i++)
            {
                for(int j = 0; j < contEstratti; i++)
                {
                    if (Sequenza[i] == NumeriEstratti[j]) contRet++;
                }
            }
            return contRet;
        }
        public string toString()
        {
            string stringa = $"Macchina:{ID};{DataFabb};{contEstratti.ToString()}";
            for(int i = 0; i < contEstratti; i++)
            {
                stringa += $"{NumeriEstratti[i].ToString()};";
            }
            return stringa;
        }
    }
}
