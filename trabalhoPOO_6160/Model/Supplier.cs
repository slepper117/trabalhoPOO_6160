/*
*	<copyright file="trabalhoPOO_6160.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>11/21/2021 4:16:07 AM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_6160
{
    /// <summary>
    /// Purpose: Defenição da CLasse Fornecedor
    /// Created by: renat
    /// Created on: 11/21/2021 4:16:07 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Supplier : Entity
    {
        #region Attributes
        int codSupplier;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Supplier()
        {
        }

        /// <summary>
        /// Contrutor Completo
        /// </summary>
        /// <param name="codSupplier">Código do Fornecedor</param>
        /// <param name="name">Nome do Fornecedor</param>
        /// <param name="address">Endereço do Fornecedor</param>
        /// <param name="city">Cidade do Fornecedor</param>
        /// <param name="country">País do Fornecedor</param>
        /// <param name="zip">Código Postal do Fornecedor</param>
        /// <param name="vat">Número de Contribuinte do Fornecedor</param>
        public Supplier(int codSupplier, string name, string address, string city, string country, string zip, int vat) : base(name, address, city, country, zip, vat)
        {
            this.codSupplier = codSupplier;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade do Código de Fornecedor
        /// </summary>
        public int CodSupplier
        {
            get
            {
                return codSupplier;
            }
            set
            {
                if (codSupplier >= 0)
                    codSupplier = value;
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
        ~Supplier()
        {
        }
        #endregion

        #endregion
    }
}