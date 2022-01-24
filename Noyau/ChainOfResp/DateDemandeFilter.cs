using System;
using System.Collections.Generic;

namespace WpfApp2.ChainOfResp
{
    private List<Criteria> criterias;
    private Filter next;
    public class DateDemandeFilter : Filter
    {
        public Filter SetNext(Filter filter)
        {
            this.next = filter;
        }

        public List<Object> filter(List<Object> objects)
        {
            // filtrer les objets selon les criteres de cette class
            List<Object> filtered_objects;

            return next.filter(filtered_objects);
        }


    }
}