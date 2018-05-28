using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment13_WCF
{
    
    [ServiceContract]
    public interface IBooks
    {
        [OperationContract]
         void ShowLibrary();

        [OperationContract]
        void ShowBook(int id);

        [OperationContract]
         void Add(int id, string title, string author, double Price, int year);

        [OperationContract]
        void Update(int id, int newId);


    }

   
}
