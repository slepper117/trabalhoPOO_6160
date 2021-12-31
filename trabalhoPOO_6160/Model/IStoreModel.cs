/*
*	<copyright file="trabalhoPOO_6160.View.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>renat</author>
*   <date>12/25/2021 6:04:48 PM</date>
*	<description></description>
**/

namespace trabalhoPOO_6160.Model
{
    /// <summary>
    /// Insterface com algumas operações para implementar no Modelo da Store
    /// </summary>
    internal interface IStoreModel
    {
        bool AddClient(Client a);
        bool AddSupplier(Supplier a);
        bool AddProduct(Product a);
        bool AddOrder(Order a);
    }
}
