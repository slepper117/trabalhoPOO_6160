/*
*	<copyright file="trabalhoPOO_6160.Controller.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>12/25/2021 8:02:40 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using trabalhoPOO_6160.Model;
using trabalhoPOO_6160.View;

namespace trabalhoPOO_6160.Controller
{
    /// <summary>
    /// Purpose: Controlador do Programa
    /// Created by: renat
    /// Created on: 12/25/2021 8:02:40 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class StoreController
    {
        #region Attributes
        private readonly StoreModel storeModel;
        private readonly EntityView entityView;
        private readonly ProductView productView;
        private readonly OrderView orderView;
        private readonly Product product;
        private readonly Order order;
        private Client client;
        private Supplier supplier;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public StoreController()
        {
            // Inicializa o Modelo do Programa
            storeModel = new StoreModel();

            // Funções das Entidades
            entityView = new EntityView();
            CreateEntity(entityView.Type);

            // Funções dos Produtos
            productView = new ProductView();
            product = new Product(productView.CodProd, productView.NameProduct, productView.Description, productView.Price, productView.Promo, productView.Category, productView.Brand);
            productView.ProductCreated(storeModel.AddProduct(product));
            productView.WriteListProducts(storeModel.ListProducts());

            // Funções das Encomendas
            orderView = new OrderView();
            orderView.WriteListProducts(storeModel.ListProducts());
            order = new Order(orderView.Status, storeModel.GetClient(orderView.CodClient));
            order.AddProductOrder(storeModel.GetProduct(orderView.CodProduct));
            orderView.OrderCreated(storeModel.AddOrder(order));

            // Gera um ficheiro com as encomendas em sistema
            SaveOrdersXML(@"c:\temp\encomendas.xml", storeModel.ListOrders());
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Método para verificar qual é o tipo de Entidade e criá-la de acordo
        /// </summary>
        /// <param name="a">Tipo de Entidade: 0 - Cliente; 1 - Fornecedor</param>
        private void CreateEntity(EntityType a)
        {
            if (a == EntityType.Client)
            {
                client = new Client(entityView.CodeClient, entityView.Name, entityView.Address, entityView.City, entityView.Country, entityView.Zip, entityView.Vat);
                if (storeModel.AddClient(client)) {
                    entityView.EntityCreated(0, client.CodClient, client.Name, true);
                }
                else
                {
                    entityView.EntityCreated(0, client.CodClient, client.Name, false);
                }
            }
            else
            {
                supplier = new Supplier(entityView.CodeClient, entityView.Name, entityView.Address, entityView.City, entityView.Country, entityView.Zip, entityView.Vat);
                if (storeModel.AddSupplier(supplier))
                {
                    entityView.EntityCreated((EntityType)1, supplier.CodSupplier, supplier.Name, true);
                }
                else
                {
                    entityView.EntityCreated((EntityType)1, supplier.CodSupplier, supplier.Name, false);
                }
               
            }
        }

        /// <summary>
        /// Método para gravar Encomendas num XML
        /// </summary>
        /// <param name="a">Caminho do Ficheiro</param>
        /// <param name="b">Estrutura de Dados que contém as Encomendas</param>
        /// <returns>Retorna Bool com o resultado da operação</returns>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/standard/linq/work-dictionaries-linq-xml"/>
        /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement.-ctor?view=net-6.0"/>
        private void SaveOrdersXML(string a, Dictionary<DateTime, Order> b)
        {
            XElement listaEncomendas = new XElement("ListaEncomendas", b.Select(i =>
            new XElement(name: "Encomenda", Convert.ToString(i.Key),
                new XElement(name: "Estado", i.Value.Status),
                new XElement(name: "Cliente", i.Value.ShowOrderClient()),
                new XElement(name: "Produtos", i.Value.ListOrderProducts())
            )));
            
            StreamWriter file = new StreamWriter(a);
            file.WriteLine(listaEncomendas);
            file.Close();
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~StoreController()
        {
        }
        #endregion

        #endregion
    }
}