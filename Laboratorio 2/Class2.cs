﻿using System;
using System.Runtime.Remoting.Channels;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new client();

            client.FirstName = "Su_Nombre;"
            client.LastName = "Su_Apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
        public class Client
        {
            //Declarando variables de instancia en clase
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public ushort Age { get; set; }

            public string GetFullName()
            {
                //Utilizando variables de inastancia dentro de metodos de la clase.
                return FirstName + " " + LastName;

            }
        }
    }



