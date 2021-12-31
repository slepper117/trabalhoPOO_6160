/*
*	<copyright file="trabalhoPOO_6160.Model.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>12/29/2021 6:35:58 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace trabalhoPOO_6160.Model
{
    /// <summary>
    /// Purpose: Modelo com as estruturas de dados para guardar os dados
    /// Created by: renat
    /// Created on: 12/29/2021 6:35:58 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class StoreModel : IStoreModel
    {
        #region Attributes

        private readonly List<Client> clients;
        private readonly List<Supplier> suppliers;
        private readonly List<Product> products;
        private readonly Dictionary<DateTime, Order> orders;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public StoreModel()
        {
            clients = new List<Client>();
            suppliers = new List<Supplier>();
            products = new List<Product>();
            orders = new Dictionary<DateTime, Order>();
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        #region CRUD Entities

        /// <summary>
        /// Método para inserir um Cliente
        /// </summary>
        /// <param name="a">Objeto Cliente</param>
        /// <returns>Retorna Bool com o resultado da operação</returns>
        public bool AddClient(Client a)
        {
            if (clients.Exists(client => client.CodClient.Equals(a.CodClient)))
            {
                return false;
            }
            clients.Add(a);
            return true;
        }

        /// <summary>
        /// Método para inserir um Fornecedor
        /// </summary>
        /// <param name="a">Objeto Supplier</param>
        /// <returns>Retorna Bool com o resultado da operação</returns>
        public bool AddSupplier(Supplier a)
        {
            if (suppliers.Exists(supplier => supplier.CodSupplier.Equals(a.CodSupplier)))
            {
                return false;
            }
            suppliers.Add(a);
            return true;
        }

        /// <summary>
        /// Procura a primeira ocorrencia do Objeto
        /// </summary>
        /// <param name="a">Código do Cliente</param>
        /// <returns>Retorna o Objeto Client encontrado</returns>
        public Client GetClient(int a)
        {
            Client client = clients.Find(i => i.CodClient == a);
            return client;
        }

        #endregion

        #region CRUD Products

        /// <summary>
        /// Adiciona um Produto e verifica se existe ou não
        /// </summary>
        /// <param name="a">Objeto a criar</param>
        /// <returns>Retorna Bool com o resultado da operação</returns>
        public bool AddProduct(Product a)
        {
            if (products.Exists(i => i.CodProd.Equals(a.CodProd)))
                return false;
            products.Add(a);
            return true;
        }

        /// <summary>
        /// Procura a primeira ocorrencia do Objeto
        /// </summary>
        /// <param name="a">Código do Produto</param>
        /// <returns>Retorna o Objeto Product encontrado</returns>
        public Product GetProduct(int a)
        {
            Product product = products.Find(i => i.CodProd == a);
            return product;
        }

        /// <summary>
        /// Atualiza um Produto através do Código de Produto
        /// </summary>
        /// <param name="a">Código do Produto</param>
        /// <param name="b">Objeto com os Dados a atualizar</param>
        /// <returns>Retorna Objecto Product atualizado ou nulo se não existe</returns>
        public Product UpdateProduct(int a, Product b)
        {
            Product product = GetProduct(a);
            int aux = products.IndexOf(product);
            if (aux == -1)
            {
                return null;
            }
            products.Insert(aux, b);
            return product;
        }

        /// <summary>
        /// Apaga um Produto
        /// </summary>
        /// <param name="a">Código do Produto</param>
        /// <returns>Retorna Bool com o resultado da operação</returns>
        public bool DeleteProduct(int a)
        {
            Product product = GetProduct(a);
            if (product == null)
                return false;
            products.Remove(product);
            return true;
        }

        /// <summary>
        /// Lista todos os Produtos criados
        /// </summary>
        /// <returns>Retorna uma nova Lista</returns>
        public List<Product> ListProducts()
        {
            List<Product> aux = new List<Product>(products);
            return aux;
        }

        #endregion

        #region CRUD Orders

        /// <summary>
        /// Cria uma nova Encomenda
        /// </summary>
        /// <param name="a">Recebe uma Encomenda</param>
        /// <returns>Retorna Bool com o resultado da operação</returns>
        public bool AddOrder(Order a)
        {
            try
            {
                orders.Add(DateTime.Now, a);
                return true;
            }
            catch (ArgumentException)
            {
               return false;
            }
        }

        /// <summary>
        /// Lista todas as Encomendas
        /// </summary>
        /// <returns>Retorna um novo Dicionario com as Encomendas</returns>
        public Dictionary<DateTime, Order> ListOrders()
        {
            Dictionary<DateTime, Order> aux = new Dictionary<DateTime,Order>(orders);
            return aux;
        }

        #endregion
        
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~StoreModel()
        {
        }
        #endregion

        #endregion
    }
}