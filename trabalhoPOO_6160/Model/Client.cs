/*
*	<copyright file="trabalhoPOO_6160.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>11/21/2021 3:50:30 AM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_6160
{
    /// <summary>
    /// Purpose: Defenição da Classe Cliente
    /// Created by: renat
    /// Created on: 11/21/2021 3:50:30 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Client : Entity
    {
        #region Attributes
        int codClient;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Client()
        {
        }

        /// <summary>
        /// Contrutor de Teste
        /// </summary>
        /// <param name="name">Nome do Cliente</param>
        /// <param name="address">Endereço do Cliente</param>
        public Client(string name, string address) : base(name, address) 
        {
        }

        /// <summary>
        /// Contrutor Completo
        /// </summary>
        /// <param name="codClient">Código do Cliente</param>
        /// <param name="name">Nome do Cliente</param>
        /// <param name="address">Endereço do Cliente</param>
        /// <param name="city">Cidade do Cliente</param>
        /// <param name="country">País do Cliente</param>
        /// <param name="zip">Código Postal do Cliente</param>
        /// <param name="vat">Número de Contribuinte do Cliente</param>
        public Client(int codClient, string name, string address, string city, string country, string zip, int vat) : base (name, address,city, country, zip, vat)
        {
            this.codClient = codClient;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade do Código de Cliente
        /// </summary>
        public int CodClient
        {
            get
            {
                return codClient;
            }
            set
            {
                if (codClient >= 0)
                    codClient = value;
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
        ~Client()
        {
        }
        #endregion

        #endregion
    }
}