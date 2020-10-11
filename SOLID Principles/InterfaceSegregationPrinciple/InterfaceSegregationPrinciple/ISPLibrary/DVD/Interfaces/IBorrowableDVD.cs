using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    // Why we need this interface?
    // because just by having this interface I can have access to all the properties of dvd
    // IBorrowableDVD dvd = new DVD();
    // if we dont have this interface we would loose the leverage of accessing all properties
    // IDVD dvd = new DVD(); - Won't have properties of Iborrowable
    public interface IBorrowableDVD : IDVD,IBorrowable

    {
    }
}
