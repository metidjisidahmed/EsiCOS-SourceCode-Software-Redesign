using System;
using System.Collections.Generic;

namespace WpfApp2.ChainOfResp
{
    public interface Filter
    {
        Filter SetNext(Filter filter);
        List<Object> filter(List objects);
    }
}