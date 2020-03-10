using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace tp_Gesper
{
    public class Donnees
    {
        List<Diplome> LesDiplomes;
        List<service> LesServices;
        List<Employe> LesEmployes;

        public Donnees()
        {
            LesDiplomes = new List<Diplome>();
            LesServices = new List<service>();
            LesEmployes = new List<Employe>();
            

        }
        public void AfficherDiplomes()
        {
            connexion a = new connexion("localhost", "root", "siojjr", "gesper");
            MySqlCommand Cmd;
            MySqlDataReader mdr;
            Cmd = new MySqlCommand();
            Cmd.CommandText = "select * from diplome; ";
        }
        public void chargerServices(MySqlConnection Cnx)
        {
            service unService;
            MySqlCommand Cmd;
            MySqlDataReader Rdr;
            Cmd = new MySqlCommand("select * from service; ",Cnx);
            try
            {
                Rdr = Cmd.ExecuteReader();
                while (Rdr.Read())
                {
                    // instancier un service
                    unService = new service(Rdr.GetInt32(0),Rdr.GetString(1),Rdr.GetChar(2),Rdr.GetDouble(3));
                    // ajouter ce service à la collection des services
                    LesServices.Add(unService);
                }
                Rdr.Close();
            }
            catch(Exception e)           
            {
                Console.WriteLine("{0}", e.Message);
            }
            Console.WriteLine();
        }
        public void chargerEmploye(MySqlConnection Cnx)
        {
            Employe unEmploye;
            MySqlCommand Cmd;
            MySqlDataReader Rdr;
            Cmd = new MySqlCommand("select * from employe; ", Cnx);
            try
            {
                Rdr = Cmd.ExecuteReader();
                while (Rdr.Read())
                {
                    unEmploye = new Employe(Rdr.GetInt32(0), Rdr.GetString(1), Rdr.GetString(1), Rdr.GetChar(2), Rdr.GetByte(3), Rdr.GetDecimal(4));
                }

        public void AfficherEmploye()
        {
            
            MySqlCommand Cmd;
            MySqlDataReader Rdr;
            Cmd = new MySqlCommand();
            Cmd.CommandText = "select * from employe;";
            try
            {
                Rdr = Cmd.ExecuteReader();
                while (Rdr.Read())
                {
                    //avec le numero de colonne
                    Console.WriteLine();
                }
                Rdr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            Console.WriteLine();
            }

        public void AfficherDiplomes(MySqlConnection Cnx)
        {
            MySqlCommand Cmd;
            MySqlDataReader Rdr;
            Cmd = new MySqlCommand();
            Cmd.CommandText = "select * from diplome;";
            try
            {
                Rdr = Cmd.ExecuteReader();
                while (Rdr.Read())
                {
                    //avec le numero de colonne
                    Console.WriteLine(Rdr["dip_id"].ToString() + " " + Rdr["dip_libelle"].ToString());
                }
                Rdr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("{0}",e.Message);
            }
            Console.WriteLine(); 
            }



        public void ChargerDiplomes(MySqlConnection Cnx)
        {
            Diplome d;
            MySqlCommand CommandeService = new MySqlCommand();
            CommandeService.CommandText = "diplome";

            MySqlDataReader Rdr;

            Rdr = CommandeService.ExecuteReader();
            while (Rdr.Read())
            {
                d = new Diplome(Rdr.GetInt32(0), Rdr.GetString(1));

            }
        }
        public void ChargerEmployes(MySqlConnection Cnx)
        {
            Cnx = new MySqlConnection(); //fait la connexion 
            MySqlCommand CommandEmployes = new MySqlCommand(); // crée une commande spécial pour employe
            CommandEmployes.CommandType = System.Data.CommandType.TableDirect; //lit la table directement 
            CommandEmployes.CommandText = "employe";
            MySqlCommand Cmd;
            Cmd = new MySqlCommand();
            MySqlDataReader Rdr; // Rdr est une variable qui va stocker la variable avec une boucle while
            Rdr = Cmd.ExecuteReader();//active une commande qui lit la table 
            while (Rdr.Read())
            {
                for (int i = 0;i < LesEmployes.Count; i++)
                {
                    if(Rdr.GetInt32(0) == LesDiplomes[i].Id)
                    {
                        service a = new service(Rdr.GetInt32(0), Rdr.GetString(1), Rdr.GetChar(2), Rdr.GetString(3), Rdr.GetInt32(4), Rdr.GetDouble(5));
                    }
                }
            }
        }
        public void ChargerServices(MySqlConnection Cnx)
        {
            Cnx = new MySqlConnection(); //fait la connexion 
            MySqlCommand CommandServices = new MySqlCommand(); // crée une commande spécial pour employe
            CommandServices.CommandType = System.Data.CommandType.TableDirect; //lit la table directement 
            CommandServices.CommandText = "services";
            MySqlDataReader Rdr;
            Rdr = CommandServices.ExecuteReader();
            while (Rdr.Read())
            {
                if (Rdr.GetChar(2) == 'A')
                {
                    service s = new service(Rdr.GetInt32(0), Rdr.GetString(1), Rdr.GetChar(2), Rdr.GetDouble(5));
                    LesServices.Add(s);
                }
                else
                {
                    service s = new service(Rdr.GetInt32(0), Rdr.GetString(1), Rdr.GetChar(2), Rdr.GetString(3), Rdr.GetInt32(4));
                }
            }
        }
        public void chargerServices(MySqlConnection Cnx)
        {
            service unService;
            MySqlCommand Cmd;
            MySqlDataReader Rdr;
            Cmd = new MySqlCommand("select * from service; ", Cnx);
            try
            {
                Rdr = Cmd.ExecuteReader();
                while (Rdr.Read())
                {
                    // instancier un service
                    unService = new service(Rdr.GetInt32(0), Rdr.GetString(1), Rdr.GetChar(2), Rdr.GetDouble(3));
                    // ajouter ce service à la collection des services
                    LesServices.Add(unService);
                }
                Rdr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            Console.WriteLine();
        }





    }
    }

