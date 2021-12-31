/*
*	<copyright file="trabalhoPOO_6160.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>11/16/2021 4:49:48 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace trabalhoPOO_6160
{
    /// <summary>
    /// Purpose: Definição da Classe de Encomenda
    /// Created by: renat
    /// Created on: 11/16/2021 4:49:48 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class Order
    {
        #region Attributes
        private readonly string status;
        private readonly Client client;
        private readonly List<Product> products;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Construtor de uma Encomenda
        /// </summary>
        /// <param name="status">Estado da Encomnenda</param>
        /// <param name="client">Cliente da Encomneda</param>
        public Order(string status, Client client)
        { 
            this.status = status;
            this.client = client;
            products = new List<Product>();
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade do Estado da Encomenda
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
        /// Método para adicionar um produto à Encomenda
        /// </summary>
        /// <param name="a">Produto a adicionar à Encomenda</param>
        /// <returns>Devolve ool com o resultado da operação</returns>
        public bool AddProductOrder(Product a)
        {
            products.Add(a);
            return true;
        }

        /// <summary>
        /// Método para mostrar o info do Cliente
        /// </summary>
        /// <returns>Devolve String com o Código e o Nome</returns>
        public string ShowOrderClient()
        {
            int aux = client.CodClient;
            string aux2 = client.Name;
            
            return (aux + " - " + aux2) ;
        }

        /// <summary>
        /// Método para mostrar os Produtos da Encomenda
        /// </summary>
        /// <returns>Devolve String com o Código e o Nome</returns>
        public string ListOrderProducts()
        {
            foreach (Product product in products)
            {
                return (Convert.ToString(product.CodProd) + " - " + product.NameProduct);
            }

            return null;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Order()
        {
        }
        #endregion

        #endregion
    }
}