using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBanca
{
    /// <summary>
    /// Il profilo dell'utente.
    /// </summary>
    public class ProfiloUtente
    {
        string nome, cognome, email, dataNascita, luogoNascita;
        string password;
        List<Conto> listaConti;

        /// <summary>
        /// Crea un Profilo Utente
        /// </summary>
        /// <param name="nome">Il nome del profilo.</param>
        /// <param name="cognome">Il cognome del profilo.</param>
        /// <param name="email">L'indirizzo e-mail associato al profilo.</param>
        /// <param name="dataNascita">La data di nascita.</param>
        /// <param name="luogoNascita">Il luogo di nascita.</param>
        /// <param name="password">La password usata per accedere al profilo.</param>
        public ProfiloUtente(string nome, string cognome, string email, string dataNascita, string luogoNascita, string password)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.dataNascita = dataNascita;
            this.luogoNascita = luogoNascita;

            this.password = password;

            listaConti = new List<Conto>();
        }


        /// <summary>
        /// Restituisce il nome del profilo.
        /// </summary>
        public string Nome { get => nome; }

        /// <summary>
        /// Restituisce il cognome del profilo.
        /// </summary>
        public string Cognome { get => cognome; }

        /// <summary>
        /// Restituisce l'indirizzo e-mail associato al profilo.
        /// <para/> Dev'essere usato per accedere al profilo.
        /// </summary>
        public string Email { get => email; }

        /// <summary>
        /// Restituisce la data di nascita.
        /// </summary>
        public string DataNascita { get => dataNascita; }

        /// <summary>
        /// Restituisce la data di nascita.
        /// </summary>
        public string LuogoNascita { get => luogoNascita; }

        /// <summary>
        /// Restituisce la password usata per accedere al profilo.
        /// <para/> Dev'essere usato per accedere al profilo.
        /// </summary>
        public string Password { get => password; }

        /// <summary>
        /// Restituisce la Lista di Conti.
        /// </summary>
        public List<Conto> ListaConti { get => listaConti; }

        /// <summary>
        /// Aggiunge un nuovo conto alla Lista di Conti.
        /// </summary>
        /// <param name="c">Il Conto da aggiungere.</param>
        public void AggiungiConto(Conto c)
        {
            listaConti.Add(c);
        }        
    }
}
