using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace tp_Gesper
{

    
    public class connexion
    {
        MySqlConnection cnx;
        string sCnx;
        public MySqlConnection Cnx
        { get => cnx; set => cnx = value;  }

        public connexion(string h, string user, string password, string bdd)
        {
            string sCnx;
            sCnx = string.Format("server={0}; uid={1};database={2};port=3306;pwd={3}",h,user,bdd,password);
            Cnx = new MySqlConnection(sCnx);
            try
            {
                Cnx.Open();
                Console.WriteLine("connexion reussie");
            }
            catch(Exception e)
            {
                Console.WriteLine("erreur connexion +" + e.Message.ToString());
            }
        }

        public connexion(string sCnx, MySqlConnection cnx)
        {
            this.sCnx = sCnx;
            Cnx = cnx;
        }

        public string ouvrir()
        {

        
        
            string message;
            try
            {
                
                Cnx.Open();
                message = "connexion reussie";
            }
            catch (Exception e)
            {
                message = "erreur de merde";
                Console.WriteLine("erreur connection " + e.Message.ToString());
            }
            return message;
       } 
        void fermer()
        {
            Cnx.Close();
        
 
        }
    }
}
