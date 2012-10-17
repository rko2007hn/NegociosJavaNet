﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Entidades
{
    public class Cliente
    {
        public Cliente(){
        }

        public int IdCliente { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }
        public string contrasena { get; set; }
        public int estado { get; set; }

        //private int _IdCliente;
        //public int IdCliente
        //{
        //    get { return _IdCliente; }
        //    set { _IdCliente = value; }
        //}
        
        //private string _dni;
        //public string Dni
        //{
        //    get { return _dni; }
        //    set { _dni = value; }
        //}
        
        //private string _nombres;
        //public string Nombres
        //{
        //    get { return _nombres; }
        //    set { _nombres = value; }
        //}
        
        //private string _apellidos;
        //public string Apellidos
        //{
        //    get { return _apellidos; }
        //    set { _apellidos = value; }
        //}

        //private string _email;
        //public string Email
        //{
        //    get { return _email; }
        //    set { _email = value; }
        //}

        //private string _direccion;
        //public string Direccion
        //{
        //    get { return _direccion; }
        //    set { _direccion = value; }
        //}

        //private string _celular;
        //public string Celular
        //{
        //    get { return _celular; }
        //    set { _celular = value; }
        //}

        //private string _contrasena;
        //public string Contrasena
        //{
        //    get { return _contrasena; }
        //    set { _contrasena = value; }
        //}

        //private int _estado;
        //public int Estado
        //{
        //    get { return _estado; }
        //    set { _estado = value; }
        //}

        //public Cliente(
        //    int IdCliente, 
        //    string Dni, 
        //    string Nombres, 
        //    string Apellidos, 
        //    string Email, 
        //    string Direccion, 
        //    string Celular, 
        //    string Contrasena, 
        //    int Estado)
        //{
        //    this.IdCliente = IdCliente;
        //    this.Dni = Dni;
        //    this.Nombres = Nombres;
        //    this.Apellidos = Apellidos;
        //    this.Email = Email;
        //    this.Direccion = Direccion;
        //    this.Celular = Celular;
        //    this.Contrasena = Contrasena;
        //    this.Estado = Estado;
        //}


        public Cliente(string Dni,string Nombres)
        {
            this.dni = Dni;
            this.nombres = Nombres;            
        }

        // Constructor para obtener datos del cliente
        public Cliente(string Dni,string Nombres,string Apellidos,string Direccion,string Celular)
        {
            this.dni = Dni;
            this.nombres = Nombres;
            this.apellidos = Apellidos;
            this.direccion = Direccion;
            this.celular = Celular;
        }



    }
}