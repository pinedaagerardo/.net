using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webtestPGN
{
    public class Conn
    {

        public void insertNew()
        {
            MyEntities en = new MyEntities();
            var query = (from b in en.ENTITYTABLEs
                         select b.ID).Max();
            en.INSERT_ENTITYTABLE(query + 1, "siguiente: " + (query + 1));
            en.Dispose();
        }

        public void delete(int id)
        {
            MyEntities en = new MyEntities();
            ENTITYTABLE ent = (from b in en.ENTITYTABLEs
                         where b.ID == id
                         select b).FirstOrDefault();
            en.ENTITYTABLEs.Remove(ent);
            en.SaveChanges();
            en.Dispose();
        }
    }
}