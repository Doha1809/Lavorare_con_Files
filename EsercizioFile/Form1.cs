using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace EsercizioFile
{
    public partial class Form1 : Form
    {
        private Persona persona;
        private static string nomeTrovato;
        private static string cognomeTrovato;
        private static string idTrovato;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaLista();
        }
        public static void scriviAppend(string filename, string content)
        {
            FileStream oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read); // var fa si che ostream non abbia un tipo specifico. è una classe in C# che permette di leggere e scrivere byte su un file.
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content); // aggiungiamo il contenuto al file 
            sw.Close();//  chiudo. N.B. se non chiudo gli altri applicazioni non possono leggere il file. pk con fileshare.read il file puo essere letto da altri solo se il programma non lo sta modificando. non chiudere SWsignofoca che il programma lo sta ancora modificando
        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            persona = new Persona(IdCasella.Text, CognomeCasella.Text, NomeCasella.Text);

            scriviAppend(@"./persona.txt", persona.ToString());

            listBox1.Items.Add(persona.ToString());

            IdCasella.Clear(); 
            NomeCasella.Clear();
            CognomeCasella.Clear();
        }
        public static bool leggi(string filename, string Id)
        {
            StreamReader sr = new StreamReader(filename); // StreamReader è una classe che legge testo (stringhe) da un file.filename è il percorso del file da leggere(es. "persona.txt" o @"./persona.txt").
            string line; // Una riga alla volta con sr.ReadLine()
            
            while ((line = sr.ReadLine()) != null)
            {
                string[] parti = line.Split(';'); //line viene suddivisa in parti, in base a quando split incontra ";". esempio: frase: 123;doha; parti[0]--> 123, parti[1]--> doha e così via 

                if (parti[2] == Id)
                {
                    nomeTrovato = parti[0];
                    cognomeTrovato = parti[1];
                    idTrovato = parti[2];
                    sr.Close();
                    return true;
                }
            }
            return false;

            sr.Close();
        }

        private void Cerca_Click(object sender, EventArgs e)
        {
            string IdCercare = IdDaCercare.Text;

            if (leggi(@"./persona.txt", IdCercare) == true)
            {
                MessageBox.Show("L'elemento è presente nel file");
                NomeCasella.Text = nomeTrovato;
                CognomeCasella.Text = cognomeTrovato;
                IdCasella.Text = idTrovato;
            }
            else
            {
                MessageBox.Show("L'elemento non è presente nel file");
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            string idCercare = IdDaCercare.Text;
            bool trovato = false;

            StreamReader sr = new StreamReader(@"persona.txt");
            StreamWriter sw = new StreamWriter(@"daEliminare.txt");// crea un nuovo file 
            
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parti = line.Split(';');

                if (parti[2].Trim() == idCercare)
                {
                    trovato = true;
                    //Non trascrive la riga da eliminare;
                    MessageBox.Show("trovato");
                }
                else
                {
                    // Mantiene le altre righe invariate
                    sw.WriteLine(line);
                }
            }
            sr.Close();
            sw.Close();
            
            if (trovato)
            {
                File.Delete(@"persona.txt");
                File.Move(@"daEliminare.txt", @"./persona.txt");
                MessageBox.Show("Persona eliminata con successo");
                AggiornaLista();
            }
            else
            {
                File.Delete(@"daEliminare.txt"); // Elimina il file temporaneo se l'ID non è stato trovato
                MessageBox.Show("ID non trovato.");
            }
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            string idCercare = IdDaCercare.Text;
            string nuovoNome = NomeCasella.Text;
            string nuovoCognome = CognomeCasella.Text;
            bool trovato = false;

            StreamReader sr = new StreamReader(@"persona.txt");
            StreamWriter sw = new StreamWriter(@"daEliminare.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parti = line.Split(';');

                if (parti[2] == idCercare)
                {
                    // Modifica la riga con i nuovi dati
                    sw.WriteLine($"{nuovoNome};{nuovoCognome};{idCercare}");
                    trovato = true;
                }
                else
                {
                    // Mantiene le altre righe invariate
                    sw.WriteLine(line);
                }
            }
            sr.Close();
            sw.Close();

            if (trovato)
            {
                File.Delete(@"persona.txt");
                File.Move(@"daEliminare.txt", @"./persona.txt");
                MessageBox.Show("Dati modificati con successo!");
                AggiornaLista();
            }
            else
            {
                File.Delete(@"daEliminare.txt"); // Elimina il file temporaneo se l'ID non è stato trovato
                MessageBox.Show("ID non trovato.");
            }  
        }
        private void AggiornaLista()
        {
            listBox1.Items.Clear();

            if (!File.Exists(@"persona.txt"))
            {
                return; // Se il file non esiste, esce senza fare nulla
            }

            StreamReader sr = new StreamReader(@"persona.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (!listBox1.Items.Contains(line)) // Controllo per evitare duplicati
                {
                    listBox1.Items.Add(line);
                }
            }
            sr.Close();
        }
    }
}

