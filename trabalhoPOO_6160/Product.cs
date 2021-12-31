/*
*	<copyright file="trabalhoPOO_6160.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>11/16/2021 4:49:03 PM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_6160
{
    /// <summary>
    /// Purpose: Definição da Classe de Produto
    /// Created by: renat
    /// Created on: 11/16/2021 4:49:03 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Product
    {
        #region Attributes
        int codProd;
        string name;
        string description;
        double price;
        double promo;
        string category;
        string brand;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Construtor com todos os atributos do produto
        /// </summary>
        /// <param name="codProd">Código do Produto</param>
        /// <param name="name">Nome do Produto</param>
        /// <param name="description">Descrição do Produto</param>
        /// <param name="price">Preço do produto</param>
        /// <param name="promo">Preço em promoção do Produto</param>
        /// <param name="category">Categoria do Produto</param>
        /// <param name="brand">Marca do produto</param>
        public Product( int codProd, string name, string description, double price, double promo, string category, string brand)
        {
            this.codProd = codProd;
            this.name = name;
            this.description = description;
            this.price = price;
            this.promo = promo;
            this.category = category;
            this.brand = brand;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade de Código
        /// </summary>
        public int CodProd
        {
            get { 
                return codProd; 
            }
            set {
                if (codProd >= 0)
                    codProd = value;
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
            set
            {
                name = value;
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
            set
            {
                description = value;
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
            set
            {
                price = value;
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
            set
            {
                promo = value;
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
            set
            {
                category = value;
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
            set
            {
                brand = value;
            }
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Product()
        {
        }
        #endregion

        #endregion
    }
}