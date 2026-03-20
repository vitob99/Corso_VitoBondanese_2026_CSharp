using System;

class Program
{
    public static void Main(string[] args)
    {
        bool esci = false;
        int scelta_menu;
        do
        {
            scelta_menu = UserInterface.MenuPrincipale();
            switch (scelta_menu)
            {
                case 1: //nuovo contatto INSERT
                    string nome_contatto = "";
                    string numero_telefono = "";
                    UserInterface.SetContatto(ref nome_contatto, ref numero_telefono);
                    MySqlOperations.AggiungiContatto(nome_contatto, numero_telefono);
                    break;
                case 2:  //visualizza contatti  READ
                    MySqlOperations.ListaContatti();
                    break;
                case 3:  //elimina contatto per nome  DELETE
                    MySqlOperations.EliminaContatto(UserInterface.SetContatto());
                    break;
                case 4:
                    esci = true;
                    break;
                default:
                    break;
            }
        }while(esci == false);
    }
}