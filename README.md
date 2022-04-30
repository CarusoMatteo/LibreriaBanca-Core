# LibreriaBanca - Core

Questa è la repository con il codice sorgente della Libreria contenente le classi Profilo e Conto in **.NET CORE**

Per avere i file da importare in Visual Studio: https://github.com/CarusoMatteo/LibreriaBanca-SoloFile

Per vedere il progetto della banca completo: https://github.com/AliDakir05/WPFBank.git

Se il file `.xml` è stato importato correttamente saranno presenti ToolTip con spiegazioni quando si scrive il codice.

# Istruzioni per la Libreria

## Classe Profilo

Contiene gli attributi privati:

    string nome, cognome, email, dataNascita, luogoNascita, password        
    List<Conto> listaConti

A ogni attributo si può accedere tramite le **Property *Get***:

    Nome, Cognome, Email, DataNascita, LuogoNascita, Password, ListaConti

Il **Costruttore** inizializza ogni attributo:

    public ProfiloUtente(string nome, string cognome, string email, string dataNascita, string luogoNascita, string password)
    
Per aggiungere un Conto a `listaContatti` si usa il metodo:

    public void AggiungiConto(Conto c)

## Classe Conto

Contiene gli attributi privati:

    string nomeConto, passwordConto, tipoMoneta, tipoConto, chiaveConto;
    double saldo;

A ogni attributo si può accedere tramite le **Property *Get***:

    NomeConto, Email, PasswordConto, TipoMoneta, TipoConto, ChiaveConto, Saldo

Il **Costruttore** inizializza ogni attributo:

    public Conto(string nomeConto, string passwordConto, string tipoMoneta, string tipoConto, string chiaveConto)
    
Oppure imposta come `tipoMoneta` l'EUR.

    public Conto(string nomeConto, string passwordConto, string tipoConto, string chiaveConto)
    
### Agire sul saldo

Prelievo: Sottrae dal `saldo` la quantità passata come parametro.

Restituisce un valore booleano true se la transazione ha avuto successo, altrimenti false.

    public bool Prelievo(int quantità)

Deposito: Aggiunge al `saldo` la quantità passata come parametro.

    public void Deposito(int quantità)
