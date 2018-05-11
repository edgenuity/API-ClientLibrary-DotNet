using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Author      Andrew Pieniezny <andrew.pieniezny@neric.org>
 * Version     1.7
 * Since       2018-04-24
 */
namespace RicOneApi.Models.XPress
{
    interface ICollectionType<E,T>
    {
        T GetObjects { get; set; }
        List<E> GetObject {get; set;}
    }
}
