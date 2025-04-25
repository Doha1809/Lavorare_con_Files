using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace EsercizioFile
{
    internal class Persona : IEquatable<Persona>
    {
        private string id;
        private string cognome;
        private string nome;
        public string Id
        {
            get { return id; }
            protected set { id = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            protected set { cognome = value; }
        }
        public string Nome
        {
            get { return nome; }
            protected set { nome = value; }
        }

        public string ToString()
        {
            string stringa;

            stringa = Nome + ";" + Cognome + ";" + Id + ";";

            return stringa;
        }

        public bool Equals(Persona o)
        {

            if (o == null) return false;

            if (o == this) return true;

            if (o.Id == Id)
                return true;
            else
                return false;

        }

        public Persona(string Id, string Cognome, string Nome)
        {
            this.Id = Id;
            this.Cognome = Cognome;
            this.Nome = Nome;
        }
    }
}
