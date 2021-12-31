/*
*	<copyright file="trabalhoPOO_6160.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>11/16/2021 4:49:48 PM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_6160
{
    /// <summary>
    /// Purpose: Definição da Classe de Encomenda
    /// Created by: renat
    /// Created on: 11/16/2021 4:49:48 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Order
    {
        #region Attributes
        DateTime date;
        string status;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Order()
        {
            date = DateTime.Now;
        }

        /// <summary>
        /// Construto de uma Encomneda com o estado da mesma
        /// </summary>
        /// <param name="status">Estado da Encomenda</param>
        public Order(string status)
        {
            date = DateTime.Now;
            this.status = status;
        }

        #endregion

        #region Properties
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
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
        ~Order()
        {
        }
        #endregion

        #endregion
    }
}