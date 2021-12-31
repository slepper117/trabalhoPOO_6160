/*
*	<copyright file="trabalhoPOO_6160.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>11/20/2021 4:14:32 PM</date>
*	<description></description>
**/
using System;

namespace trabalhoPOO_6160
{
    /// <summary>
    /// Purpose: Classe Abstrata da Entidade
    /// Created by: renat
    /// Created on: 11/20/2021 4:14:32 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class Entity
    {
        #region Attributes
        string name;
        string address;
        string city;
        string country;
        string zip;
        int vat;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Entity()
        {
        }

        /// <summary>
        /// Construtor para Testes
        /// </summary>
        /// <param name="name">Nome da Entidade</param>
        /// <param name="address">Endereço de uma Entidade</param>
        public Entity(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        /// <summary>
        /// Construtor completo de uma entidade
        /// </summary>
        /// <param name="name">Nome da Entidade</param>
        /// <param name="address">Endereço de uma Entidade</param>
        /// <param name="city">Cidade de uma Entidade</param>
        /// <param name="country">País de uma Entidade</param>
        /// <param name="zip">Código Postal de uma Entidade</param>
        /// <param name="vat">Número de uma Entidade</param>
        public Entity(string name, string address, string city, string country, string zip, int vat)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.country = country;
            this.zip = zip;
            this.vat = vat;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade do Nome da Entidade
        /// </summary>
        public string Name
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
        /// Propriedade do Endereço da Entidade
        /// </summary>
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
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
            set
            {
                city = value;
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
            set
            {
                country = value;
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
            set
            {
                zip = value;
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
            set
            {
                vat = value;
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
        ~Entity()
        {
        }
        #endregion

        #endregion
    }
}