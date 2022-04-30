using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBanca
{
    /// <summary>
    /// Uno dei Conti dell'utente.
    /// </summary>
    public class Conto
    {
        string nomeConto, passwordConto, tipoMoneta, tipoConto, chiaveConto;
        double saldo;

        /// <summary>
        /// Crea un Conto di un profilo.
        /// </summary>
        /// <param name="nomeConto">Il nome del Conto.</param>
        /// <param name="passwordConto">La password del Conto.</param>
        /// <param name="tipoMoneta">Il tipo di moneta usata nel conto.</param>
        /// <param name="tipoConto">Il tipo di conto.</param>
        /// <param name="chiaveConto">La chiave del conto.</param>
        public Conto(string nomeConto, string passwordConto, string tipoMoneta, string tipoConto, string chiaveConto)
        {
            this.nomeConto = nomeConto;
            this.passwordConto = passwordConto;
            this.tipoMoneta = tipoMoneta;
            this.tipoConto = tipoConto;
            this.chiaveConto = chiaveConto;            
        }

        /// <summary>
        /// Crea un Conto di un profilo.
        /// <para/> La moneta predefinità è l'euro (EUR).
        /// </summary>
        /// <param name="nomeConto">Il nome del Conto.</param>
        /// <param name="passwordConto">La password per accedere al Conto.</param>
        /// <param name="tipoConto">Il tipo di conto.</param>
        /// <param name="chiaveConto">La chiave del conto.</param>
        public Conto(string nomeConto, string passwordConto, string tipoConto, string chiaveConto)
        {
            this.nomeConto = nomeConto;
            this.passwordConto = passwordConto;
            tipoMoneta = "EUR";
            this.tipoConto = tipoConto;
            this.chiaveConto = chiaveConto;
        }
        
        /// <summary>
        /// Restituisce la quantità di soldi associati al conto.
        /// </summary>
        public double Saldo { get => saldo; }

        /// <summary>
        /// Restituisce il nome del Conto.
        /// </summary>
        public string NomeConto { get => nomeConto; }

        /// <summary>
        /// Restituisce la password del Conto.
        /// </summary>
        public string PasswordConto { get => passwordConto; }

        /// <summary>
        /// Restituisce il tipo di moneta usata nel conto.
        /// </summary>
        public string TipoMoneta { get => tipoMoneta; }

        /// <summary>
        /// Restituisce il tipo di conto.
        /// </summary>
        public string TipoConto { get => tipoConto; }

        /// <summary>
        /// Restituisce la chiave del conto.
        /// </summary>
        public string ChiaveConto { get => chiaveConto; }

        /// <summary>
        /// Sottrae dal saldo del conto la quantità.
        /// <para/> Restituisce un booleano in base a se la transazione è avvenuta con successo.
        /// </summary>
        /// <param name="quantità">La quantità di soldi da prelevare.</param>
        /// <returns>Se la transazione ha avuto successo.</returns>
        public bool Prelievo(int quantità)
        {
            if (saldo >= quantità)
            {
                saldo -= quantità;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Aggiunge al saldo del conto la quantità.
        /// </summary>
        /// <param name="quantità">La quantità di soldi da prelevare.</param>
        public void Deposito(int quantità)
        {
            saldo += quantità;
        }
    }
}
