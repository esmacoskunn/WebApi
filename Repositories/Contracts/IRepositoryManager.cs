using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IBookRepository Book { get; }  //bu verilere erşir book ile  diğeri ise verileri kaydetme özelliğine sahip olucak save ile
        void save();


         
    }
}
