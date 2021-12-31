/*
*	<copyright file="trabalhoPOO_6160.View.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>12/30/2021 1:42:45 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace trabalhoPOO_6160.View
{
    /// <summary>
    /// Purpose: Vista da Criação de uma Encomenda
    /// Created by: renat
    /// Created on: 12/30/2021 1:42:45 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class OrderView
    {
        #region Attributes
        private int codProduct;
        private int codClient;
        private readonly string status;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public OrderView()
        {
            status = "Pendente";
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade para do ID do Produto
        /// </summary>
        public int CodProduct
        { 
            get 
            { 
                return codProduct; 
            } 
        }

        /// <summary>
        /// Propriedade para o ID do Cliente
        /// </summary>
        public int CodClient
        { 
            get 
            { 
                return codClient; 
            } 
        }

        /// <summary>
        /// Propriedade para o Satus da Encomenda
        /// </summary>
        public string Status 
        { 
            get 
            { 
                return status; 
            } 
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Mostrar a Lista de produtos e inserir um produto na Encomenda
        /// </summary>
        /// <param name="a">Lista de Produtos criados</param>
        public void WriteListProducts(List<Product> a)
        {
            foreach (Product aux in a)
            {
                Console.WriteLine("Lista de Produtos é a seguinte:");
                Console.WriteLine("ID: {0}, Nome: {1}, Preço: {2}", aux.CodProd, aux.NameProduct, aux.Price);
            }

            try
            {
                Console.WriteLine("Introduza o ID do Produto que quer comprar:");
                codProduct = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o ID do Cliente:");
                codClient = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Dados Inválidos");
                Console.ReadKey();
                return ;
            }
        }

        /// <summary>
        /// Método para mostrar o sucesso da operação.
        /// </summary>
        /// <param name="a">Bool com o resultado da operação</param>
        public void OrderCreated(bool a)
        {
            if (a)
            {
                Console.WriteLine("Encomenda Criada com Sucesso!!!");
            }
            else
            {
                Console.WriteLine("Encomenda falhou na Criação!!!");
                return ;
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~OrderView()
        {
        }
        #endregion

        #endregion
    }
}