using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Stampante
{
    //4 serbatoi di colore: CMYB 
    public int C { get; set; }
    public int M { get; set; }
    public int Y { get; set; }
    public int B { get; set; }



    //e un cassetto di fogli(tutte property int)
    public int Fogli { get; set; }
    public Stampante()
    {


        C = M = B = Y = 100;
        Fogli = 200;
    }

    // un metodo bool Stampa( Pagina p ) (che torna false, se l'inchiostro non è sufficiente per stampare o non ci sono pagine)
    public bool Stampa(pagina p)
    {
        if (Fogli > 0 && C > p.C && M > p.M && Y > p.Y && B > p.B)
        {

            C -= p.C;
            M -= p.M;
            Y -= p.Y;
            B -= p.B;
            Fogli--;

            return true;
        }
        return false;
    }
    //un metodo int StatoInchiostro( Colore c ) che torna la quantità di inchiostro presente nei 4 serbatoi.
    public int StatoInchiostro(string colore)
    {
        switch (colore.ToLower())
        {
            case "cyano":
                return C;
            case "yellow":
                return Y;
            case "magenta":
                return M;
            case "black":
                return B;
        }
        return 101;
    }
    // un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto
    public int StatoCarta()
    {
        return Fogli;
    }

    //un metodo void SostituisciColore( Colore c ) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
    public void SostituisciColore(Colore c)
    {
        switch (c)
        {
            case Colore.ciano:
                C = 100;
                break;
            case Colore.yellow:
                Y = 100;
                break;
            case Colore.magenta:
                M = 100;
                break;
            case Colore.black:
                B = 100;
                break;
        }
    }
    //un metodo void AggiungiCarta( int qta ) che aggiunge fogli fino ad un max di 200
    public void AggiungiCarta(int qta)
    {
        Fogli = Fogli + qta;
        if (Fogli > 200)
        {
            Fogli = 200;
        }
    }
}

