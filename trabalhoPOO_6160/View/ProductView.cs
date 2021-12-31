/*
*	<copyright file="trabalhoPOO_6160.View.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>12/29/2021 11:53:39 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace trabalhoPOO_6160.View
{
    /// <summary>
    /// Purpose: Vista da Criação de um Produto
    /// Created by: renat
    /// Created on: 12/29/2021 11:53:39 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class ProductView
    {
        #region Attributes
        private int codProd;
        private string name;
        private string description;
        private int stock;
        private double price;
        private double promo;
        private string category;
        private string brand;
        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ProductView()
        {
            GetProductValues();
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade de Código
        /// </summary>
        public int CodProd
        {
            get
            {
                return codProd;
            }
        }

        /// <summary>
        /// Propriedade do nome do produto
        /// </summary>
        public string NameProduct
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Propriedade da descrição do produto
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
        }

        /// <summary>
        /// Propriedade do stock do produto
        /// </summary>
        public int Stock
        {
            get
            {
                return stock;
            }
        }
        /// <summary>
        /// Propriedade da descrição do produto
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
        }

        /// <summary>
        /// Propriedade do preço de promoção do produto
        /// </summary>
        public double Promo
        {
            get
            {
                return promo;
            }
        }
        /// <summary>
        /// Propriedade da categoria do produto
        /// </summary>
        public string Category
        {
            get
            {
                return category;
            }
        }
        /// <summary>
        /// Propriedade da marca do produto
        /// </summary>
        public string Brand
        {
            get
            {
                return brand;
            }
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Método para ler os dados de um Produto
        /// </summary>
        public void GetProductValues()
        {
            try
            {
                Console.WriteLine("Insira o Código do Produto");
                codProd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o Nome do Produto");
                name = Console.ReadLine();
                Console.WriteLine("Insira a Descrição do Produto");
                description = Console.ReadLine();
                Console.WriteLine("Insira o Stock do Produto");
                stock = Convert.ToInt32(Console.ReadLine());
                if (stock == 0)
                {
                    Console.WriteLine("Insira o Stock diferente de 0");
                    stock = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Insira o Preço");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o Preço Promoção");
                promo = Convert.ToDouble(Console.ReadLine());
                if (promo >= price)
                {
                    Console.WriteLine("Insira o Preço Promoção mais baixo que o Preço");
                    promo = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Insira a Categoria");
                category = Console.ReadLine();
                Console.WriteLine("Insira a Marca");
                brand = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Dados Inválidos");
                Console.ReadKey();
                return ;
            }

        }

        /// <summary>
        /// Método para mostrar o resultado da Operação
        /// </summary>
        /// <param name="a">Bool com o resultado da operação</param>
        public void ProductCreated(bool a)
        {
            if (a)
            {
                Console.WriteLine("Produto Criado com Sucesso!");
            }
            else
            {
                Console.WriteLine("ID do Produto já existe");
                return ;
            }
        }

        /// <summary>
        /// Método para mostrar os produtos criados
        /// </summary>
        /// <param name="a"></param>
        public void WriteListProducts(List<Product> a)
        {
            foreach (Product aux in a)
            {
                Console.WriteLine("Lista de Produtos criados:");
                Console.WriteLine("ID: {0}, Nome: {1}", aux.CodProd, aux.NameProduct);
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ProductView()
        {
        }
        #endregion

        #endregion
    }
}