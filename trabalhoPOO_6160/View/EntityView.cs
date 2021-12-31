/*
*	<copyright file="trabalhoPOO_6160.View.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>12/25/2021 6:04:48 PM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_6160.View
{
    /// <summary>
    /// Purpose: Vista da Criação de uma Entidade
    /// Created by: renat
    /// Created on: 12/29/2021 6:04:48 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class EntityView
    {
        #region Attributes
        private EntityType type;
        private int code;
        private string name;
        private string address;
        private string city;
        private string country;
        private string zip;
        private int vat;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public EntityView()
        {
            GetEntityValues();
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade para 
        /// </summary>
        public EntityType Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// Propriedade do Código
        /// </summary>
        public int CodeClient
        { 
            get 
            { 
                return code; 
            } 
        }
        /// <summary>
        /// Propriedade do Nome da Entidade
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Propriedade do Endereço da Entidade
        /// </summary>
        public string Address
        {
            get
            {
                return address;
            }
        }

        /// <summary>
        /// Propriedade da da Cidade da Entidade
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }
        }

        /// <summary>
        /// Propriedade do País da Entidade
        /// </summary>
        public string Country
        {
            get
            {
                return country;
            }
        }

        /// <summary>
        /// Propriedade do Código Postal da Entidade
        /// </summary>
        public string Zip
        {
            get
            {
                return zip;
            }
        }

        /// <summary>
        /// Propriedade do Número de Contribuinte da Entidade
        /// </summary>
        public int Vat
        {
            get
            {
                return vat;
            }
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Método para receber os valores para a Entidade
        /// </summary>
        public void GetEntityValues()
        {
            try 
            {
                Console.WriteLine("Escolha o tipo de Entidade: 0 - Cliente, 1 - Fornecedor");
                int aux = Convert.ToInt32(Console.ReadLine());
                if (aux > 1)
                {
                    Console.WriteLine("Escolha o tipo de Entidade: 0 - Cliente, 1 - Fornecedor");
                    aux = Convert.ToInt32(Console.ReadLine());
                    type = (EntityType)aux;
                }
                Console.WriteLine("Insira o Código da Entidade");
                code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o Nome da Entidade");
                name = Console.ReadLine();
                Console.WriteLine("Insira o Endereço da Entidade");
                address = Console.ReadLine();
                Console.WriteLine("Insira a Cidade da Entidade");
                city = Console.ReadLine();
                Console.WriteLine("Insira o País da Entidade");
                country = Console.ReadLine();
                Console.WriteLine("Insira o Código Postal");
                zip = Console.ReadLine();
                Console.WriteLine("Insira o VAT da Entidade");
                vat = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception) 
            {
                Console.WriteLine("Dados Inválidos");
                Console.ReadKey();
                return ;
            }
        }

        /// <summary>
        /// Método para mostrar o sucesso da Operação e os dados criados
        /// </summary>
        /// <param name="t">Tipo de Entidade</param>
        /// <param name="a">Código da Entidade</param>
        /// <param name="b">Nome da Entidade</param>
        public void EntityCreated(EntityType t, int a, string b, bool c)
        {
            if (t == EntityType.Client)
            {
                if (!c)
                {
                    Console.WriteLine("Cliente não foi criado!!!");
                    Console.ReadKey();
                    return ;
                }
                else
                {
                    Console.WriteLine("Cliente Criado!!!");
                    Console.WriteLine("O ID é o {0} e o Nome {1}", a, b);
                    Console.ReadKey();
                }
            }
            else
            {
                if (!c)
                {
                    Console.WriteLine("Fornecedor não foi criado!!!");
                    Console.WriteLine("O ID {0} já existe", a);
                    Console.ReadKey();
                    return ;
                }
                else
                {
                    Console.WriteLine("Fornecedor Criado!!!");
                    Console.WriteLine("O ID é o {0} e o Nome {1}", a, b);
                    Console.WriteLine("Tem de Criadr um cleinte");
                    Console.ReadKey();
                    return ;
                }

            }
        }

        /// <summary>
        /// Método para apagar a Entidade
        /// </summary>
        public void DeleteEntity()
        {
            try
            {
                Console.WriteLine("Escolha o tipo de Entidade: 0 - Cliente, 1 - Fornecedor");
                int aux = Convert.ToInt32(Console.ReadLine());
                type = (EntityType)aux;
                Console.WriteLine("Insira o código da Entidade");
                code = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Dados Inválidos");
                Console.ReadKey();
                return ;
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~EntityView()
        {
        }
        #endregion

        #endregion
    }
}